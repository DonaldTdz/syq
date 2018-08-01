using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HC.WeChat.BuSetInfos.Dtos;
using System;

namespace HC.WeChat.BuSetInfos
{
    /// <summary>
    /// BuSetInfo应用层服务的接口方法
    /// </summary>
    public interface IBuSetInfoAppService : IApplicationService
    {
        /// <summary>
        /// 获取BuSetInfo的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<BuSetInfoListDto>> GetPagedBuSetInfos(GetBuSetInfosInput input);

		/// <summary>
		/// 通过指定id获取BuSetInfoListDto信息
		/// </summary>
		Task<BuSetInfoListDto> GetBuSetInfoByIdAsync(EntityDto<Guid> input);


        /// <summary>
        /// 导出BuSetInfo为excel表
        /// </summary>
        /// <returns></returns>
		//Task<FileDto> GetBuSetInfosToExcel();

        /// <summary>
        /// MPA版本才会用到的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetBuSetInfoForEditOutput> GetBuSetInfoForEdit(NullableIdDto<Guid> input);

        //todo:缺少Dto的生成GetBuSetInfoForEditOutput


        /// <summary>
        /// 添加或者修改BuSetInfo的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdateBuSetInfo(CreateOrUpdateBuSetInfoInput input);


        /// <summary>
        /// 删除BuSetInfo信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteBuSetInfo(EntityDto<Guid> input);


        /// <summary>
        /// 批量删除BuSetInfo
        /// </summary>
        Task BatchDeleteBuSetInfosAsync(List<Guid> input);


		//// custom codes 
		
        //// custom codes end
    }
}
