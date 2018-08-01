namespace HC.WeChat.UserInfos.Authorization
{
	 /// <summary>
	 /// 定义系统的权限名称的字符串常量。
	 /// <see cref="UserInfoAppAuthorizationProvider"/>中对权限的定义.
	 /// </summary>
	public static  class UserInfoAppPermissions
	{
		/// <summary>
		/// UserInfo管理权限_自带查询授权
		/// </summary>
		public const string UserInfo = "Pages.UserInfo";

		/// <summary>
		/// UserInfo创建权限
		/// </summary>
		public const string UserInfo_CreateUserInfo = "Pages.UserInfo.CreateUserInfo";

		/// <summary>
		/// UserInfo修改权限
		/// </summary>
		public const string UserInfo_EditUserInfo = "Pages.UserInfo.EditUserInfo";

		/// <summary>
		/// UserInfo删除权限
		/// </summary>
		public const string UserInfo_DeleteUserInfo = "Pages.UserInfo.DeleteUserInfo";

        /// <summary>
        /// UserInfo批量删除权限
        /// </summary>
		public const string UserInfo_BatchDeleteUserInfos = "Pages.UserInfo.BatchDeleteUserInfos";


		
		//// custom codes 
		
        //// custom codes end
    }
	
}

