import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { AppRouteGuard } from "@shared/auth/auth-route-guard";
import { OrderListComponent } from "./order-list/order-list.component";

const routes: Routes = [
    { path: '', redirectTo: 'index', pathMatch: 'full' },
    { path: 'order-list', component: OrderListComponent, data: { translate: 'order-list', permission: 'Pages' }, canActivate: [AppRouteGuard] },
];
@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class OrderRoutingModule { }