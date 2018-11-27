
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
using Abp.Authorization;
using Abp.Linq.Extensions;
using Abp.Domain.Repositories;
using Abp.Application.Services;
using Abp.Application.Services.Dto;


using HC.WeChat.Contacts.Dtos;
using HC.WeChat.Contacts;
using HC.WeChat.Dto;

namespace HC.WeChat.Contacts
{
    /// <summary>
    /// Contact应用层服务的接口方法
    ///</summary>
    public interface IContactAppService : IApplicationService
    {
        /// <summary>
		/// 获取Contact的分页列表信息
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<ContactListDto>> GetPaged(GetContactsInput input);


		/// <summary>
		/// 通过指定id获取ContactListDto信息
		/// </summary>
		Task<ContactListDto> GetById(EntityDto<int> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetContactForEditOutput> GetForEdit(NullableIdDto<int> input);


        /// <summary>
        /// 添加或者修改Contact的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateContactInput input);


        /// <summary>
        /// 删除Contact信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<int> input);


        /// <summary>
        /// 批量删除Contact
        /// </summary>
        Task BatchDelete(List<int> input);


        /// <summary>
        /// 导出Contact为excel表
        /// </summary>
        /// <returns></returns>
        //Task<FileDto> GetToExcel();

        Task<APIResultDto> SaveContactMsg(CreateOrUpdateContactInput input);

    }
}
