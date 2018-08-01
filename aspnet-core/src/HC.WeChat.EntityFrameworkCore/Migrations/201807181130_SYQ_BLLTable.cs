using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.WeChat.Migrations
{
    public partial class SYQ_BLLTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
              name: "Orders",
              columns: table => new
              {
                  Id = table.Column<Guid>(nullable: false),
                  OrderId = table.Column<string>(maxLength: 300, nullable: true),
                  UserId = table.Column<string>(maxLength: 300, nullable: true),
                  ActivityId = table.Column<int?>(nullable: true),
                  CreationTime = table.Column<DateTime>(nullable: true),
                  State = table.Column<int>(nullable: true),
                  Money = table.Column<decimal>(nullable: true),
                  OpenOrder = table.Column<string>(maxLength: 300, nullable: true),
                  NoticeTime = table.Column<DateTime>(nullable: true),
                  RechargeSource = table.Column<int>(nullable: true),
                  Price = table.Column<decimal>(nullable: true),
                  AdultSum = table.Column<int>(nullable: true),
                  ChildSum = table.Column<int>(nullable: true),
                  IsUseIntegral = table.Column<int>(nullable: true),
                  PlayerList = table.Column<string>(maxLength: 300, nullable: true),
                  ExitOrderNo = table.Column<string>(maxLength: 100, nullable: true),
                  IsEnterState = table.Column<int>(nullable: true),
                  TicketSum = table.Column<int>(nullable: true),
                  PriceIndex = table.Column<string>(maxLength: 50, nullable: true),
                  PpriceTitle = table.Column<string>(maxLength: 200, nullable: true),
                  PlayBuuId = table.Column<string>(maxLength: 300, nullable: true),
                  PlayTime = table.Column<int>(nullable: true),
                  AllManSum = table.Column<int>(nullable: true),
                  AllSafePrice = table.Column<decimal>(nullable: true),
                  UseBillUnId = table.Column<string>(maxLength: 300, nullable: true),
                  UseBillState = table.Column<int>(nullable: true),
                  UseBillToMoney = table.Column<decimal>(nullable: true),
                  UseIntToMoney = table.Column<decimal>(nullable: true),
                  AllPriceInt = table.Column<decimal>(nullable: true),
                  IsCanToSee = table.Column<int>(nullable: true),
                  PlayShuId = table.Column<string>(maxLength: 300, nullable: true),
                  BuPrice = table.Column<decimal>(nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Orders", x => x.Id);
              });

            migrationBuilder.CreateTable(
                name: "OrderListEnclosures",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    ChnName = table.Column<string>(maxLength: 60, nullable: true),
                    Phone = table.Column<string>(maxLength: 11, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    IdCard = table.Column<string>(maxLength: 18, nullable: true),
                    Remark = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderListEnclosures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OpenId = table.Column<string>(maxLength: 50, nullable: true),
                    RoleName = table.Column<string>(maxLength: 150, nullable: true),
                    Sex = table.Column<string>(maxLength: 1, nullable: true),
                    Integral = table.Column<int>(nullable: true),
                    FollowSum = table.Column<int>(nullable: true),
                    FollowedSum = table.Column<int>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    NewClass1Sum = table.Column<int>(nullable: true),
                    NewClass2Sum = table.Column<int>(nullable: true),
                    HeardImgName = table.Column<string>(maxLength: 250, nullable: true),
                    JoinTripSum = table.Column<int>(nullable: true),
                    TaskTimeS = table.Column<string>(maxLength: 1000, nullable: true),
                    CertificatesImgM = table.Column<string>(maxLength: 100, nullable: true),
                    CertificatesImgS = table.Column<string>(maxLength: 100, nullable: true),
                    Birthday = table.Column<string>(maxLength: 100, nullable: true),
                    LiveAddress = table.Column<string>(maxLength: 300, nullable: true),
                    IsExamine = table.Column<int>(nullable: true),
                    ExamineTime = table.Column<DateTime>(nullable: true),
                    ExchangeTitle = table.Column<string>(maxLength: 200, nullable: true),
                    UpSignTime = table.Column<DateTime>( nullable: true),
                    ContSignSum = table.Column<int>(nullable: true),
                    SignWeekNum = table.Column<int>(nullable: true),
                    ColumnInfo = table.Column<string>(maxLength: 300, nullable: true),
                    BodyInfo = table.Column<string>(maxLength: 2000, nullable: true),
                    BodyInfoState = table.Column<int>(nullable: true),
                    FirstFollowUserState = table.Column<int>(nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 11, nullable: true),
                    FromId = table.Column<int>(nullable: true),
                    HeardImgClass = table.Column<int>(nullable: true),
                    InvitationCode = table.Column<string>(maxLength: 20, nullable: true),
                    LoginInvitationCode = table.Column<string>(maxLength: 20, nullable: true),
                    ExchangHomeState = table.Column<int>(nullable: true),
                    FirstInvitationFriend = table.Column<int>(nullable: true),
                    OnlineTimeLong = table.Column<int>(nullable: true),
                    CommentSum = table.Column<int>(nullable: true),
                    ShareSum = table.Column<int>(nullable: true),
                    TalkDelTime = table.Column<DateTime>(nullable: true),
                    IsLoginState = table.Column<int>(nullable: true),
                    DeviceToken = table.Column<string>(maxLength: 200, nullable: true),
                    BuuId = table.Column<string>(maxLength: 300, nullable: true),
                    BindBUSum = table.Column<int>(nullable: true),
                    GetTreeIntDate = table.Column<string>(maxLength: 100, nullable: true),
                    UserNeedRedu = table.Column<string>(maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Activitys",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ActivityId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: true),
                    ClassInt = table.Column<string>(maxLength: 300, nullable: true),
                    CostInt = table.Column<decimal>(nullable: true),
                    AgeClassInt = table.Column<string>(maxLength: 300, nullable: true),
                    IconImg = table.Column<string>(maxLength: 60, nullable: true),
                    BTitle = table.Column<string>(maxLength: 1000, nullable: true),
                    LeaderInt = table.Column<string>(maxLength: 300, nullable: true),
                    ActivityMessage = table.Column<string>(nullable: true),
                    BeCarefulMessage = table.Column<string>(maxLength: 4000, nullable: true),
                    OutActivityMessage = table.Column<string>(maxLength: 4000, nullable: true),
                    OneselfClass = table.Column<int>(nullable: true),
                    HuoClass = table.Column<int>(nullable: true),
                    TitleIdClass = table.Column<string>(maxLength: 10, nullable: true),
                    LimitTime = table.Column<DateTime>(nullable: true),
                    ImgArray = table.Column<string>(maxLength: 1000, nullable: true),
                    IsClose = table.Column<int>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: true),
                    SortInt = table.Column<int>(nullable: true),
                    GoodSum = table.Column<int>(nullable: true),
                    FirstReState = table.Column<int>(nullable: true),
                    SeeSum = table.Column<int>(nullable: true),
                    ActivityTime = table.Column<DateTime>(nullable: true),
                    ActivityAddress = table.Column<string>(maxLength: 300, nullable: true),
                    CommentSum = table.Column<int>(nullable: true),
                    CostIntClass = table.Column<int>(nullable: true),
                    AdultCostInt = table.Column<decimal>(nullable: true),
                    ChildCostInt = table.Column<decimal>(nullable: true),
                    AllTeamSum = table.Column<int>(nullable: true),
                    LoginTeamSum = table.Column<int>(nullable: true),
                    BUACMoneyPP = table.Column<decimal>(nullable: true),
                    WXShowState = table.Column<int>(nullable: true),
                    BuSendActivityId = table.Column<string>(maxLength: 300, nullable: true),
                    WXPriceArray = table.Column<string>(maxLength: 2000, nullable: true),
                    BuuId = table.Column<string>(maxLength: 300, nullable: true),
                    SafeClass = table.Column<int>(nullable: true),
                    SafeMoneyChi = table.Column<decimal>(nullable: true),
                    SafeMoneyMan = table.Column<decimal>(nullable: true),
                    IsBillPay = table.Column<int>(nullable: true),
                    ActivtiyEndTime = table.Column<DateTime>(nullable: true),
                    IntPayLimit = table.Column<int>(nullable: true),
                    SendTicketState = table.Column<int>(nullable: true),
                    IsExitOrder = table.Column<int>(nullable: true),
                    TicketsMessage = table.Column<string>(maxLength: 1000, nullable: true),
                    SendId = table.Column<int>(nullable: true),
                    MixPrice = table.Column<decimal>(nullable: true),
                    ReducePriceUser = table.Column<int>(nullable: true),
                    ReducePriceLTime = table.Column<DateTime>(nullable: true),
                    ReducePriceMessage = table.Column<string>(nullable: true),
                    WXAppUrlShow = table.Column<string>(maxLength: 500, nullable: true),
                    UserNeedRedu = table.Column<string>(maxLength: 1000, nullable: true),
                    PlayCQImg = table.Column<string>(maxLength: 200, nullable: true),
                    PlayCQImgState = table.Column<int>(nullable: true),
                    AcUrlCode = table.Column<int>(nullable: true),
                    SettlementClass = table.Column<int>(nullable: true),
                    SettlementString = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activitys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuSetInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    BuName = table.Column<string>(maxLength: 150, nullable: true),
                    Phone = table.Column<string>(maxLength: 11, nullable: true),
                    ContactsName = table.Column<string>(maxLength: 20, nullable: true),
                    Address = table.Column<string>(maxLength: 150, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuSetInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "OrderListEnclosures");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "Activitys");

            migrationBuilder.DropTable(
                name: "BuSetInfos");
        }
    }
}