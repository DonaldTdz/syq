using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using HC.WeChat.UserInfos;


namespace HC.WeChat.UserInfos.DomainServices
{
    public interface IUserInfoManager : IDomainService
    {
        
        /// <summary>
        /// 初始化方法
        /// </summary>
        void InitUserInfo();


		
		//// custom codes 
		
        //// custom codes end

    }
}
