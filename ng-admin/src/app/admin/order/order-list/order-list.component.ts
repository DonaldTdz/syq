import { Component, OnInit, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { NzModalService } from 'ng-zorro-antd';
import { Parameter } from '@shared/service-proxies/entity';
import { AppConsts } from '@shared/AppConsts';
import { Router } from '@angular/router';
import { Order } from '@shared/entity/order';
import { OrderServiceProxy, PagedResultDtoOfOrder } from '@shared/service-proxies/order';

@Component({
    moduleId: module.id,
    selector: 'order-List',
    templateUrl: 'order-List.component.html',
})
export class OrderListComponent extends AppComponentBase implements OnInit {
    search: any = { name: '', UserType: 6 };
    loading = false;
    exportLoading = false;
    orderList: Order[] = [];
    userInfoListName = '';
    constructor(injector: Injector, private orderListService: OrderServiceProxy, private modal: NzModalService, private router: Router) {
        super(injector);
    }
    ngOnInit(): void {
        this.refreshData();
    }
    refreshData(reset = false, search?: boolean) {
        if (reset) {
            this.query.pageIndex = 1;
            // this.search = { name: '', UserType: 6 };
        }
        if (search) {
            this.query.pageIndex = 1;
        }
        this.loading = true;
        this.orderListService.getAll(this.query.skipCount(), this.query.pageSize, this.getParameter()).subscribe((result: PagedResultDtoOfOrder) => {
            this.orderList = result.items;
            this.loading = false;
            this.query.total = result.totalCount;
        });
    }
    getParameter(): Parameter[] {
        var arry = [];
        // arry.push(Parameter.fromJS({ key: 'Name', value: this.search.name }));
        // arry.push(Parameter.fromJS({ key: 'UserType', value: this.search.UserType === 6 ? null : this.search.UserType }));
        // arry.push(Parameter.fromJS({ key: 'Code', value: this.search.code }));
        return arry;

    }

    exportExcelAll() {
        // this.exportLoading = true;
        // this.orderListService.exportExcel({ name: this.search.name, userType: this.search.UserType === 6 ? null : this.search.UserType, code: this.search.code }).subscribe(result => {
        //     if (result.code == 0) {
        //         var url = AppConsts.remoteServiceBaseUrl + result.data;
        //         document.getElementById('aUserInfoExcelUrl').setAttribute('href', url);
        //         document.getElementById('btnUserInfoHref').click();
        //     } else {
        //         this.notify.error(result.msg);
        //     }
        //     this.exportLoading = false;
        // });
    }

    detailUserInfo(openId: string) {
        this.router.navigate(['admin/Order/Order-search-detail', openId])
    }
}
