import 'rxjs/add/observable/fromPromise';
import 'rxjs/add/observable/of';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/toPromise';
import 'rxjs/add/operator/mergeMap';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/finally';


import { Observable } from 'rxjs/Observable';
import { Injectable, Inject, Optional, InjectionToken } from '@angular/core';
import { Http, Headers, ResponseContentType, Response } from '@angular/http';
import { Activity } from '@shared/service-proxies/entity/acitivity';
import { API_BASE_URL, SwaggerException } from '@shared/service-proxies/service-proxies';
import { Parameter } from '@shared/service-proxies/entity';
import { WeChatGroup } from '@shared/entity/wechat';


function throwException(message: string, status: number, response: string, headers: { [key: string]: any; }, result?: any): Observable<any> {
    if (result !== null && result !== undefined)
        return Observable.throw(result);
    else
        return Observable.throw(new SwaggerException(message, status, response, headers, null));
}

export class WeChatGroupServiceProxy {
    private http: Http;
    private baseUrl: string;
    protected jsonParseReviver: (key: string, value: any) => any = undefined;

    constructor(@Inject(Http) http: Http, @Optional() @Inject(API_BASE_URL) baseUrl?: string) {
        this.http = http;
        this.baseUrl = baseUrl ? baseUrl : "";
    }

    /**
     * 获取所有分组信息
     */
    getAll(skipCount: number, maxResultCount: number, parameter: Parameter[]): Observable<PagedResultDtoOfWeChatGroup> {
        let url_ = this.baseUrl + "/api/services/app/WeChatGroup/GetPagedWeChatGroups?";
        if (skipCount !== undefined)
            url_ += "SkipCount=" + encodeURIComponent("" + skipCount) + "&";
        if (maxResultCount !== undefined)
            url_ += "MaxResultCount=" + encodeURIComponent("" + maxResultCount) + "&";

        if (parameter.length > 0) {
            parameter.forEach(element => {
                if (element.value !== undefined && element.value !== null) {
                    url_ += element.key + "=" + encodeURIComponent("" + element.value) + "&";
                }
            });
        }

        url_ = url_.replace(/[?&]$/, "");

        let options_ = {
            method: "get",
            headers: new Headers({
                "Content-Type": "application/json",
                "Accept": "application/json"
            })
        };

        return this.http.request(url_, options_).flatMap((response_) => {
            return this.processGetAll(response_);
        }).catch((response_: any) => {
            if (response_ instanceof Response) {
                try {
                    return this.processGetAll(response_);
                } catch (e) {
                    return <Observable<PagedResultDtoOfWeChatGroup>><any>Observable.throw(e);
                }
            } else
                return <Observable<PagedResultDtoOfWeChatGroup>><any>Observable.throw(response_);
        });
    }

