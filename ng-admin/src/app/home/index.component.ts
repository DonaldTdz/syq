import { NzMessageService } from 'ng-zorro-antd';
import { Component, OnInit } from '@angular/core';
import { _HttpClient } from '@delon/theme';
import { AppSessionService } from '@shared/session/app-session.service';
import { HomeInfo, Parameter, ShopStatistic, WeChatUserStatistic } from '@shared/service-proxies/entity';
import { SettingsService } from '@delon/theme';

import { UploadFile } from 'ng-zorro-antd';
import { Router } from '@angular/router';
import { WechatUserServiceProxy } from '@shared/service-proxies/wechat-service';

@Component({
    selector: 'app-home-index',
    templateUrl: './index.component.html',
    styleUrls: ['index.component.scss']
})
export class IndexComponent implements OnInit {
    homeInfo: HomeInfo = new HomeInfo();
    shopStatistics: ShopStatistic[] = [];
    wechatUserStatistic: WeChatUserStatistic[] = [];
    constructor(private http: _HttpClient, public msg: NzMessageService, private _appSessionService: AppSessionService,
        private settings: SettingsService, private _router: Router,
        private wechatUserService: WechatUserServiceProxy) { }

    quickMenu = false;

    webSite: any[] = [];
    salesData: any[] = [];
    offlineChartData: any[] = [];
    roleName: string = '';

    previewImage = '';
    previewVisible = false;

    fileList = [];
    shopData: any[] = [];
    wechatData: any[] = [];
    stotal: number;
    wtotal: number;
    ngOnInit() {
    }


    handlePreview = (file: UploadFile) => {
        this.previewImage = file.url || file.thumbUrl;
        this.previewVisible = true;
    }

    getParameter(): Parameter[] {
        let parray = [];
        parray.push(Parameter.fromJS({}));
        return parray;
    }

}
