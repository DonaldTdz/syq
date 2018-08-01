using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using HC.WeChat.UserInfos;

namespace HC.WeChat.UserInfos.DomainServices
{
    /// <summary>
    /// UserInfo领域层的业务管理
    /// </summary>
    public class UserInfoManager :WeChatDomainServiceBase, IUserInfoManager
    {
        private readonly IRepository<UserInfo, Guid> _userinfoRepository;

        /// <summary>
        /// UserInfo的构造方法
        /// </summary>
        public UserInfoManager(IRepository<UserInfo, Guid> userinfoRepository)
        {
            _userinfoRepository = userinfoRepository;
        }
		
		
		/// <summary>
		///     初始化
		/// </summary>
		public void InitUserInfo()
		{
			throw new NotImplementedException();
		}

		//TODO:编写领域业务代码


		
		//// custom codes 
		
        //// custom codes end

    }
}