    protected processGetAll(response: Response): Observable<PagedResultDtoOfWeChatGroup> {
        const status = response.status;

        let _headers: any = response.headers ? response.headers.toJSON() : {};
        if (status === 200) {
            const _responseText = response.text();
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = resultData200 ? PagedResultDtoOfWeChatGroup.fromJS(resultData200) : new PagedResultDtoOfWeChatGroup();
            return Observable.of(result200);
        } else if (status === 401) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status === 403) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.text();
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Observable.of<PagedResultDtoOfWeChatGroup>(<any>null);
    }

    /**
    * 获取所有分组信息
    */
    getAllNoPage(): Observable<WeChatGroupList> {
        let url_ = this.baseUrl + "/api/services/app/WeChatGroup/GetAllWeChatGroupAsync?";
        // if (skipCount !== undefined)
        //     url_ += "SkipCount=" + encodeURIComponent("" + skipCount) + "&";
        // if (maxResultCount !== undefined)
        //     url_ += "MaxResultCount=" + encodeURIComponent("" + maxResultCount) + "&";

        // if (parameter.length > 0) {
        //     parameter.forEach(element => {
        //         if (element.value !== undefined && element.value !== null) {
        //             url_ += element.key + "=" + encodeURIComponent("" + element.value) + "&";
        //         }
        //     });
        // }

        url_ = url_.replace(/[?&]$/, "");

        let options_ = {
            method: "get",
            headers: new Headers({
                "Content-Type": "application/json",
                "Accept": "application/json"
            })
        };

        return this.http.request(url_, options_).flatMap((response_) => {
            return this.processGetAllNoPage(response_);
        }).catch((response_: any) => {
            if (response_ instanceof Response) {
                try {
                    return this.processGetAllNoPage(response_);
                } catch (e) {
                    return <Observable<WeChatGroupList>><any>Observable.throw(e);
                }
            } else
                return <Observable<WeChatGroupList>><any>Observable.throw(response_);
        });
    }

    protected processGetAllNoPage(response: Response): Observable<WeChatGroupList> {
        const status = response.status;

        let _headers: any = response.headers ? response.headers.toJSON() : {};
        if (status === 200) {
            const _responseText = response.text();
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = resultData200 ? WeChatGroupList.fromJS(resultData200) : new WeChatGroupList();
            return Observable.of(result200);
        } else if (status === 401) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status === 403) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.text();
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Observable.of<WeChatGroupList>(<any>null);
    }

    /**
     * 获取单个分组信息
     * @param id 
     */
    get(id: number): Observable<WeChatGroup> {
        let url_ = this.baseUrl + "/api/services/app/WeChatGroup/GetWeChatGroupByIdAsync?";
        if (id !== undefined)
            url_ += "Id=" + encodeURIComponent("" + id) + "&";
        url_ = url_.replace(/[?&]$/, "");

        let options_ = {
            method: "get",
            headers: new Headers({
                "Content-Type": "application/json",
                "Accept": "application/json"
            })
        };

        return this.http.request(url_, options_).flatMap((response_) => {
            return this.processGet(response_);
        }).catch((response_: any) => {
            if (response_ instanceof Response) {
                try {
                    return this.processGet(response_);
                } catch (e) {
                    return <Observable<WeChatGroup>><any>Observable.throw(e);
                }
            } else
                return <Observable<WeChatGroup>><any>Observable.throw(response_);
        });
    }

    protected processGet(response: Response): Observable<WeChatGroup> {
        const status = response.status;

        let _headers: any = response.headers ? response.headers.toJSON() : {};
        if (status === 200) {
            const _responseText = response.text();
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = resultData200 ? WeChatGroup.fromJS(resultData200) : new WeChatGroup();
            return Observable.of(result200);
        } else if (status === 401) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status === 403) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.text();
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Observable.of<WeChatGroup>(<any>null);
    }

    /**
     * 新增分组信息
     * @param input 
     */
    Create(input: WeChatGroup): Observable<WeChatGroup> {
        let url_ = this.baseUrl + "/api/services/app/WeChatGroup/CreateWeChatGroup";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(input);

        let options_ = {
            body: content_,
            method: "post",
            headers: new Headers({
                "Content-Type": "application/json",
                "Accept": "application/json"
            })
        };

        return this.http.request(url_, options_).flatMap((response_) => {
            return this.processCreate(response_);
        }).catch((response_: any) => {
            if (response_ instanceof Response) {
                try {
                    return this.processCreate(response_);
                } catch (e) {
                    return <Observable<WeChatGroup>><any>Observable.throw(e);
                }
            } else
                return <Observable<WeChatGroup>><any>Observable.throw(response_);
        });
    }

    protected processCreate(response: Response): Observable<WeChatGroup> {
        const status = response.status;

        let _headers: any = response.headers ? response.headers.toJSON() : {};
        if (status === 200) {
            const _responseText = response.text();
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = resultData200 ? WeChatGroup.fromJS(resultData200) : new WeChatGroup();
            return Observable.of(result200);
        } else if (status === 401) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status === 403) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.text();
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Observable.of<WeChatGroup>(<any>null);
    }
    /**
     * 修改分组信息
     * @param input 
     */
    update(input: WeChatGroup): Observable<WeChatGroup> {
        let url_ = this.baseUrl + "/api/services/app/WeChatGroup/UpdateWeChatGroup";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(input);

        let options_ = {
            body: content_,
            method: "put",
            headers: new Headers({
                "Content-Type": "application/json",
                "Accept": "application/json"
            })
        };

        return this.http.request(url_, options_).flatMap((response_) => {
            return this.processUpdate(response_);
        }).catch((response_: any) => {
            if (response_ instanceof Response) {
                try {
                    return this.processUpdate(response_);
                } catch (e) {
                    return <Observable<WeChatGroup>><any>Observable.throw(e);
                }
            } else
                return <Observable<WeChatGroup>><any>Observable.throw(response_);
        });
    }

    protected processUpdate(response: Response): Observable<WeChatGroup> {
        const status = response.status;

        let _headers: any = response.headers ? response.headers.toJSON() : {};
        if (status === 200) {
            const _responseText = response.text();
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = resultData200 ? WeChatGroup.fromJS(resultData200) : new WeChatGroup();
            return Observable.of(result200);
        } else if (status === 401) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status === 403) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.text();
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Observable.of<WeChatGroup>(<any>null);
    }

    BatchMarkWeChatUser(): Observable<void> {
        let url_ = this.baseUrl + "/api/services/app/WeChatGroup/BatchMarkWeChatGroup";
        // if (id !== undefined)
        //     url_ += "Id=" + encodeURIComponent("" + id) + "&";
        url_ = url_.replace(/[?&]$/, "");

        let options_ = {
            method: "post",
            headers: new Headers({
                "Content-Type": "application/json",
            })
        };

        return this.http.request(url_, options_).flatMap((response_) => {
            return this.processBatchMarkWeChatUser(response_);
        }).catch((response_: any) => {
            if (response_ instanceof Response) {
                try {
                    return this.processBatchMarkWeChatUser(response_);
                } catch (e) {
                    return <Observable<void>><any>Observable.throw(e);
                }
            } else
                return <Observable<void>><any>Observable.throw(response_);
        });
    }

    protected processBatchMarkWeChatUser(response: Response): Observable<void> {
        const status = response.status;

        let _headers: any = response.headers ? response.headers.toJSON() : {};
        if (status === 200) {
            const _responseText = response.text();
            return Observable.of<void>(<any>null);
        } else if (status === 401) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status === 403) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.text();
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Observable.of<void>(<any>null);
    }

    delete(id: number, tagId: number): Observable<void> {
        let url_ = this.baseUrl + "/api/services/app/WeChatGroup/DeleteWeChatGroupAsync?";
        if (id !== undefined)
            url_ += "Id=" + encodeURIComponent("" + id) + "&";
        if (id !== undefined)
            url_ += "TagId=" + encodeURIComponent("" + tagId) + "&";
        url_ = url_.replace(/[?&]$/, "");

        let options_ = {
            method: "delete",
            headers: new Headers({
                "Content-Type": "application/json",
            })
        };

        return this.http.request(url_, options_).flatMap((response_) => {
            return this.processDelete(response_);
        }).catch((response_: any) => {
            if (response_ instanceof Response) {
                try {
                    return this.processDelete(response_);
                } catch (e) {
                    return <Observable<void>><any>Observable.throw(e);
                }
            } else
                return <Observable<void>><any>Observable.throw(response_);
        });
    }

    protected processDelete(response: Response): Observable<void> {
        const status = response.status;

        let _headers: any = response.headers ? response.headers.toJSON() : {};
        if (status === 200) {
            const _responseText = response.text();
            return Observable.of<void>(<any>null);
        } else if (status === 401) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status === 403) {
            const _responseText = response.text();
            return throwException("A server error occurred.", status, _responseText, _headers);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.text();
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Observable.of<void>(<any>null);
    }

}
export class PagedResultDtoOfWeChatGroup implements IPagedResultDtoOfWeChatGroup {
    totalCount: number;
    items: WeChatGroup[];

