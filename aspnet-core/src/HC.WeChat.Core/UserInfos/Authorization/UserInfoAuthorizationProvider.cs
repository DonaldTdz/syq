using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using HC.WeChat.Authorization;

namespace HC.WeChat.UserInfos.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="UserInfoAppPermissions"/> for all permission names.
    /// </summary>
    public class UserInfoAppAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
			//在这里配置了UserInfo 的权限。
            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));
 
            var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

			var userinfo = administration.CreateChildPermission(UserInfoAppPermissions.UserInfo , L("UserInfo"));
            userinfo.CreateChildPermission(UserInfoAppPermissions.UserInfo_CreateUserInfo, L("CreateUserInfo"));
            userinfo.CreateChildPermission(UserInfoAppPermissions.UserInfo_EditUserInfo, L("EditUserInfo"));           
            userinfo.CreateChildPermission(UserInfoAppPermissions.UserInfo_DeleteUserInfo, L("DeleteUserInfo"));
			userinfo.CreateChildPermission(UserInfoAppPermissions.UserInfo_BatchDeleteUserInfos , L("BatchDeleteUserInfos"));


			
			//// custom codes 
			
			//// custom codes end
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, WeChatConsts.LocalizationSourceName);
        }
    }
}