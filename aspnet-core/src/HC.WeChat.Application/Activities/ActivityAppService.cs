using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.Linq;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;

using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;
using HC.WeChat.Activities.Authorization;
using HC.WeChat.Activities.DomainServices;
using HC.WeChat.Activities.Dtos;
using System;
using HC.WeChat.Authorization;

namespace HC.WeChat.Activities
{
    /// <summary>
    /// Activity应用层服务的接口实现方法
    /// </summary>
    //[AbpAuthorize(ActivityAppPermissions.Activity)]
    [AbpAuthorize(AppPermissions.Pages)]

    public class ActivityAppService : WeChatAppServiceBase, IActivityAppService
    {
        private readonly IRepository<Activity, Guid> _activityRepository;

        private readonly IActivityManager _activityManager;

        /// <summary>
        /// 构造函数
        /// </summary>
        public ActivityAppService(
            IRepository<Activity, Guid> activityRepository
            , IActivityManager activityManager
        )
        {
            _activityRepository = activityRepository;
            _activityManager = activityManager;
        }


        /// <summary>
        /// 获取Activity的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<ActivityListDto>> GetPagedActivitys(GetActivitysInput input)
        {

            var query = _activityRepository.GetAll();
            // TODO:根据传入的参数添加过滤条件

            var activityCount = await query.CountAsync();

            var activitys = await query
                    .OrderBy(input.Sorting).AsNoTracking()
                    .PageBy(input)
                    .ToListAsync();

            // var activityListDtos = ObjectMapper.Map<List <ActivityListDto>>(activitys);
            var activityListDtos = activitys.MapTo<List<ActivityListDto>>();

            return new PagedResultDto<ActivityListDto>(
                        activityCount,
                        activityListDtos
                );
        }


        /// <summary>
        /// 通过指定id获取ActivityListDto信息
        /// </summary>
        public async Task<ActivityListDto> GetActivityByIdAsync(EntityDto<Guid> input)
        {
            var entity = await _activityRepository.GetAsync(input.Id);

            return entity.MapTo<ActivityListDto>();
        }

        /// <summary>
        /// MPA版本才会用到的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetActivityForEditOutput> GetActivityForEdit(NullableIdDto<Guid> input)
        {
            var output = new GetActivityForEditOutput();
            ActivityEditDto activityEditDto;

            if (input.Id.HasValue)
            {
                var entity = await _activityRepository.GetAsync(input.Id.Value);

                activityEditDto = entity.MapTo<ActivityEditDto>();

                //activityEditDto = ObjectMapper.Map<List <activityEditDto>>(entity);
            }
            else
            {
                activityEditDto = new ActivityEditDto();
            }

            output.Activity = activityEditDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改Activity的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task CreateOrUpdateActivity(CreateOrUpdateActivityInput input)
        {

            if (input.Activity.Id.HasValue)
            {
                await UpdateActivityAsync(input.Activity);
            }
            else
            {
                await CreateActivityAsync(input.Activity);
            }
        }


        /// <summary>
        /// 新增Activity
        /// </summary>
        [AbpAuthorize(ActivityAppPermissions.Activity_CreateActivity)]
        protected virtual async Task<ActivityEditDto> CreateActivityAsync(ActivityEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<Activity>(input);

            entity = await _activityRepository.InsertAsync(entity);
            return entity.MapTo<ActivityEditDto>();
        }

        /// <summary>
        /// 编辑Activity
        /// </summary>
        [AbpAuthorize(ActivityAppPermissions.Activity_EditActivity)]
        protected virtual async Task UpdateActivityAsync(ActivityEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _activityRepository.GetAsync(input.Id.Value);
            input.MapTo(entity);

            // ObjectMapper.Map(input, entity);
            await _activityRepository.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除Activity信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(ActivityAppPermissions.Activity_DeleteActivity)]
        public async Task DeleteActivity(EntityDto<Guid> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _activityRepository.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除Activity的方法
        /// </summary>
        //[AbpAuthorize(ActivityAppPermissions.Activity_BatchDeleteActivitys)]
        public async Task BatchDeleteActivitysAsync(List<Guid> input)
        {
            //TODO:批量删除前的逻辑判断，是否允许删除
            await _activityRepository.DeleteAsync(s => input.Contains(s.Id));
        }


        /// <summary>
        /// 导出Activity为excel表
        /// </summary>
        /// <returns></returns>
        //public async Task<FileDto> GetActivitysToExcel()
        //{
        //	var users = await UserManager.Users.ToListAsync();
        //	var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
        //	await FillRoleNames(userListDtos);
        //	return _userListExcelExporter.ExportToFile(userListDtos);
        //}



        //// custom codes 

        //// custom codes end

    }
}


