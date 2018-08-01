using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using HC.WeChat.BuSetInfos;


namespace HC.WeChat.BuSetInfos.DomainServices
{
    public interface IBuSetInfoManager : IDomainService
    {
        
        /// <summary>
        /// 初始化方法
        /// </summary>
        void InitBuSetInfo();


		
		//// custom codes 
		
        //// custom codes end

    }
}
