namespace HC.WeChat.Orders.Authorization
{
	 /// <summary>
	 /// 定义系统的权限名称的字符串常量。
	 /// <see cref="OrderAppAuthorizationProvider"/>中对权限的定义.
	 /// </summary>
	public static  class OrderAppPermissions
	{
		/// <summary>
		/// Order管理权限_自带查询授权
		/// </summary>
		public const string Order = "Pages.Order";

		/// <summary>
		/// Order创建权限
		/// </summary>
		public const string Order_CreateOrder = "Pages.Order.CreateOrder";

		/// <summary>
		/// Order修改权限
		/// </summary>
		public const string Order_EditOrder = "Pages.Order.EditOrder";

		/// <summary>
		/// Order删除权限
		/// </summary>
		public const string Order_DeleteOrder = "Pages.Order.DeleteOrder";

        /// <summary>
        /// Order批量删除权限
        /// </summary>
		public const string Order_BatchDeleteOrders = "Pages.Order.BatchDeleteOrders";


		
		//// custom codes 
		
        //// custom codes end
    }
	
}

