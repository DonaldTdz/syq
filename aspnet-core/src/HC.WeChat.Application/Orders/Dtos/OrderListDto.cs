using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;
using HC.WeChat.Orders;
using System.Collections.Generic;
using HC.WeChat.WechatEnums;

namespace HC.WeChat.Orders.Dtos
{
    public class OrderListDto : EntityDto<Guid>
    {

        /// <summary>
        /// UserId
        /// </summary>
        public Guid? UserId { get; set; }

        public string OrderId { get; set; }

        /// <summary>
        /// ActivityId
        /// </summary>
        public Guid? ActivityId { get; set; }


        /// <summary>
        /// CreationTime
        /// </summary>
        public DateTime? CreationTime { get; set; }


        /// <summary>
        /// State
        /// </summary>
        public OrderStatus? State { get; set; }


        /// <summary>
        /// Money
        /// </summary>
        public decimal? Money { get; set; }


        /// <summary>
        /// OpenOrder
        /// </summary>
        public Guid? OpenOrder { get; set; }


        /// <summary>
        /// NoticeTime
        /// </summary>
        public DateTime? NoticeTime { get; set; }


        /// <summary>
        /// RechargeSource
        /// </summary>
        public int? RechargeSource { get; set; }


        /// <summary>
        /// Price
        /// </summary>
        public decimal? Price { get; set; }


        /// <summary>
        /// AdultSum
        /// </summary>
        public int? AdultSum { get; set; }


        /// <summary>
        /// ChildSum
        /// </summary>
        public int? ChildSum { get; set; }


        /// <summary>
        /// IsUseIntegral
        /// </summary>
        public int? IsUseIntegral { get; set; }


        /// <summary>
        /// PlayerList
        /// </summary>
        public string PlayerList { get; set; }


        /// <summary>
        /// ExitOrderNo
        /// </summary>
        public string ExitOrderNo { get; set; }


        /// <summary>
        /// IsEnterState
        /// </summary>
        public int? IsEnterState { get; set; }


        /// <summary>
        /// TicketSum
        /// </summary>
        public int? TicketSum { get; set; }


        /// <summary>
        /// PriceIndex
        /// </summary>
        public string PriceIndex { get; set; }


        /// <summary>
        /// PpriceTitle
        /// </summary>
        public string PpriceTitle { get; set; }


        /// <summary>
        /// PlayBuuId
        /// </summary>
        public Guid? PlayBuuId { get; set; }


        /// <summary>
        /// PlayTime
        /// </summary>
        public int? PlayTime { get; set; }


        /// <summary>
        /// AllManSum
        /// </summary>
        public int? AllManSum { get; set; }


        /// <summary>
        /// AllSafePrice
        /// </summary>
        public decimal? AllSafePrice { get; set; }


        /// <summary>
        /// UseBillUnId
        /// </summary>
        public Guid? UseBillUnId { get; set; }


        /// <summary>
        /// UseBillState
        /// </summary>
        public int? UseBillState { get; set; }


        /// <summary>
        /// UseBillToMoney
        /// </summary>
        public decimal? UseBillToMoney { get; set; }


        /// <summary>
        /// UseIntToMoney
        /// </summary>
        public decimal? UseIntToMoney { get; set; }


        /// <summary>
        /// AllPriceInt
        /// </summary>
        public decimal? AllPriceInt { get; set; }


        /// <summary>
        /// IsCanToSee
        /// </summary>
        public int? IsCanToSee { get; set; }


        /// <summary>
        /// PlayShuId
        /// </summary>
        public Guid? PlayShuId { get; set; }


        /// <summary>
        /// BuPrice
        /// </summary>
        public decimal? BuPrice { get; set; }

        public string Title { get; set; }


        public string WXPriceArray { get; set; }
        public string OpenId { get; set; }

        /// <summary>
        /// ∑‚√ÊÕº
        /// </summary>
        public string IconImg { get; set; }
    //public Dictionary<string, string[]> PriceArray
    //{
    //    get
    //    {
    //        if (!string.IsNullOrEmpty(WXPriceArray))
    //        {

    //        }
    //        return null;
    //    }
    //}


    //// custom codes 

    //// custom codes end
}
}