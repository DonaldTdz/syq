using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using HC.WeChat.WechatEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.WeChat.Orders
{
    /// <summary>
    /// 订单表
    /// </summary>
    [Table("Orders")]
    public class Order : Entity<Guid>
    {

        /// <summary>
        /// 用户Id
        /// </summary>
        public virtual string UserId { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        public virtual string OrderId { get; set; }

        /// <summary>
        /// 活动Id
        /// </summary>
        public virtual int? ActivityId { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        public virtual DateTime? CreationTime { get; set; }

        /// <summary>
        /// 订单状态(1未支付 2支付成功 3退款)
        /// </summary>
        public virtual OrderStatus? State { get; set; }

        /// <summary>
        /// 服务器告知多少钱
        /// </summary>
        public virtual decimal? Money { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        public virtual string OpenOrder { get; set; }

        /// <summary>
        /// NoticeTime
        /// </summary>
        public virtual DateTime? NoticeTime { get; set; }

        /// <summary>
        /// 充值来源(1支付宝 2微信支付)
        /// </summary>
        public virtual int? RechargeSource { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public virtual decimal? Price { get; set; }

        /// <summary>
        /// 参见成人数量
        /// </summary>
        public virtual int? AdultSum { get; set; }

        /// <summary>
        /// 参见孩子数量
        /// </summary>
        public virtual int? ChildSum { get; set; }

        /// <summary>
        /// 是否使用积分数量(0 表示未使用)
        /// </summary>
        public virtual int? IsUseIntegral { get; set; }

        /// <summary>
        /// 参加人员的唯一编号(数组)
        /// </summary>
        [StringLength(300)]
        public virtual string PlayerList { get; set; }

        /// <summary>
        /// 退款第三方交易凭证
        /// </summary>
        [StringLength(100)]
        public virtual string ExitOrderNo { get; set; }

        /// <summary>
        /// IsEnterState
        /// </summary>
        public virtual int? IsEnterState { get; set; }

        /// <summary>
        /// TicketSum
        /// </summary>
        public virtual int? TicketSum { get; set; }

        /// <summary>
        /// PriceIndex
        /// </summary>
        [StringLength(50)]
        public virtual string PriceIndex { get; set; }

        /// <summary>
        /// PpriceTitle
        /// </summary>
        [StringLength(200)]
        public virtual string PpriceTitle { get; set; }

        /// <summary>
        /// PlayBuuId
        /// </summary>
        public virtual string PlayBuuId { get; set; }

        /// <summary>
        /// PlayTime
        /// </summary>
        public virtual int? PlayTime { get; set; }

        /// <summary>
        /// 总的参加人数
        /// </summary>
        public virtual int? AllManSum { get; set; }

        /// <summary>
        /// 总保险费用
        /// </summary>
        public virtual decimal? AllSafePrice { get; set; }

        /// <summary>
        /// 使用奖券唯一码
        /// </summary>
        public virtual string UseBillUnId { get; set; }

        /// <summary>
        /// 使用卷是否成功(1成功 0为成功)
        /// </summary>
        public virtual int? UseBillState { get; set; }

        /// <summary>
        /// 使用卷折扣钱
        /// </summary>
        public virtual decimal? UseBillToMoney { get; set; }

        /// <summary>
        /// 使用积分兑现钱
        /// </summary>
        public virtual decimal? UseIntToMoney { get; set; }

        /// <summary>
        /// 票的总价格
        /// </summary>
        public virtual decimal? AllPriceInt { get; set; }

        /// <summary>
        /// 用户自己是否看(1看见 0不看)
        /// </summary>
        public virtual int? IsCanToSee { get; set; }

        /// <summary>
        /// 商家店唯一码
        /// </summary>
        public virtual string PlayShuId { get; set; }

        /// <summary>
        /// 商家每张票价格
        /// </summary>
        public virtual decimal? BuPrice { get; set; }
    }
}
