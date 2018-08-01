using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;

using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using HC.WeChat.WeChatUsers.Dtos;
using HC.WeChat.WeChatUsers.DomainServices;
using System;
using HC.WeChat.Authorization;
using HC.WeChat.Dto;
using HC.WeChat.WechatEnums;
using System.Linq;
using Abp.Domain.Uow;
using HC.WeChat.WeChatGroups;
using HC.WeChat.WechatAppConfigs.Dtos;
using HC.WeChat.WechatAppConfigs;
using Senparc.Weixin.MP.AdvancedAPIs;
using Senparc.Weixin.MP.AdvancedAPIs.TemplateMessage;
using HC.WeChat.Helpers;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using Microsoft.AspNetCore.Hosting;

namespace HC.WeChat.WeChatUsers
{
    /// <summary>
    /// WeChatUser应用层服务的接口实现方法
    /// </summary>
    //[AbpAuthorize(WeChatUserAppPermissions.WeChatUser)]
    [AbpAuthorize(AppPermissions.Pages)]
    public class WeChatUserAppService : WeChatAppServiceBase, IWeChatUserAppService
    {
        private readonly IRepository<WeChatUser, Guid> _wechatuserRepository;
        private readonly IWeChatUserManager _wechatuserManager;
        private readonly IRepository<WeChatGroup, int> _wechatgroupRepository;
        private readonly IRepository<WechatAppConfig, int> _wechatappconfigRepository;
        private readonly IHostingEnvironment _hostingEnvironment;


        public int? TenantId { get; set; }
        public WechatAppConfigInfo AppConfig { get; set; }

        IWechatAppConfigAppService _wechatAppConfigAppService;

        /// <summary>
        /// 构造函数
        /// </summary>
        public WeChatUserAppService(IRepository<WeChatUser, Guid> wechatuserRepository,
       IWeChatUserManager wechatuserManager,
       IRepository<WeChatGroup, int> wechatgroupRepository,
       IWechatAppConfigAppService wechatAppConfigAppService,
            IRepository<WechatAppConfig, int> wechatappconfigRepository
              , IHostingEnvironment hostingEnvironment
        )
        {
            _hostingEnvironment = hostingEnvironment;
            _wechatuserRepository = wechatuserRepository;
            _wechatuserManager = wechatuserManager;
            _wechatgroupRepository = wechatgroupRepository;
            _wechatAppConfigAppService = wechatAppConfigAppService;
            TenantId = null;
            AppConfig = _wechatAppConfigAppService.GetWechatAppConfig(TenantId).Result;
            _wechatappconfigRepository = wechatappconfigRepository;
        }

        /// <summary>
        /// 获取WeChatUser的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<WeChatUserListDto>> GetPagedWeChatUsers(GetWeChatUsersInput input)
        {

            var query = _wechatuserRepository.GetAll()
                .WhereIf(!string.IsNullOrEmpty(input.UserName), u => u.UserName.Contains(input.UserName))
                .WhereIf(!string.IsNullOrEmpty(input.Name), u => u.NickName.Contains(input.Name) || u.UserName.Contains(input.Name) || u.Phone.Contains(input.Name))
                .WhereIf(input.UserType.HasValue, u => u.UserType == input.UserType);

            //TODO:根据传入的参数添加过滤条件
            var wechatuserCount = await query.CountAsync();

            var wechatusers = await query
                .OrderBy(input.Sorting)
                .PageBy(input)
                .ToListAsync();

            //var wechatuserListDtos = ObjectMapper.Map<List <WeChatUserListDto>>(wechatusers);
            var wechatuserListDtos = wechatusers.MapTo<List<WeChatUserListDto>>();

            return new PagedResultDto<WeChatUserListDto>(
                wechatuserCount,
                wechatuserListDtos
                );

        }

        /// <summary>
        /// 通过指定id获取WeChatUserListDto信息
        /// </summary>
        public async Task<WeChatUserListDto> GetWeChatUserByIdAsync(EntityDto<Guid> input)
        {
            var entity = await _wechatuserRepository.GetAsync(input.Id);

            return entity.MapTo<WeChatUserListDto>();
        }

        /// <summary>
        /// 导出WeChatUser为excel表
        /// </summary>
        /// <returns></returns>
        //public async Task<FileDto> GetWeChatUsersToExcel(){
        //var users = await UserManager.Users.ToListAsync();
        //var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
        //await FillRoleNames(userListDtos);
        //return _userListExcelExporter.ExportToFile(userListDtos);
        //}
        /// <summary>
        /// MPA版本才会用到的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetWeChatUserForEditOutput> GetWeChatUserForEdit(NullableIdDto<Guid> input)
        {
            var output = new GetWeChatUserForEditOutput();
            WeChatUserEditDto wechatuserEditDto;

            if (input.Id.HasValue)
            {
                var entity = await _wechatuserRepository.GetAsync(input.Id.Value);

                wechatuserEditDto = entity.MapTo<WeChatUserEditDto>();

                //wechatuserEditDto = ObjectMapper.Map<List <wechatuserEditDto>>(entity);
            }
            else
            {
                wechatuserEditDto = new WeChatUserEditDto();
            }

            output.WeChatUser = wechatuserEditDto;
            return output;

        }