    constructor(data?: IPagedResultDtoOfWeChatGroup) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.totalCount = data["totalCount"];
            if (data["items"] && data["items"].constructor === Array) {
                this.items = [];
                for (let item of data["items"])
                    this.items.push(WeChatGroup.fromJS(item));
            }
        }
    }

    static fromJS(data: any): PagedResultDtoOfWeChatGroup {
        let result = new PagedResultDtoOfWeChatGroup();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["totalCount"] = this.totalCount;
        if (this.items && this.items.constructor === Array) {
            data["items"] = [];
            for (let item of this.items)
                data["items"].push(item.toJSON());
        }
        return data;
    }

    clone() {
        const json = this.toJSON();
        let result = new PagedResultDtoOfWeChatGroup();
        result.init(json);
        return result;
    }
}

export interface IPagedResultDtoOfWeChatGroup {
    totalCount: number;
    items: WeChatGroup[];
}


export class WeChatGroupList implements IWeChatGroupList {
    items: WeChatGroup[];

    constructor(data?: IWeChatGroupList) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            // this.totalCount = data["totalCount"];
            // if (data["items"] && data["items"].constructor === Array) {
            //     this.items = [];
            //     for (let item of data["items"])
            //         this.items.push(WeChatGroup.fromJS(item));
            // }
            if (data && data.constructor === Array) {
                this.items = [];
                for (let item of data)
                    this.items.push(WeChatGroup.fromJS(item));
            }
        }
    }

    static fromJS(data: any): WeChatGroupList {
        let result = new WeChatGroupList();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        // data["totalCount"] = this.totalCount;
        // if (this.items && this.items.constructor === Array) {
        //     data["items"] = [];
        //     for (let item of this.items)
        //         data["items"].push(item.toJSON());
        // }
        if (this.items && this.items.constructor === Array) {
            data = [];
            for (let item of this.items)
                data.push(item.toJSON());
        }
        return data;
    }

    clone() {
        const json = this.toJSON();
        let result = new WeChatGroupList();
        result.init(json);
        return result;
    }
}

export interface IWeChatGroupList {
    items: WeChatGroup[];
}