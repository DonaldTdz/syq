import { NgModule } from "@angular/core";
import { AppRouteGuard } from "@shared/auth/auth-route-guard";

import { SharedModule } from "@shared/shared.module";
import { MemberManagementComponent } from "./member-management/member-management.component";
import { MemberRoutingModule } from "./member-routing.module";
import { LayoutModule } from "../../layout/layout.module";
import { MemberDetailComponent } from "./member-management/member-detail/member-detail.component";

@NgModule({
    imports: [
        SharedModule,
        LayoutModule,
        MemberRoutingModule,
    ],
    declarations: [
        MemberManagementComponent,
        MemberDetailComponent
    ],
    providers: [
        AppRouteGuard
    ]

})
export class MemberModule { }