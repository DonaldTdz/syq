import { Component, OnInit, Injector } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { ActivatedRoute, Router } from '@angular/router';
import { NzModalService } from 'ng-zorro-antd';
import { UserInfoServiceProxy } from '@shared/service-proxies/wechat-service';
import { UserInfo } from '@shared/entity/wechat';

@Component({
    moduleId: module.id,
    selector: 'member-detail',
    templateUrl: 'member-detail.component.html',
})
export class MemberDetailComponent extends AppComponentBase implements OnInit {
    loading = false;
    recordLoading = false;
    openId: string;
    userInfo: UserInfo = new UserInfo();
    queryRecord: any = {
        pageIndex: 1,
        pageSize: 10,
        skipCount: function () { return (this.pageIndex - 1) * this.pageSize; },
        total: 0,
        sorter: '',
        status: -1,
        statusList: []
    };
    constructor(injector: Injector,
        private Acroute: ActivatedRoute, private modal: NzModalService,
        private userInfoListService: UserInfoServiceProxy,
        private router: Router) {
        super(injector);
        this.openId = this.Acroute.snapshot.params['openId'];
    }
    ngOnInit(): void {
        this.getUserInfo();
    }

    getUserInfo() {
        this.userInfoListService.getUserInfoDetailById(this.openId).subscribe((result: UserInfo) => {
            this.userInfo = result;
        });
    }

    return() {
        this.router.navigate(['admin/member/memeber-management']);
    }
}
