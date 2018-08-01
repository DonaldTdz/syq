import { NgModule } from '@angular/core';

import * as ApiServiceProxies from './service-proxies';
import { WechatUserServiceProxy, WeChatGroupServiceProxy, UserInfoServiceProxy } from '@shared/service-proxies/wechat-service';
import { OrderServiceProxy } from '@shared/service-proxies/order';

@NgModule({
    providers: [
        ApiServiceProxies.RoleServiceProxy,
        ApiServiceProxies.SessionServiceProxy,
        ApiServiceProxies.TenantServiceProxy,
        ApiServiceProxies.UserServiceProxy,
        ApiServiceProxies.TokenAuthServiceProxy,
        ApiServiceProxies.AccountServiceProxy,
        ApiServiceProxies.ConfigurationServiceProxy,
        ApiServiceProxies.DriverServiceProxy,
        ApiServiceProxies.AuthSettingServiceProxy,
        ApiServiceProxies.MessageServiceProxy,
        ApiServiceProxies.SubscribeServiceProxy,
        ApiServiceProxies.EmployeesServiceProxy,
        ApiServiceProxies.ActivityServiceProxy,
        WechatUserServiceProxy,
        WeChatGroupServiceProxy,
        UserInfoServiceProxy,
        OrderServiceProxy
    ]
})
export class ServiceProxyModule { }