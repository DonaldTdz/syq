using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;
using HC.WeChat.Activities;

namespace HC.WeChat.Activities.Dtos
{
    public class ActivityListDto : EntityDto<Guid>
    {
        public int ActivityId { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }


        /// <summary>
        /// ClassInt
        /// </summary>
        public string ClassInt { get; set; }


        /// <summary>
        /// CostInt
        /// </summary>
        public decimal? CostInt { get; set; }


        /// <summary>
        /// AgeClassInt
        /// </summary>
        public string AgeClassInt { get; set; }


        /// <summary>
        /// IconImg
        /// </summary>
        public string IconImg { get; set; }


        /// <summary>
        /// BTitle
        /// </summary>
        public string BTitle { get; set; }


        /// <summary>
        /// LeaderInt
        /// </summary>
        public Guid? LeaderInt { get; set; }


        /// <summary>
        /// ActivityMessage
        /// </summary>
        public string ActivityMessage { get; set; }


        /// <summary>
        /// BeCarefulMessage
        /// </summary>
        public string BeCarefulMessage { get; set; }


        /// <summary>
        /// OutActivityMessage
        /// </summary>
        public string OutActivityMessage { get; set; }


        /// <summary>
        /// OneselfClass
        /// </summary>
        public int? OneselfClass { get; set; }


        /// <summary>
        /// HuoClass
        /// </summary>
        public int? HuoClass { get; set; }


        /// <summary>
        /// TitleIdClass
        /// </summary>
        public string TitleIdClass { get; set; }


        /// <summary>
        /// LimitTime
        /// </summary>
        public DateTime? LimitTime { get; set; }


        /// <summary>
        /// ImgArray
        /// </summary>
        public string ImgArray { get; set; }


        /// <summary>
        /// IsClose
        /// </summary>
        public int? IsClose { get; set; }


        /// <summary>
        /// CreationTime
        /// </summary>
        public DateTime? CreationTime { get; set; }


        /// <summary>
        /// SortInt
        /// </summary>
        public int? SortInt { get; set; }


        /// <summary>
        /// GoodSum
        /// </summary>
        public int? GoodSum { get; set; }


        /// <summary>
        /// FirstReState
        /// </summary>
        public int? FirstReState { get; set; }


        /// <summary>
        /// SeeSum
        /// </summary>
        public int? SeeSum { get; set; }


        /// <summary>
        /// ActivityTime
        /// </summary>
        public DateTime? ActivityTime { get; set; }


        /// <summary>
        /// ActivityAddress
        /// </summary>
        public string ActivityAddress { get; set; }


        /// <summary>
        /// CommentSum
        /// </summary>
        public int? CommentSum { get; set; }


        /// <summary>
        /// CostIntClass
        /// </summary>
        public int? CostIntClass { get; set; }


        /// <summary>
        /// AdultCostInt
        /// </summary>
        public decimal? AdultCostInt { get; set; }


        /// <summary>
        /// ChildCostInt
        /// </summary>
        public decimal? ChildCostInt { get; set; }


        /// <summary>
        /// AllTeamSum
        /// </summary>
        public int? AllTeamSum { get; set; }


        /// <summary>
        /// LoginTeamSum
        /// </summary>
        public int? LoginTeamSum { get; set; }


        /// <summary>
        /// BUACMoneyPP
        /// </summary>
        public decimal? BUACMoneyPP { get; set; }


        /// <summary>
        /// WXShowState
        /// </summary>
        public int? WXShowState { get; set; }


        /// <summary>
        /// BuSendActivityId
        /// </summary>
        public Guid? BuSendActivityId { get; set; }


        /// <summary>
        /// WXPriceArray
        /// </summary>
        public string WXPriceArray { get; set; }


        /// <summary>
        /// BuuId
        /// </summary>
        public Guid? BuuId { get; set; }


        /// <summary>
        /// SafeClass
        /// </summary>
        public int? SafeClass { get; set; }


        /// <summary>
        /// SafeMoneyChi
        /// </summary>
        public decimal? SafeMoneyChi { get; set; }


        /// <summary>
        /// SafeMoneyMan
        /// </summary>
        public decimal? SafeMoneyMan { get; set; }


        /// <summary>
        /// IsBillPay
        /// </summary>
        public int? IsBillPay { get; set; }


        /// <summary>
        /// ActivtiyEndTime
        /// </summary>
        public DateTime? ActivtiyEndTime { get; set; }


        /// <summary>
        /// IntPayLimit
        /// </summary>
        public int? IntPayLimit { get; set; }


        /// <summary>
        /// SendTicketState
        /// </summary>
        public int? SendTicketState { get; set; }


        /// <summary>
        /// IsExitOrder
        /// </summary>
        public int? IsExitOrder { get; set; }


        /// <summary>
        /// TicketsMessage
        /// </summary>
        public string TicketsMessage { get; set; }


        /// <summary>
        /// SendId
        /// </summary>
        public int? SendId { get; set; }


        /// <summary>
        /// MixPrice
        /// </summary>
        public decimal? MixPrice { get; set; }


        /// <summary>
        /// ReducePriceUser
        /// </summary>
        public int? ReducePriceUser { get; set; }


        /// <summary>
        /// ReducePriceLTime
        /// </summary>
        public DateTime? ReducePriceLTime { get; set; }


        /// <summary>
        /// ReducePriceMessage
        /// </summary>
        public string ReducePriceMessage { get; set; }


        /// <summary>
        /// WXAppUrlShow
        /// </summary>
        public string WXAppUrlShow { get; set; }


        /// <summary>
        /// UserNeedRedu
        /// </summary>
        public string UserNeedRedu { get; set; }


        /// <summary>
        /// PlayCQImg
        /// </summary>
        public string PlayCQImg { get; set; }


        /// <summary>
        /// PlayCQImgState
        /// </summary>
        public int? PlayCQImgState { get; set; }


        /// <summary>
        /// AcUrlCode
        /// </summary>
        public int? AcUrlCode { get; set; }


        /// <summary>
        /// SettlementClass
        /// </summary>
        public int? SettlementClass { get; set; }


        /// <summary>
        /// SettlementString
        /// </summary>
        public string SettlementString { get; set; }






        //// custom codes 

        //// custom codes end
    }
}