        /// <summary>
        /// 添加或者修改WeChatUser的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task CreateOrUpdateWeChatUser(CreateOrUpdateWeChatUserInput input)
        {

            if (input.WeChatUser.Id.HasValue)
            {
                await UpdateWeChatUserAsync(input.WeChatUser);
            }
            else
            {
                await CreateWeChatUserAsync(input.WeChatUser);
            }
        }

        /// <summary>
        /// 新增WeChatUser
        /// </summary>
        //[AbpAuthorize(WeChatUserAppPermissions.WeChatUser_CreateWeChatUser)]
        protected virtual async Task<WeChatUserEditDto> CreateWeChatUserAsync(WeChatUserEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增
            var entity = ObjectMapper.Map<WeChatUser>(input);
            entity.TenantId = AbpSession.TenantId;
            entity = await _wechatuserRepository.InsertAsync(entity);
            return entity.MapTo<WeChatUserEditDto>();
        }

        /// <summary>
        /// 编辑WeChatUser
        /// </summary>
        //[AbpAuthorize(WeChatUserAppPermissions.WeChatUser_EditWeChatUser)]
        protected virtual async Task UpdateWeChatUserAsync(WeChatUserEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新
            var entity = await _wechatuserRepository.GetAsync(input.Id.Value);
            input.MapTo(entity);

            // ObjectMapper.Map(input, entity);
            await _wechatuserRepository.UpdateAsync(entity);
        }

        /// <summary>
        /// 删除WeChatUser信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        //[AbpAuthorize(WeChatUserAppPermissions.WeChatUser_DeleteWeChatUser)]
        public async Task DeleteWeChatUser(EntityDto<Guid> input)
        {

            //TODO:删除前的逻辑判断，是否允许删除
            await _wechatuserRepository.DeleteAsync(input.Id);
        }

        /// <summary>
        /// 批量删除WeChatUser的方法
        /// </summary>
        //[AbpAuthorize(WeChatUserAppPermissions.WeChatUser_BatchDeleteWeChatUsers)]
        public async Task BatchDeleteWeChatUsersAsync(List<Guid> input)
        {
            //TODO:批量删除前的逻辑判断，是否允许删除
            await _wechatuserRepository.DeleteAsync(s => input.Contains(s.Id));
        }

        /// <summary>
        /// 发送审核通知
        /// </summary>
        /// <param name="OpenId"></param>
        /// <param name="host"></param>
        /// <param name="currentName"></param>
        /// <returns></returns>
        public async Task SendCheckMesssage(string OpenId, string host, string currentName)
        {
            try
            {
                string templateId = await _wechatappconfigRepository.GetAll().Select(v => v.TemplateIds).FirstOrDefaultAsync();
                if (templateId != null || templateId.Length != 0)
                {
                    string[] ids = templateId.Split(',');
                    string appId = AppConfig.AppId;
                    string openId = OpenId;
                    //string templateId = "qvt7CNXBY4FzfzdX54TvMUaOi9jZ3-tdsb2NRhVp0yg";//模版id  
                    host = host ?? "http://ga.intcov.com";//host配置
                    string url = host + "/GAWX/Authorization?page=302";
                    object data = new
                    {
                        first = new TemplateDataItem("店员审核通知，请您尽快审核", "#FF0000"),
                        keyword1 = new TemplateDataItem(currentName.ToString()),
                        keyword2 = new TemplateDataItem(DateTime.Now.ToString("yyyy-MM-dd HH:mm"))
                    };
                    await TemplateApi.SendTemplateMessageAsync(appId, openId, ids[2], url, data);
                }
            }
            catch (Exception ex)
            {

                Logger.ErrorFormat("审核通知发送失败 error：{0} Exception：{1}", ex.Message, ex);
            }
        }

        [AbpAllowAnonymous]
        [UnitOfWork(isTransactional: false)]
        public async Task<WeChatUserListDto> GetWeChatUserAsync(string openId)
        {
            var user = await _wechatuserManager.GetWeChatUserAsync(openId);
            var userDto = user.MapTo<WeChatUserListDto>();
            return userDto;
        }

        /// <summary>
        /// 添加或者修改WeChatUser的方法
        /// </summary>
        /// <param name="input">微信用户实体</param>
        /// <returns></returns>
        public async Task CreateOrUpdateWeChatUserDto(WeChatUserEditDto input)
        {

            if (input.Id.HasValue)
            {
                await UpdateWeChatUserAsync(input);
            }
            else
            {
                await CreateWeChatUserAsync(input);
            }
        }
    }
}