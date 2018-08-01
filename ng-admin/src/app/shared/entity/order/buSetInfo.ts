export class BuSetInfos implements IBuSetInfos {
    id: string;
    buName: string;
    phone: string;
    contactsName: string;
    address: string;
    creationTime: Date;
    constructor(data?: IBuSetInfos) {
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
            this.buName = data["buName"];
            this.phone = data["phone"];
            this.contactsName = data["contactsName"];
            this.address = data["address"];
            this.creationTime = data["creationTime"];
        }
    }

    static fromJS(data: any): BuSetInfos {
        let result = new BuSetInfos();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["buName"] = this.buName;
        data["phone"] = this.phone;
        data["contactsName"] = this.contactsName;
        data["address"] = this.address;
        data["creationTime"] = this.creationTime;
        return data;
    }

    clone() {
        const json = this.toJSON();
        let result = new BuSetInfos();
        result.init(json);
        return result;
    }
}
export interface IBuSetInfos {
    id: string;
    buName: string;
    phone: string;
    contactsName: string;
    address: string;
    creationTime: Date;
}