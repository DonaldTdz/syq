using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using HC.WeChat.Authorization;

namespace HC.WeChat.OrderListEnclosures.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="OrderListEnclosureAppPermissions"/> for all permission names.
    /// </summary>
    public class OrderListEnclosureAppAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
			//在这里配置了OrderListEnclosure 的权限。
            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));
 
            var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

			var orderlistenclosure = administration.CreateChildPermission(OrderListEnclosureAppPermissions.OrderListEnclosure , L("OrderListEnclosure"));
            orderlistenclosure.CreateChildPermission(OrderListEnclosureAppPermissions.OrderListEnclosure_CreateOrderListEnclosure, L("CreateOrderListEnclosure"));
            orderlistenclosure.CreateChildPermission(OrderListEnclosureAppPermissions.OrderListEnclosure_EditOrderListEnclosure, L("EditOrderListEnclosure"));           
            orderlistenclosure.CreateChildPermission(OrderListEnclosureAppPermissions.OrderListEnclosure_DeleteOrderListEnclosure, L("DeleteOrderListEnclosure"));
			orderlistenclosure.CreateChildPermission(OrderListEnclosureAppPermissions.OrderListEnclosure_BatchDeleteOrderListEnclosures , L("BatchDeleteOrderListEnclosures"));


			
			//// custom codes 
			
			//// custom codes end
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, WeChatConsts.LocalizationSourceName);
        }
    }
}