using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HC.WeChat.OrderListEnclosures.Dtos;
using System;

namespace HC.WeChat.OrderListEnclosures
{
    /// <summary>
    /// OrderListEnclosure应用层服务的接口方法
    /// </summary>
    public interface IOrderListEnclosureAppService : IApplicationService
    {
        /// <summary>
        /// 获取OrderListEnclosure的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<OrderListEnclosureListDto>> GetPagedOrderListEnclosures(GetOrderListEnclosuresInput input);

		/// <summary>
		/// 通过指定id获取OrderListEnclosureListDto信息
		/// </summary>
		Task<OrderListEnclosureListDto> GetOrderListEnclosureByIdAsync(EntityDto<Guid> input);


        /// <summary>
        /// 导出OrderListEnclosure为excel表
        /// </summary>
        /// <returns></returns>
		//Task<FileDto> GetOrderListEnclosuresToExcel();

        /// <summary>
        /// MPA版本才会用到的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetOrderListEnclosureForEditOutput> GetOrderListEnclosureForEdit(NullableIdDto<Guid> input);

        //todo:缺少Dto的生成GetOrderListEnclosureForEditOutput


        /// <summary>
        /// 添加或者修改OrderListEnclosure的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdateOrderListEnclosure(CreateOrUpdateOrderListEnclosureInput input);


        /// <summary>
        /// 删除OrderListEnclosure信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteOrderListEnclosure(EntityDto<Guid> input);


        /// <summary>
        /// 批量删除OrderListEnclosure
        /// </summary>
        Task BatchDeleteOrderListEnclosuresAsync(List<Guid> input);


		//// custom codes 
		
        //// custom codes end
    }
}
