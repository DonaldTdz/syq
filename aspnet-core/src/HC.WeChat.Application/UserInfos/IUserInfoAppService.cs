using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HC.WeChat.UserInfos.Dtos;
using System;

namespace HC.WeChat.UserInfos
{
    /// <summary>
    /// UserInfo应用层服务的接口方法
    /// </summary>
    public interface IUserInfoAppService : IApplicationService
    {
        /// <summary>
        /// 获取UserInfo的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<UserInfoListDto>> GetPagedUserInfos(GetUserInfosInput input);

		/// <summary>
		/// 通过指定id获取UserInfoListDto信息
		/// </summary>
		Task<UserInfoListDto> GetUserInfoByIdAsync(EntityDto<Guid> input);


        /// <summary>
        /// 导出UserInfo为excel表
        /// </summary>
        /// <returns></returns>
		//Task<FileDto> GetUserInfosToExcel();

        /// <summary>
        /// MPA版本才会用到的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetUserInfoForEditOutput> GetUserInfoForEdit(NullableIdDto<Guid> input);

        //todo:缺少Dto的生成GetUserInfoForEditOutput


        /// <summary>
        /// 添加或者修改UserInfo的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdateUserInfo(CreateOrUpdateUserInfoInput input);


        /// <summary>
        /// 删除UserInfo信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteUserInfo(EntityDto<Guid> input);


        /// <summary>
        /// 批量删除UserInfo
        /// </summary>
        Task BatchDeleteUserInfosAsync(List<Guid> input);

    }
}
