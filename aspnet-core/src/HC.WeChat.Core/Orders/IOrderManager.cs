using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;


namespace HC.WeChat.Orders.DomainServices
{
    public interface IOrderManager : IDomainService
    {
        
        /// <summary>
        /// 初始化方法
        /// </summary>
        void InitOrder();


		
		//// custom codes 
		
        //// custom codes end

    }
}
