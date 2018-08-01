using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using HC.WeChat.WechatEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.WeChat.Activities
{
    /// <summary>
    /// 活动表
    /// </summary>
    [Table("Activitys")]
    public class Activity : Entity<Guid>
    {

        public virtual int ActivityId { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        [StringLength(50)]
        public virtual string Title { get; set; }

        /// <summary>
        /// ClassInt
        /// </summary>
        [StringLength(300)]
        public virtual string ClassInt { get; set; }

        /// <summary>
        /// 费用
        /// </summary>
        public virtual decimal? CostInt { get; set; }

        /// <summary>
        /// AgeClassInt
        /// </summary>
        [StringLength(300)]
        public virtual string AgeClassInt { get; set; }

        /// <summary>
        /// 封面图
        /// </summary>
        [StringLength(60)]
        public virtual string IconImg { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        [StringLength(1000)]
        public virtual string BTitle { get; set; }

        /// <summary>
        /// 领队id
        /// </summary>
        public virtual string LeaderInt { get; set; }

        /// <summary>
        /// ActivityMessage
        /// </summary>
        public virtual string ActivityMessage { get; set; }

        /// <summary>
        /// 注意事项
        /// </summary>
        [StringLength(4000)]
        public virtual string BeCarefulMessage { get; set; }

        /// <summary>
        /// 退改规则
        /// </summary>
        [StringLength(4000)]
        public virtual string OutActivityMessage { get; set; }

        /// <summary>
        /// 是否直营活动 1是 0否
        /// </summary>
        public virtual int? OneselfClass { get; set; }

        /// <summary>
        /// 是否热门活动 1是 0否
        /// </summary>
        public virtual int? HuoClass { get; set; }

        /// <summary>
        /// TitleIdClass
        /// </summary>
        [StringLength(10)]
        public virtual string TitleIdClass { get; set; }

        /// <summary>
        /// 限时的截止时间
        /// </summary>
        public virtual DateTime? LimitTime { get; set; }

        /// <summary>
        /// 活动图组
        /// </summary>
        [StringLength(1000)]
        public virtual string ImgArray { get; set; }

        /// <summary>
        /// 是否显示 1 显示 0 关闭
        /// </summary>
        public virtual int? IsClose { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime? CreationTime { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public virtual int? SortInt { get; set; }

        /// <summary>
        /// 点赞数量
        /// </summary>
        public virtual int? GoodSum { get; set; }

        /// <summary>
        /// 是否首页推送 1 推送 0 不推送
        /// </summary>
        public virtual int? FirstReState { get; set; }

        /// <summary>
        /// 阅读量
        /// </summary>
        public virtual int? SeeSum { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        public virtual DateTime? ActivityTime { get; set; }

        /// <summary>
        /// 活动地址
        /// </summary>
        [StringLength(300)]
        public virtual string ActivityAddress { get; set; }

        /// <summary>
        /// 评论条数
        /// </summary>
        public virtual int? CommentSum { get; set; }

        /// <summary>
        /// 费用类型 1固定 2 人数
        /// </summary>
        public virtual int? CostIntClass { get; set; }

        /// <summary>
        /// 费用人数是 成人用费
        /// </summary>
        public virtual decimal? AdultCostInt { get; set; }

        /// <summary>
        /// 费用人数时 小孩用费
        /// </summary>
        public virtual decimal? ChildCostInt { get; set; }

        /// <summary>
        /// 总的家庭团队
        /// </summary>
        public virtual int? AllTeamSum { get; set; }

        /// <summary>
        /// 已经有家庭团队
        /// </summary>
        public virtual int? LoginTeamSum { get; set; }

        /// <summary>
        /// BUACMoneyPP
        /// </summary>
        public virtual decimal? BUACMoneyPP { get; set; }

        /// <summary>
        /// WXShowState
        /// </summary>
        public virtual int? WXShowState { get; set; }

        /// <summary>
        /// BuSendActivityId
        /// </summary>
        public virtual string BuSendActivityId { get; set; }

        /// <summary>
        /// WXPriceArray
        /// </summary>
        [StringLength(2000)]
        public virtual string WXPriceArray { get; set; }

        /// <summary>
        /// BuuId
        /// </summary>
        public virtual string BuuId { get; set; }

        /// <summary>
        /// SafeClass
        /// </summary>
        public virtual int? SafeClass { get; set; }

        /// <summary>
        /// SafeMoneyChi
        /// </summary>
        public virtual decimal? SafeMoneyChi { get; set; }

        /// <summary>
        /// SafeMoneyMan
        /// </summary>
        public virtual decimal? SafeMoneyMan { get; set; }

        /// <summary>
        /// IsBillPay
        /// </summary>
        public virtual int? IsBillPay { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        public virtual DateTime? ActivtiyEndTime { get; set; }

        /// <summary>
        /// IntPayLimit
        /// </summary>
        public virtual int? IntPayLimit { get; set; }

        /// <summary>
        /// SendTicketState
        /// </summary>
        public virtual int? SendTicketState { get; set; }

        /// <summary>
        /// 是否开启退票 0可以 1不可以
        /// </summary>
        public virtual int? IsExitOrder { get; set; }

        /// <summary>
        /// 取票提示文字
        /// </summary>
        [StringLength(1000)]
        public virtual string TicketsMessage { get; set; }

        /// <summary>
        /// 是否身份证号 0 不输入 1输入
        /// </summary>
        public virtual int? SendId { get; set; }

        /// <summary>
        /// 砍价最低价位
        /// </summary>
        public virtual decimal? MixPrice { get; set; }

        /// <summary>
        /// 预计砍价人数
        /// </summary>
        public virtual int? ReducePriceUser { get; set; }

        /// <summary>
        /// 砍价活动截止时间
        /// </summary>
        public virtual DateTime? ReducePriceLTime { get; set; }

        /// <summary>
        /// 砍价活动说明
        /// </summary>
        public virtual string ReducePriceMessage { get; set; }

        /// <summary>
        /// 微信地址
        /// </summary>
        [StringLength(500)]
        public virtual string WXAppUrlShow { get; set; }

        /// <summary>
        /// 活动需要砍的次数
        /// </summary>
        [StringLength(1000)]
        public virtual string UserNeedRedu { get; set; }

        /// <summary>
        /// 支付成功显示二维码图
        /// </summary>
        [StringLength(200)]
        public virtual string PlayCQImg { get; set; }

        /// <summary>
        /// 是否替换支持成功的二维码 0 不替换 1 替换
        /// </summary>
        public virtual int? PlayCQImgState { get; set; }

        /// <summary>
        /// 活动内容是否url编码 0未编码 1编码
        /// </summary>
        public virtual int? AcUrlCode { get; set; }

        /// <summary>
        /// 费用结算类型 1定额结算 2定率结算
        /// </summary>
        public virtual int? SettlementClass { get; set; }

        /// <summary>
        /// 结算变量
        /// </summary>
        [StringLength(10)]
        public virtual string SettlementString { get; set; }
    }
}
