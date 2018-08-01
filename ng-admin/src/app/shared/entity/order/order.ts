export class Order implements IOrder {
    id: string;
    orderId: string;
    userId: string;
    activityId: string;
    creationTime: Date;
    state: number;
    money: number;
    openOrder: string;
    noticeTime: Date;
    rechargeSource: number;
    price: number;
    adultSum: number;
    childSum: number;
    isUseIntegral: number;
    playerList: string;
    exitOrderNo: string;
    isEnterState: number;
    ticketSum: number;
    priceIndex: string;
    ppriceTitle: string;
    playBuuId: string;
    playTime: number;
    allManSum: number;
    allSafePrice: number;
    useBillUnId: string;
    useBillState: number;
    useBillToMoney: number;
    useIntToMoney: number;
    allPriceInt: number;
    isCanToSee: number;
    playShuId: string;
    buPrice: number;
    constructor(data?: IOrder) {
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
            this.userId = data["userId"];
            this.activityId = data["activityId"];
            this.creationTime = data["creationTime"];
            this.state = data["state"];
            this.money = data["money"];
            this.openOrder = data["openOrder"];
            this.noticeTime = data["noticeTime"];
            this.rechargeSource = data["rechargeSource"];
            this.price = data["price"];
            this.adultSum = data["adultSum"];
            this.childSum = data["childSum"];
            this.isUseIntegral = data["isUseIntegral"];
            this.playerList = data["playerList"];
            this.exitOrderNo = data["exitOrderNo"];
            this.isEnterState = data["isEnterState"];
            this.ticketSum = data["ticketSum"];
            this.priceIndex = data["priceIndex"];
            this.ppriceTitle = data["ppriceTitle"];
            this.playBuuId = data["playBuuId"];
            this.playTime = data["playTime"];
            this.allManSum = data["allManSum"];
            this.allSafePrice = data["allSafePrice"];
            this.useBillUnId = data["useBillUnId"];
            this.useBillState = data["useBillState"];
            this.useBillToMoney = data["useBillToMoney"];
            this.useIntToMoney = data["useIntToMoney"];
            this.allPriceInt = data["allPriceInt"];
            this.isCanToSee = data["isCanToSee"];
            this.playShuId = data["playShuId"];
            this.buPrice = data["buPrice"];
        }
    }

    static fromJS(data: any): Order {
        let result = new Order();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["orderId"] = this.orderId;
        data["userId"] = this.userId;
        data["activityId"] = this.activityId;
        data["creationTime"] = this.creationTime;
        data["state"] = this.state;
        data["money"] = this.money;
        data["openOrder"] = this.openOrder;
        data["noticeTime"] = this.noticeTime;
        data["rechargeSource"] = this.rechargeSource;
        data["price"] = this.price;
        data["adultSum"] = this.adultSum;
        data["childSum"] = this.childSum;
        data["isUseIntegral"] = this.isUseIntegral;
        data["playerList"] = this.playerList;
        data["exitOrderNo"] = this.exitOrderNo;
        data["isEnterState"] = this.isEnterState;
        data["ticketSum"] = this.ticketSum;
        data["priceIndex"] = this.priceIndex;
        data["ppriceTitle"] = this.ppriceTitle;
        data["playBuuId"] = this.playBuuId;
        data["playTime"] = this.playTime;
        data["allManSum"] = this.allManSum;
        data["allSafePrice"] = this.allSafePrice;
        data["useBillUnId"] = this.useBillUnId;
        data["useBillState"] = this.useBillState;
        data["useBillToMoney"] = this.useBillToMoney;
        data["useIntToMoney"] = this.useIntToMoney;
        data["allPriceInt"] = this.allPriceInt;
        data["isCanToSee"] = this.isCanToSee;
        data["playShuId"] = this.playShuId;
        data["buPrice"] = this.buPrice;
        return data;
    }

    clone() {
        const json = this.toJSON();
        let result = new Order();
        result.init(json);
        return result;
    }
}
export interface IOrder {
    id: string;
    orderId: string;
    userId: string;
    activityId: string;
    creationTime: Date;
    state: number;
    money: number;
    openOrder: string;
    noticeTime: Date;
    rechargeSource: number;
    price: number;
    adultSum: number;
    childSum: number;
    isUseIntegral: number;
    playerList: string;
    exitOrderNo: string;
    isEnterState: number;
    ticketSum: number;
    priceIndex: string;
    ppriceTitle: string;
    playBuuId: string;
    playTime: number;
    allManSum: number;
    allSafePrice: number;
    useBillUnId: string;
    useBillState: number;
    useBillToMoney: number;
    useIntToMoney: number;
    allPriceInt: number;
    isCanToSee: number;
    playShuId: string;
    buPrice: number;
}