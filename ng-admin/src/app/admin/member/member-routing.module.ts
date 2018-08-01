import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { MemberManagementComponent } from "./member-management/member-management.component";
import { AppRouteGuard } from "@shared/auth/auth-route-guard";
import { MemberDetailComponent } from "./member-management/member-detail/member-detail.component";

const routes: Routes = [
  { path: '', redirectTo: 'index', pathMatch: 'full' },
  { path: 'member-management', component: MemberManagementComponent, data: { translate: 'member-management', permission: 'Pages' }, canActivate: [AppRouteGuard] },
  // { path: 'member-detail', component: MemberDetailComponent, data: { translate: 'member-management', permission: 'Pages' }, canActivate: [AppRouteGuard] },
  // { path: 'member-detail/:id', component: MemberDetailComponent, data: { translate: 'member-management', permission: 'Pages' }, canActivate: [AppRouteGuard] },
];
@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MemberRoutingModule { }