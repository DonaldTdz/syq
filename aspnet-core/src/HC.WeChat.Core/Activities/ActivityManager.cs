using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using HC.WeChat.Activities;

namespace HC.WeChat.Activities.DomainServices
{
    /// <summary>
    /// Activity领域层的业务管理
    /// </summary>
    public class ActivityManager :WeChatDomainServiceBase, IActivityManager
    {
        private readonly IRepository<Activity, Guid> _activityRepository;

        /// <summary>
        /// Activity的构造方法
        /// </summary>
        public ActivityManager(IRepository<Activity, Guid> activityRepository)
        {
            _activityRepository = activityRepository;
        }
		
		
		/// <summary>
		///     初始化
		/// </summary>
		public void InitActivity()
		{
			throw new NotImplementedException();
		}

		//TODO:编写领域业务代码


		
		//// custom codes 
		
        //// custom codes end

    }
}
