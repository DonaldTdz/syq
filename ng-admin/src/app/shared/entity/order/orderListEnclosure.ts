export class OrderListEnclosure implements IOrderListEnclosure {
    id: string;
    orderId: string;
    chnName: string;
    phone: string;
    address: string;
    idCard: string;
    remark: string;
    constructor(data?: IOrderListEnclosure) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.id = data["id"];
            this.orderId = data["orderId"];
            this.chnName = data["chnName"];
            this.phone = data["phone"];
            this.address = data["address"];
            this.idCard = data["idCard"];
            this.remark = data["remark"];
        }
    }

    static fromJS(data: any): OrderListEnclosure {
        let result = new OrderListEnclosure();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["orderId"] = this.orderId;
        data["chnName"] = this.chnName;
        data["phone"] = this.phone;
        data["address"] = this.address;
        data["idCard"] = this.idCard;
        data["remark"] = this.remark;
        return data;
    }

    clone() {
        const json = this.toJSON();
        let result = new OrderListEnclosure();
        result.init(json);
        return result;
    }
}
export interface IOrderListEnclosure {
    id: string;
    orderId: string;
    chnName: string;
    phone: string;
    address: string;
    idCard: string;
    remark: string;
}