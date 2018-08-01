export class UserInfo implements IUserInfo {
    id: string;
    openId: string;
    roleName: string;
    sex: string;
    integral: number;
    followSum: number;
    followedSum: number;
    createTime: Date;
    newClass1Sum: number;
    newClass2Sum: number;
    heardImgName: string;
    joinTripSum: number;
    taskTimeS: string;
    certificatesImgM: string;
    certificatesImgS: string;
    birthday: string;
    liveAddress: string;
    isExamine: number;
    examineTime: Date;
    exchangeTitle: string;
    upSignTime: Date;
    contSignSum: number;
    signWeekNum: number;
    columnInfo: string;
    bodyInfo: string;
    bodyInfoState: number;
    firstFollowUserState: number;
    phoneNumber: string;
    fromId: number;
    heardImgClass: number;
    invitationCode: string;
    loginInvitationCode: string;
    exchangHomeState: number;
    firstInvitationFriend: number;
    onlineTimeLong: number;
    commentSum: number;
    shareSum: number;
    talkDelTime: Date;
    isLoginState: number;
    deviceToken: string;
    buuId: string;
    bindBUSum: number;
    getTreeIntDate: string;
    userNeedRedu: string;
    constructor(data?: IUserInfo) {
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
            this.openId = data["openId"];
            this.roleName = data["roleName"];
            this.sex = data["sex"];
            this.integral = data["integral"];
            this.followSum = data["followSum"];
            this.followedSum = data["followedSum"];
            this.createTime = data["createTime"];
            this.newClass1Sum = data["newClass1Sum"];
            this.newClass2Sum = data["newClass2Sum"];
            this.heardImgName = data["heardImgName"];
            this.joinTripSum = data["joinTripSum"];
            this.taskTimeS = data["taskTimeS"];
            this.certificatesImgM = data["certificatesImgM"];
            this.certificatesImgS = data["certificatesImgS"];
            this.birthday = data["birthday"];
            this.liveAddress = data["liveAddress"];
            this.isExamine = data["isExamine"];
            this.examineTime = data["examineTime"];
            this.exchangeTitle = data["exchangeTitle"];
            this.upSignTime = data["upSignTime"];
            this.contSignSum = data["contSignSum"];
            this.signWeekNum = data["signWeekNum"];
            this.columnInfo = data["columnInfo"];
            this.bodyInfo = data["bodyInfo"];
            this.bodyInfoState = data["bodyInfoState"];
            this.firstFollowUserState = data["firstFollowUserState"];
            this.phoneNumber = data["phoneNumber"];
            this.fromId = data["fromId"];
            this.heardImgClass = data["heardImgClass"];
            this.invitationCode = data["invitationCode"];
            this.loginInvitationCode = data["loginInvitationCode"];
            this.exchangHomeState = data["exchangHomeState"];
            this.firstInvitationFriend = data["firstInvitationFriend"];
            this.onlineTimeLong = data["onlineTimeLong"];
            this.commentSum = data["commentSum"];
            this.shareSum = data["shareSum"];
            this.talkDelTime = data["talkDelTime"];
            this.isLoginState = data["isLoginState"];
            this.deviceToken = data["deviceToken"];
            this.buuId = data["buuId"];
            this.bindBUSum = data["bindBUSum"];
            this.getTreeIntDate = data["getTreeIntDate"];
            this.userNeedRedu = data["userNeedRedu"];
        }
    }

    static fromJS(data: any): UserInfo {
        let result = new UserInfo();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["openId"] = this.openId;
        data["roleName"] = this.roleName;
        data["sex"] = this.sex;
        data["integral"] = this.integral;
        data["followSum"] = this.followSum;
        data["followedSum"] = this.followedSum;
        data["createTime"] = this.createTime;
        data["newClass1Sum"] = this.newClass1Sum;
        data["newClass2Sum"] = this.newClass2Sum;
        data["heardImgName"] = this.heardImgName;
        data["joinTripSum"] = this.joinTripSum;
        data["taskTimeS"] = this.taskTimeS;
        data["certificatesImgM"] = this.certificatesImgM;
        data["certificatesImgS"] = this.certificatesImgS;
        data["birthday"] = this.birthday;
        data["liveAddress"] = this.liveAddress;
        data["isExamine"] = this.isExamine;
        data["examineTime"] = this.examineTime;
        data["exchangeTitle"] = this.exchangeTitle;
        data["upSignTime"] = this.upSignTime;
        data["contSignSum"] = this.contSignSum;
        data["signWeekNum"] = this.signWeekNum;
        data["columnInfo"] = this.columnInfo;
        data["bodyInfo"] = this.bodyInfo;
        data["bodyInfoState"] = this.bodyInfoState;
        data["firstFollowUserState"] = this.firstFollowUserState;
        data["phoneNumber"] = this.phoneNumber;
        data["fromId"] = this.fromId;
        data["heardImgClass"] = this.heardImgClass;
        data["invitationCode"] = this.invitationCode;
        data["loginInvitationCode"] = this.loginInvitationCode;
        data["exchangHomeState"] = this.exchangHomeState;
        data["firstInvitationFriend"] = this.firstInvitationFriend;
        data["onlineTimeLong"] = this.onlineTimeLong;
        data["commentSum"] = this.commentSum;
        data["shareSum"] = this.shareSum;
        data["talkDelTime"] = this.talkDelTime;
        data["isLoginState"] = this.isLoginState;
        data["deviceToken"] = this.deviceToken;
        data["buuId"] = this.buuId;
        data["bindBUSum"] = this.bindBUSum;
        data["getTreeIntDate"] = this.getTreeIntDate;
        data["userNeedRedu"] = this.userNeedRedu;
        return data;
    }

    clone() {
        const json = this.toJSON();
        let result = new UserInfo();
        result.init(json);
        return result;
    }
}
export interface IUserInfo {
    id: string;
    openId: string;
    roleName: string;
    sex: string;
    integral: number;
    followSum: number;
    followedSum: number;
    createTime: Date;
    newClass1Sum: number;
    newClass2Sum: number;
    heardImgName: string;
    joinTripSum: number;
    taskTimeS: string;
    certificatesImgM: string;
    certificatesImgS: string;
    birthday: string;
    liveAddress: string;
    isExamine: number;
    examineTime: Date;
    exchangeTitle: string;
    upSignTime: Date;
    contSignSum: number;
    signWeekNum: number;
    columnInfo: string;
    bodyInfo: string;
    bodyInfoState: number;
    firstFollowUserState: number;
    phoneNumber: string;
    fromId: number;
    heardImgClass: number;
    invitationCode: string;
    loginInvitationCode: string;
    exchangHomeState: number;
    firstInvitationFriend: number;
    onlineTimeLong: number;
    commentSum: number;
    shareSum: number;
    talkDelTime: Date;
    isLoginState: number;
    deviceToken: string;
    buuId: string;
    bindBUSum: number;
    getTreeIntDate: string;
    userNeedRedu: string;
}