import { Component, OnInit, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { UserInfo } from '@shared/entity/wechat';
import { UserInfoServiceProxy, PagedResultDtoOfUserInfo } from '@shared/service-proxies/wechat-service';
import { NzModalService } from 'ng-zorro-antd';
import { Parameter } from '@shared/service-proxies/entity';
import { Router } from '@angular/router';

@Component({
    moduleId: module.id,
    selector: 'member-management',
    templateUrl: 'member-management.component.html',
})
export class MemberManagementComponent extends AppComponentBase implements OnInit {
    search: any = { name: '', UserType: 6 };
    loading = false;
    exportLoading = false;
    userInfoList: UserInfo[] = [];
    userInfoListName = '';
    constructor(injector: Injector, private userInfoListService: UserInfoServiceProxy, private modal: NzModalService, private router: Router) {
        super(injector);
    }
    ngOnInit(): void {
        // this.refreshData();
    }
    refreshData(reset = false, search?: boolean) {
        if (reset) {
            this.query.pageIndex = 1;
            this.search = { name: '', UserType: 6 };
        }
        if (search) {
            this.query.pageIndex = 1;
        }
        this.loading = true;
        this.userInfoListService.getAll(this.query.skipCount(), this.query.pageSize, this.getParameter()).subscribe((result: PagedResultDtoOfUserInfo) => {
            this.userInfoList = result.items;
            this.loading = false;
            this.query.total = result.totalCount;
        });
    }
    getParameter(): Parameter[] {
        var arry = [];
        arry.push(Parameter.fromJS({ key: 'Name', value: this.search.name }));
        arry.push(Parameter.fromJS({ key: 'UserType', value: this.search.UserType === 6 ? null : this.search.UserType }));
        arry.push(Parameter.fromJS({ key: 'Code', value: this.search.code }));
        return arry;

    }

    exportExcelAll() {
        // this.exportLoading = true;
        // this.userInfoListService.exportExcel({ name: this.search.name, userType: this.search.UserType === 6 ? null : this.search.UserType, code: this.search.code }).subscribe(result => {
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
        this.router.navigate(['admin/UserInfo/UserInfo-search-detail', openId])
    }
}
