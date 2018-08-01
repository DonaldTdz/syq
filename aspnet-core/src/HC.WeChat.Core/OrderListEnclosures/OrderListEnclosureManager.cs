using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using HC.WeChat.OrderListEnclosures;

namespace HC.WeChat.OrderListEnclosures.DomainServices
{
    /// <summary>
    /// OrderListEnclosure领域层的业务管理
    /// </summary>
    public class OrderListEnclosureManager :WeChatDomainServiceBase, IOrderListEnclosureManager
    {
        private readonly IRepository<OrderListEnclosure, Guid> _orderlistenclosureRepository;

        /// <summary>
        /// OrderListEnclosure的构造方法
        /// </summary>
        public OrderListEnclosureManager(IRepository<OrderListEnclosure, Guid> orderlistenclosureRepository)
        {
            _orderlistenclosureRepository = orderlistenclosureRepository;
        }
		
		
		/// <summary>
		///     初始化
		/// </summary>
		public void InitOrderListEnclosure()
		{
			throw new NotImplementedException();
		}

		//TODO:编写领域业务代码


		
		//// custom codes 
		
        //// custom codes end

    }
}
