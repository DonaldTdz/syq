using System.Linq;
using Abp.Authorization;
using Abp.Localization;
using HC.WeChat.Authorization;

namespace HC.WeChat.Orders.Authorization
{
    /// <summary>
    /// 权限配置都在这里。
    /// 给权限默认设置服务
    /// See <see cref="OrderAppPermissions"/> for all permission names.
    /// </summary>
    public class OrderAppAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
			//在这里配置了Order 的权限。
            var pages = context.GetPermissionOrNull(AppPermissions.Pages) ?? context.CreatePermission(AppPermissions.Pages, L("Pages"));
 
            var administration = pages.Children.FirstOrDefault(p => p.Name == AppPermissions.Pages_Administration) ?? pages.CreateChildPermission(AppPermissions.Pages_Administration, L("Administration"));

			var order = administration.CreateChildPermission(OrderAppPermissions.Order , L("Order"));
            order.CreateChildPermission(OrderAppPermissions.Order_CreateOrder, L("CreateOrder"));
            order.CreateChildPermission(OrderAppPermissions.Order_EditOrder, L("EditOrder"));           
            order.CreateChildPermission(OrderAppPermissions.Order_DeleteOrder, L("DeleteOrder"));
			order.CreateChildPermission(OrderAppPermissions.Order_BatchDeleteOrders , L("BatchDeleteOrders"));


			
			//// custom codes 
			
			//// custom codes end
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, WeChatConsts.LocalizationSourceName);
        }
    }
}