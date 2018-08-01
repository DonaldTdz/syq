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
using HC.WeChat.OrderListEnclosures.Authorization;
using HC.WeChat.OrderListEnclosures.DomainServices;
using HC.WeChat.OrderListEnclosures.Dtos;
using System;
using HC.WeChat.Authorization;

namespace HC.WeChat.OrderListEnclosures
{
    /// <summary>
    /// OrderListEnclosure应用层服务的接口实现方法
    /// </summary>
    //[AbpAuthorize(OrderListEnclosureAppPermissions.OrderListEnclosure)]'
    [AbpAuthorize(AppPermissions.Pages)]

    public class OrderListEnclosureAppService : WeChatAppServiceBase, IOrderListEnclosureAppService
    {
		private readonly IRepository<OrderListEnclosure, Guid> _orderlistenclosureRepository;

		private readonly IOrderListEnclosureManager _orderlistenclosureManager;
		
		/// <summary>
		/// 构造函数
		/// </summary>
		public OrderListEnclosureAppService(
			IRepository<OrderListEnclosure, Guid> orderlistenclosureRepository
			,IOrderListEnclosureManager orderlistenclosureManager
		)
		{
			_orderlistenclosureRepository = orderlistenclosureRepository;
			 _orderlistenclosureManager=orderlistenclosureManager;
		}
		
		
		/// <summary>
		/// 获取OrderListEnclosure的分页列表信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public  async  Task<PagedResultDto<OrderListEnclosureListDto>> GetPagedOrderListEnclosures(GetOrderListEnclosuresInput input)
		{
		    
		    var query = _orderlistenclosureRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
		
			var orderlistenclosureCount = await query.CountAsync();
		
			var orderlistenclosures = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();
		
				// var orderlistenclosureListDtos = ObjectMapper.Map<List <OrderListEnclosureListDto>>(orderlistenclosures);
				var orderlistenclosureListDtos =orderlistenclosures.MapTo<List<OrderListEnclosureListDto>>();
		
				return new PagedResultDto<OrderListEnclosureListDto>(
							orderlistenclosureCount,
							orderlistenclosureListDtos
					);
		}
		

		/// <summary>
		/// 通过指定id获取OrderListEnclosureListDto信息
		/// </summary>
		public async Task<OrderListEnclosureListDto> GetOrderListEnclosureByIdAsync(EntityDto<Guid> input)
		{
			var entity = await _orderlistenclosureRepository.GetAsync(input.Id);
		
		    return entity.MapTo<OrderListEnclosureListDto>();
		}
		
		/// <summary>
		/// MPA版本才会用到的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async  Task<GetOrderListEnclosureForEditOutput> GetOrderListEnclosureForEdit(NullableIdDto<Guid> input)
		{
			var output = new GetOrderListEnclosureForEditOutput();
			OrderListEnclosureEditDto orderlistenclosureEditDto;
		
			if (input.Id.HasValue)
			{
				var entity = await _orderlistenclosureRepository.GetAsync(input.Id.Value);
		
				orderlistenclosureEditDto = entity.MapTo<OrderListEnclosureEditDto>();
		
				//orderlistenclosureEditDto = ObjectMapper.Map<List <orderlistenclosureEditDto>>(entity);
			}
			else
			{
				orderlistenclosureEditDto = new OrderListEnclosureEditDto();
			}
		
			output.OrderListEnclosure = orderlistenclosureEditDto;
			return output;
		}
		
		
		/// <summary>
		/// 添加或者修改OrderListEnclosure的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task CreateOrUpdateOrderListEnclosure(CreateOrUpdateOrderListEnclosureInput input)
		{
		    
			if (input.OrderListEnclosure.Id.HasValue)
			{
				await UpdateOrderListEnclosureAsync(input.OrderListEnclosure);
			}
			else
			{
				await CreateOrderListEnclosureAsync(input.OrderListEnclosure);
			}
		}
		

		/// <summary>
		/// 新增OrderListEnclosure
		/// </summary>
		[AbpAuthorize(OrderListEnclosureAppPermissions.OrderListEnclosure_CreateOrderListEnclosure)]
		protected virtual async Task<OrderListEnclosureEditDto> CreateOrderListEnclosureAsync(OrderListEnclosureEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增
		
			var entity = ObjectMapper.Map <OrderListEnclosure>(input);
		
			entity = await _orderlistenclosureRepository.InsertAsync(entity);
			return entity.MapTo<OrderListEnclosureEditDto>();
		}
		
		/// <summary>
		/// 编辑OrderListEnclosure
		/// </summary>
		[AbpAuthorize(OrderListEnclosureAppPermissions.OrderListEnclosure_EditOrderListEnclosure)]
		protected virtual async Task UpdateOrderListEnclosureAsync(OrderListEnclosureEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新
		
			var entity = await _orderlistenclosureRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);
		
			// ObjectMapper.Map(input, entity);
		    await _orderlistenclosureRepository.UpdateAsync(entity);
		}
		

		
		/// <summary>
		/// 删除OrderListEnclosure信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(OrderListEnclosureAppPermissions.OrderListEnclosure_DeleteOrderListEnclosure)]
		public async Task DeleteOrderListEnclosure(EntityDto<Guid> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _orderlistenclosureRepository.DeleteAsync(input.Id);
		}
		
		
		
		/// <summary>
		/// 批量删除OrderListEnclosure的方法
		/// </summary>
		[AbpAuthorize(OrderListEnclosureAppPermissions.OrderListEnclosure_BatchDeleteOrderListEnclosures)]
		public async Task BatchDeleteOrderListEnclosuresAsync(List<Guid> input)
		{
			//TODO:批量删除前的逻辑判断，是否允许删除
			await _orderlistenclosureRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出OrderListEnclosure为excel表
		/// </summary>
		/// <returns></returns>
		//public async Task<FileDto> GetOrderListEnclosuresToExcel()
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


 