using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using HC.WeChat.OrderListEnclosures;


namespace HC.WeChat.OrderListEnclosures.DomainServices
{
    public interface IOrderListEnclosureManager : IDomainService
    {
        
        /// <summary>
        /// 初始化方法
        /// </summary>
        void InitOrderListEnclosure();


		
		//// custom codes 
		
        //// custom codes end

    }
}
