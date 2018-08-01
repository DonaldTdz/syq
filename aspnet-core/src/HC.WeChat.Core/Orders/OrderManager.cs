using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace HC.WeChat.Orders.DomainServices
{
    /// <summary>
    /// Order领域层的业务管理
    /// </summary>
    public class OrderManager :WeChatDomainServiceBase, IOrderManager
    {
        private readonly IRepository<Order, Guid> _orderRepository;

        /// <summary>
        /// Order的构造方法
        /// </summary>
        public OrderManager(IRepository<Order, Guid> orderRepository)
        {
            _orderRepository = orderRepository;
        }
		
		
		/// <summary>
		///     初始化
		/// </summary>
		public void InitOrder()
		{
			throw new NotImplementedException();
		}

		//TODO:编写领域业务代码


		
		//// custom codes 
		
        //// custom codes end

    }
}
