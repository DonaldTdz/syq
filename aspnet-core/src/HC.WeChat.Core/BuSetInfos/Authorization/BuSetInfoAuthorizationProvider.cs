using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using HC.WeChat.Authorization;

namespace HC.WeChat.BuSetInfos.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="BuSetInfoAppPermissions"/> for all permission names.
    /// </summary>
    public class BuSetInfoAppAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
			//在这里配置了BuSetInfo 的权限。
            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));
 
            var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

			var busetinfo = administration.CreateChildPermission(BuSetInfoAppPermissions.BuSetInfo , L("BuSetInfo"));
            busetinfo.CreateChildPermission(BuSetInfoAppPermissions.BuSetInfo_CreateBuSetInfo, L("CreateBuSetInfo"));
            busetinfo.CreateChildPermission(BuSetInfoAppPermissions.BuSetInfo_EditBuSetInfo, L("EditBuSetInfo"));           
            busetinfo.CreateChildPermission(BuSetInfoAppPermissions.BuSetInfo_DeleteBuSetInfo, L("DeleteBuSetInfo"));
			busetinfo.CreateChildPermission(BuSetInfoAppPermissions.BuSetInfo_BatchDeleteBuSetInfos , L("BatchDeleteBuSetInfos"));


			
			//// custom codes 
			
			//// custom codes end
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, WeChatConsts.LocalizationSourceName);
        }
    }
}