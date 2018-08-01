using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using Abp.Domain.Services;
using HC.WeChat.BuSetInfos;

namespace HC.WeChat.BuSetInfos.DomainServices
{
    /// <summary>
    /// BuSetInfo领域层的业务管理
    /// </summary>
    public class BuSetInfoManager :WeChatDomainServiceBase, IBuSetInfoManager
    {
        private readonly IRepository<BuSetInfo, Guid> _busetinfoRepository;

        /// <summary>
        /// BuSetInfo的构造方法
        /// </summary>
        public BuSetInfoManager(IRepository<BuSetInfo, Guid> busetinfoRepository)
        {
            _busetinfoRepository = busetinfoRepository;
        }
		
		
		/// <summary>
		///     初始化
		/// </summary>
		public void InitBuSetInfo()
		{
			throw new NotImplementedException();
		}

		//TODO:编写领域业务代码


		
		//// custom codes 
		
        //// custom codes end

    }
}
