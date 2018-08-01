import { NgModule } from "@angular/core";
import { AppRouteGuard } from "@shared/auth/auth-route-guard";

import { SharedModule } from "@shared/shared.module";
import { LayoutModule } from "../../layout/layout.module";
import { OrderRoutingModule } from "./order-routing.module";
import { OrderListComponent } from "./order-list/order-list.component";

@NgModule({
    imports: [
        SharedModule,
        LayoutModule,
        OrderRoutingModule,
    ],
    declarations: [
        OrderListComponent,
    ],
    providers: [
        AppRouteGuard
    ]

})
export class OrderModule { }