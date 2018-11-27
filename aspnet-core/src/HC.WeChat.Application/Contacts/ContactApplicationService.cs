
using System;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.AutoMapper;
using Abp.Extensions;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Application.Services.Dto;
using Abp.Linq.Extensions;


using HC.WeChat.Contacts;
using HC.WeChat.Contacts.Dtos;
using HC.WeChat.Dto;

namespace HC.WeChat.Contacts
{
    /// <summary>
    /// Contact应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class ContactAppService : WeChatAppServiceBase, IContactAppService
    {
        private readonly IRepository<Contact, int> _entityRepository;



        /// <summary>
        /// 构造函数 
        ///</summary>
        public ContactAppService(
        IRepository<Contact, int> entityRepository
        )
        {
            _entityRepository = entityRepository;

        }


        /// <summary>
        /// 获取Contact的分页列表信息
        ///</summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task<PagedResultDto<ContactListDto>> GetPaged(GetContactsInput input)
        {

            var query = _entityRepository.GetAll();
            // TODO:根据传入的参数添加过滤条件


            var count = await query.CountAsync();

            var entityList = await query
                    .OrderBy(input.Sorting).AsNoTracking()
                    .PageBy(input)
                    .ToListAsync();

            // var entityListDtos = ObjectMapper.Map<List<ContactListDto>>(entityList);
            var entityListDtos = entityList.MapTo<List<ContactListDto>>();

            return new PagedResultDto<ContactListDto>(count, entityListDtos);
        }


        /// <summary>
        /// 通过指定id获取ContactListDto信息
        /// </summary>

        public async Task<ContactListDto> GetById(EntityDto<int> input)
        {
            var entity = await _entityRepository.GetAsync(input.Id);

            return entity.MapTo<ContactListDto>();
        }

        /// <summary>
        /// 获取编辑 Contact
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task<GetContactForEditOutput> GetForEdit(NullableIdDto<int> input)
        {
            var output = new GetContactForEditOutput();
            ContactEditDto editDto;

            if (input.Id.HasValue)
            {
                var entity = await _entityRepository.GetAsync(input.Id.Value);

                editDto = entity.MapTo<ContactEditDto>();

                //contactEditDto = ObjectMapper.Map<List<contactEditDto>>(entity);
            }
            else
            {
                editDto = new ContactEditDto();
            }

            output.Contact = editDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改Contact的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task CreateOrUpdate(CreateOrUpdateContactInput input)
        {

            if (input.Contact.Id.HasValue)
            {
                await Update(input.Contact);
            }
            else
            {
                await Create(input.Contact);
            }
        }


        /// <summary>
        /// 新增Contact
        /// </summary>

        protected virtual async Task<ContactEditDto> Create(ContactEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            // var entity = ObjectMapper.Map <Contact>(input);
            var entity = input.MapTo<Contact>();


            entity = await _entityRepository.InsertAsync(entity);
            return entity.MapTo<ContactEditDto>();
        }

        /// <summary>
        /// 编辑Contact
        /// </summary>

        protected virtual async Task Update(ContactEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _entityRepository.GetAsync(input.Id.Value);
            input.MapTo(entity);

            // ObjectMapper.Map(input, entity);
            await _entityRepository.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除Contact信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public async Task Delete(EntityDto<int> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _entityRepository.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除Contact的方法
        /// </summary>

        public async Task BatchDelete(List<int> input)
        {
            // TODO:批量删除前的逻辑判断，是否允许删除
            await _entityRepository.DeleteAsync(s => input.Contains(s.Id));
        }

        [AbpAllowAnonymous]
        public async Task<APIResultDto> SaveContactMsg(CreateOrUpdateContactInput input)
        {
            //检查提交请求是否大于20
            var count = await _entityRepository.GetAll().Where(e => e.CreationTime > DateTime.Today).CountAsync();
            if (count >= 20)
            {
                return new APIResultDto() { Code = 99, Msg = "提交数据已超过限制" };
            }

            input.Contact.CreationTime = DateTime.Now;
            var entity = input.Contact.MapTo<Contact>();

            await _entityRepository.InsertAsync(entity);
            return new APIResultDto() { Code = 0, Msg = "提交成功" };
        }

        /// <summary>
        /// 导出Contact为excel表,等待开发。
        /// </summary>
        /// <returns></returns>
        //public async Task<FileDto> GetToExcel()
        //{
        //	var users = await UserManager.Users.ToListAsync();
        //	var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
        //	await FillRoleNames(userListDtos);
        //	return _userListExcelExporter.ExportToFile(userListDtos);
        //}

    }
}


