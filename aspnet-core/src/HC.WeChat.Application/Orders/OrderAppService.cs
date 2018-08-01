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
using HC.WeChat.Orders.Authorization;
using HC.WeChat.Orders.DomainServices;
using HC.WeChat.Orders.Dtos;
using System;
using HC.WeChat.Authorization;
using HC.WeChat.Activities;
using HC.WeChat.UserInfos;
using HC.WeChat.WechatEnums;

namespace HC.WeChat.Orders
{
    /// <summary>
    /// Order应用层服务的接口实现方法
    /// </summary>
    //[AbpAuthorize(OrderAppPermissions.Order)]
    [AbpAuthorize(AppPermissions.Pages)]
    public class OrderAppService : WeChatAppServiceBase, IOrderAppService
    {
        private readonly IRepository<Order, Guid> _orderRepository;

        private readonly IOrderManager _orderManager;
        private readonly IRepository<Activity, Guid> _activityRepository;
        private readonly IRepository<UserInfo, Guid> _userinfoRepository;

        /// <summary>
        /// 构造函数
        /// </summary>
        public OrderAppService(
            IRepository<Order, Guid> orderRepository
            , IOrderManager orderManager
            , IRepository<Activity, Guid> activityRepository
            , IRepository<UserInfo, Guid> userinfoRepository

        )
        {
            _orderRepository = orderRepository;
            _orderManager = orderManager;
            _activityRepository = activityRepository;
            _userinfoRepository = userinfoRepository;
        }


        /// <summary>
        /// 获取Order的分页列表信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<OrderListDto>> GetPagedOrders(GetOrdersInput input)
        {

            var query = _orderRepository.GetAll();
            // TODO:根据传入的参数添加过滤条件

            var orderCount = await query.CountAsync();

            var orders = await query
                    .OrderBy(input.Sorting)
                    .PageBy(input)
                    .ToListAsync();

            var orderListDtos = orders.MapTo<List<OrderListDto>>();

            return new PagedResultDto<OrderListDto>(
                        orderCount,
                        orderListDtos
                );
        }


        /// <summary>
        /// 通过指定id获取OrderListDto信息
        /// </summary>
        public async Task<OrderListDto> GetOrderByIdAsync(EntityDto<Guid> input)
        {
            var entity = await _orderRepository.GetAsync(input.Id);

            return entity.MapTo<OrderListDto>();
        }

        /// <summary>
        /// MPA版本才会用到的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<GetOrderForEditOutput> GetOrderForEdit(NullableIdDto<Guid> input)
        {
            var output = new GetOrderForEditOutput();
            OrderEditDto orderEditDto;

            if (input.Id.HasValue)
            {
                var entity = await _orderRepository.GetAsync(input.Id.Value);

                orderEditDto = entity.MapTo<OrderEditDto>();

                //orderEditDto = ObjectMapper.Map<List <orderEditDto>>(entity);
            }
            else
            {
                orderEditDto = new OrderEditDto();
            }

            output.Order = orderEditDto;
            return output;
        }


        /// <summary>
        /// 添加或者修改Order的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task CreateOrUpdateOrder(CreateOrUpdateOrderInput input)
        {

            if (input.Order.Id.HasValue)
            {
                await UpdateOrderAsync(input.Order);
            }
            else
            {
                await CreateOrderAsync(input.Order);
            }
        }


        /// <summary>
        /// 新增Order
        /// </summary>
        [AbpAuthorize(OrderAppPermissions.Order_CreateOrder)]
        protected virtual async Task<OrderEditDto> CreateOrderAsync(OrderEditDto input)
        {
            //TODO:新增前的逻辑判断，是否允许新增

            var entity = ObjectMapper.Map<Order>(input);

            entity = await _orderRepository.InsertAsync(entity);
            return entity.MapTo<OrderEditDto>();
        }

        /// <summary>
        /// 编辑Order
        /// </summary>
        [AbpAuthorize(OrderAppPermissions.Order_EditOrder)]
        protected virtual async Task UpdateOrderAsync(OrderEditDto input)
        {
            //TODO:更新前的逻辑判断，是否允许更新

            var entity = await _orderRepository.GetAsync(input.Id.Value);
            input.MapTo(entity);

            // ObjectMapper.Map(input, entity);
            await _orderRepository.UpdateAsync(entity);
        }



        /// <summary>
        /// 删除Order信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [AbpAuthorize(OrderAppPermissions.Order_DeleteOrder)]
        public async Task DeleteOrder(EntityDto<Guid> input)
        {
            //TODO:删除前的逻辑判断，是否允许删除
            await _orderRepository.DeleteAsync(input.Id);
        }



        /// <summary>
        /// 批量删除Order的方法
        /// </summary>
        [AbpAuthorize(OrderAppPermissions.Order_BatchDeleteOrders)]
        public async Task BatchDeleteOrdersAsync(List<Guid> input)
        {
            //TODO:批量删除前的逻辑判断，是否允许删除
            await _orderRepository.DeleteAsync(s => input.Contains(s.Id));
        }

        /// <summary>
        /// 分页获取订单列表
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<OrderListDto>> GetPagedOrderListsAsync(GetOrdersInput input)
        {
            var orderList = _orderRepository.GetAll();
            var activity = _activityRepository.GetAll();
            var user = _userinfoRepository.GetAll();
            var result = (from o in orderList
                          join a in activity on o.ActivityId equals a.ActivityId
                          join u in user on o.UserId equals u.OpenId
                          select new OrderListDto()
                          {
                              Id = o.Id,
                              OrderId = o.OrderId,
                              Title = a.Title,
                              AllManSum = o.AllManSum,
                              Money = o.Money,
                              Price = o.Price,
                              WXPriceArray = a.WXPriceArray,
                              PriceIndex = o.PriceIndex,
                              PpriceTitle = o.PpriceTitle,
                              State = o.State,
                              OpenId = u.OpenId
                          });
            var orderListCount = await result.CountAsync();
            var orderLists = await result
                .OrderBy(v => v.Id).AsNoTracking()
                .PageBy(input)
                .ToListAsync();
            var orderListDtos = orderLists.MapTo<List<OrderListDto>>();
            return new PagedResultDto<OrderListDto>(
                orderListCount,
                orderListDtos
                );
        }


        /// <summary>
        /// 微信根据openId获取订单列表
        /// </summary>
        /// <param name="openId"></param>
        /// <param name="host"></param>
        /// <returns></returns>
        [AbpAllowAnonymous]
        public async Task<List<OrderListDto>> GetWXOrderListByOpenIdAsync(string openId,string host)
        {
            List<OrderListDto> result = await (from o in _orderRepository.GetAll().Where(v => v.UserId == openId && v.State!= OrderStatus.未支付)
                                               join a in _activityRepository.GetAll()
                                               on o.ActivityId equals a.ActivityId
                                               select new OrderListDto()
                                               {
                                                   Id = o.Id,
                                                   OrderId = o.OrderId,
                                                   Title = a.Title,
                                                   AllManSum = o.AllManSum,
                                                   Money = o.Money,
                                                   Price = o.Price,
                                                   IconImg = host + a.IconImg,
                                                   WXPriceArray = a.WXPriceArray,
                                                   PriceIndex = o.PriceIndex,
                                                   PpriceTitle = o.PpriceTitle,
                                                   State = o.State
                                               }).OrderByDescending(V => V.CreationTime).ToListAsync();
            return result;
        }
    }
}


