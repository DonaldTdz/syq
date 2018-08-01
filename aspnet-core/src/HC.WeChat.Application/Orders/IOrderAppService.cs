using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HC.WeChat.Orders.Dtos;
using HC.WeChat.Orders;
using System;

namespace HC.WeChat.Orders
{
    /// <summary>
    /// Order应用层服务的接口方法
    /// </summary>
    public interface IOrderAppService : IApplicationService
    {
        /// <summary>
        /// 获取Order的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<OrderListDto>> GetPagedOrders(GetOrdersInput input);

		/// <summary>
		/// 通过指定id获取OrderListDto信息
		/// </summary>
		Task<OrderListDto> GetOrderByIdAsync(EntityDto<Guid> input);


        /// <summary>
        /// 导出Order为excel表
        /// </summary>
        /// <returns></returns>
		//Task<FileDto> GetOrdersToExcel();

        /// <summary>
        /// MPA版本才会用到的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetOrderForEditOutput> GetOrderForEdit(NullableIdDto<Guid> input);

        //todo:缺少Dto的生成GetOrderForEditOutput


        /// <summary>
        /// 添加或者修改Order的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdateOrder(CreateOrUpdateOrderInput input);


        /// <summary>
        /// 删除Order信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeleteOrder(EntityDto<Guid> input);


        /// <summary>
        /// 批量删除Order
        /// </summary>
        Task BatchDeleteOrdersAsync(List<Guid> input);

        Task<List<OrderListDto>> GetWXOrderListByOpenIdAsync(string openId,string host);
        Task<PagedResultDto<OrderListDto>> GetPagedOrderListsAsync(GetOrdersInput input);
    }
}
