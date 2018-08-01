export class Activitys implements IActivitys {
    id: string;
    title: string;
    classInt: string;
    costInt: number;
    ageClassInt: string;
    iconImg: string;
    bTitle: string;
    leaderInt: string;
    activityMessage: string;
    beCarefulMessage: string;
    outActivityMessage: string;
    oneselfClass: number;
    huoClass: number;
    titleIdClass: string;
    limitTime: Date;
    imgArray: string;
    isClose: number;
    creationTime: Date;
    sortInt: number;
    goodSum: number;
    firstReState: number;
    seeSum: number;
    activityTime: Date;
    activityAddress: string;
    commentSum: number;
    costIntClass: number;
    adultCostInt: number;
    childCostInt: number;
    allTeamSum: number;
    loginTeamSum: number;
    bUACMoneyPP: number;
    wXShowState: number;
    buSendActivityId: string;
    wXPriceArray: string;
    buuId: string;
    safeClass: number;
    safeMoneyChi: number;
    safeMoneyMan: number;
    isBillPay: number;
    activtiyEndTime: Date;
    intPayLimit: number;
    sendTicketState: number;
    isExitOrder: number;
    ticketsMessage: string;
    sendId: number;
    mixPrice: number;
    reducePriceUser: number;
    reducePriceLTime: Date;
    reducePriceMessage: string;
    wXAppUrlShow: string;
    userNeedRedu: string;
    playCQImg: string;
    playCQImgState: number;
    acUrlCode: number;
    settlementClass: number;
    settlementString: string;
    constructor(data?: IActivitys) {
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
            this.title = data["title"];
            this.classInt = data["classInt"];
            this.costInt = data["costInt"];
            this.ageClassInt = data["ageClassInt"];
            this.iconImg = data["iconImg"];
            this.bTitle = data["bTitle"];
            this.leaderInt = data["leaderInt"];
            this.activityMessage = data["activityMessage"];
            this.beCarefulMessage = data["beCarefulMessage"];
            this.outActivityMessage = data["outActivityMessage"];
            this.oneselfClass = data["oneselfClass"];
            this.huoClass = data["huoClass"];
            this.titleIdClass = data["titleIdClass"];
            this.limitTime = data["limitTime"];
            this.imgArray = data["imgArray"];
            this.isClose = data["isClose"];
            this.creationTime = data["creationTime"];
            this.sortInt = data["sortInt"];
            this.goodSum = data["goodSum"];
            this.firstReState = data["firstReState"];
            this.seeSum = data["seeSum"];
            this.activityTime = data["activityTime"];
            this.activityAddress = data["activityAddress"];
            this.commentSum = data["commentSum"];
            this.costIntClass = data["costIntClass"];
            this.adultCostInt = data["adultCostInt"];
            this.childCostInt = data["childCostInt"];
            this.allTeamSum = data["allTeamSum"];
            this.loginTeamSum = data["loginTeamSum"];
            this.bUACMoneyPP = data["bUACMoneyPP"];
            this.wXShowState = data["wXShowState"];
            this.buSendActivityId = data["buSendActivityId"];
            this.wXPriceArray = data["wXPriceArray"];
            this.buuId = data["buuId"];
            this.safeClass = data["safeClass"];
            this.safeMoneyChi = data["safeMoneyChi"];
            this.safeMoneyMan = data["safeMoneyMan"];
            this.isBillPay = data["isBillPay"];
            this.activtiyEndTime = data["activtiyEndTime"];
            this.intPayLimit = data["intPayLimit"];
            this.sendTicketState = data["sendTicketState"];
            this.isExitOrder = data["isExitOrder"];
            this.ticketsMessage = data["ticketsMessage"];
            this.sendId = data["sendId"];
            this.mixPrice = data["mixPrice"];
            this.reducePriceUser = data["reducePriceUser"];
            this.reducePriceLTime = data["reducePriceLTime"];
            this.reducePriceMessage = data["reducePriceMessage"];
            this.wXAppUrlShow = data["wXAppUrlShow"];
            this.userNeedRedu = data["userNeedRedu"];
            this.playCQImg = data["playCQImg"];
            this.playCQImgState = data["playCQImgState"];
            this.acUrlCode = data["acUrlCode"];
            this.settlementClass = data["settlementClass"];
            this.settlementString = data["settlementString"];
        }
    }

    static fromJS(data: any): Activitys {
        let result = new Activitys();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["title"] = this.title;
        data["classInt"] = this.classInt;
        data["costInt"] = this.costInt;
        data["ageClassInt"] = this.ageClassInt;
        data["iconImg"] = this.iconImg;
        data["bTitle"] = this.bTitle;
        data["leaderInt"] = this.leaderInt;
        data["activityMessage"] = this.activityMessage;
        data["beCarefulMessage"] = this.beCarefulMessage;
        data["outActivityMessage"] = this.outActivityMessage;
        data["oneselfClass"] = this.oneselfClass;
        data["huoClass"] = this.huoClass;
        data["titleIdClass"] = this.titleIdClass;
        data["limitTime"] = this.limitTime;
        data["imgArray"] = this.imgArray;
        data["isClose"] = this.isClose;
        data["creationTime"] = this.creationTime;
        data["sortInt"] = this.sortInt;
        data["goodSum"] = this.goodSum;
        data["firstReState"] = this.firstReState;
        data["seeSum"] = this.seeSum;
        data["activityTime"] = this.activityTime;
        data["activityAddress"] = this.activityAddress;
        data["commentSum"] = this.commentSum;
        data["costIntClass"] = this.costIntClass;
        data["adultCostInt"] = this.adultCostInt;
        data["childCostInt"] = this.childCostInt;
        data["allTeamSum"] = this.allTeamSum;
        data["loginTeamSum"] = this.loginTeamSum;
        data["bUACMoneyPP"] = this.bUACMoneyPP;
        data["wXShowState"] = this.wXShowState;
        data["buSendActivityId"] = this.buSendActivityId;
        data["wXPriceArray"] = this.wXPriceArray;
        data["buuId"] = this.buuId;
        data["safeClass"] = this.safeClass;
        data["safeMoneyChi"] = this.safeMoneyChi;
        data["safeMoneyMan"] = this.safeMoneyMan;
        data["isBillPay"] = this.isBillPay;
        data["activtiyEndTime"] = this.activtiyEndTime;
        data["intPayLimit"] = this.intPayLimit;
        data["sendTicketState"] = this.sendTicketState;
        data["isExitOrder"] = this.isExitOrder;
        data["ticketsMessage"] = this.ticketsMessage;
        data["sendId"] = this.sendId;
        data["mixPrice"] = this.mixPrice;
        data["reducePriceUser"] = this.reducePriceUser;
        data["reducePriceLTime"] = this.reducePriceLTime;
        data["reducePriceMessage"] = this.reducePriceMessage;
        data["wXAppUrlShow"] = this.wXAppUrlShow;
        data["userNeedRedu"] = this.userNeedRedu;
        data["playCQImg"] = this.playCQImg;
        data["playCQImgState"] = this.playCQImgState;
        data["acUrlCode"] = this.acUrlCode;
        data["settlementClass"] = this.settlementClass;
        data["settlementString"] = this.settlementString;
        return data;
    }

    clone() {
        const json = this.toJSON();
        let result = new Activitys();
        result.init(json);
        return result;
    }
}
export interface IActivitys {
    id: string;
    title: string;
    classInt: string;
    costInt: number;
    ageClassInt: string;
    iconImg: string;
    bTitle: string;
    leaderInt: string;
    activityMessage: string;
    beCarefulMessage: string;
    outActivityMessage: string;
    oneselfClass: number;
    huoClass: number;
    titleIdClass: string;
    limitTime: Date;
    imgArray: string;
    isClose: number;
    creationTime: Date;
    sortInt: number;
    goodSum: number;
    firstReState: number;
    seeSum: number;
    activityTime: Date;
    activityAddress: string;
    commentSum: number;
    costIntClass: number;
    adultCostInt: number;
    childCostInt: number;
    allTeamSum: number;
    loginTeamSum: number;
    bUACMoneyPP: number;
    wXShowState: number;
    buSendActivityId: string;
    wXPriceArray: string;
    buuId: string;
    safeClass: number;
    safeMoneyChi: number;
    safeMoneyMan: number;
    isBillPay: number;
    activtiyEndTime: Date;
    intPayLimit: number;
    sendTicketState: number;
    isExitOrder: number;
    ticketsMessage: string;
    sendId: number;
    mixPrice: number;
    reducePriceUser: number;
    reducePriceLTime: Date;
    reducePriceMessage: string;
    wXAppUrlShow: string;
    userNeedRedu: string;
    playCQImg: string;
    playCQImgState: number;
    acUrlCode: number;
    settlementClass: number;
    settlementString: string;
}