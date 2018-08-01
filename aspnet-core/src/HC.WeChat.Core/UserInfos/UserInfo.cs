using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using HC.WeChat.WechatEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.WeChat.UserInfos
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    [Table("UserInfos")]
    public class UserInfo : Entity<Guid>
    {

        /// <summary>
        /// 昵称
        /// </summary>
        [StringLength(150)]
        public virtual string RoleName { get; set; }

        public virtual string OpenId { get; set; }

        /// <summary>
        /// 性别 1男 0女
        /// </summary>
        [StringLength(1)]
        public virtual string Sex { get; set; }

        /// <summary>
        /// Integral
        /// </summary>
        public virtual int? Integral { get; set; }

        /// <summary>
        /// 关注人
        /// </summary>
        public virtual int? FollowSum { get; set; }

        /// <summary>
        /// 被关注
        /// </summary>
        public virtual int? FollowedSum { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>
        public virtual int? CreateTime { get; set; }

        /// <summary>
        /// 野游记条数
        /// </summary>
        public virtual int? NewClass1Sum { get; set; }

        /// <summary>
        /// 趣活记条数
        /// </summary>
        public virtual int? NewClass2Sum { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [StringLength(250)]
        public virtual string HeardImgName { get; set; }

        /// <summary>
        /// 参加旅行次数
        /// </summary>
        public virtual int? JoinTripSum { get; set; }

        /// <summary>
        /// 已经存在订单时间段
        /// </summary>
        [StringLength(1000)]
        public virtual string TaskTimeS { get; set; }

        /// <summary>
        /// 证件照正面
        /// </summary>
        [StringLength(100)]
        public virtual string CertificatesImgM { get; set; }

        /// <summary>
        /// 证件照背面
        /// </summary>
        [StringLength(100)]
        public virtual string CertificatesImgS { get; set; }

        /// <summary>
        /// 出生
        /// </summary>
        [StringLength(100)]
        public virtual string Birthday { get; set; }

        /// <summary>
        /// 居住地
        /// </summary>
        [StringLength(300)]
        public virtual string LiveAddress { get; set; }

        /// <summary>
        /// 是否审核过:0未提交审核 1审核 2未审核 3未通过
        /// </summary>
        public virtual int? IsExamine { get; set; }

        /// <summary>
        /// 提交审核时间
        /// </summary>
        public virtual int? ExamineTime { get; set; }

        /// <summary>
        /// 交换房标题
        /// </summary>
        [StringLength(200)]
        public virtual string ExchangeTitle { get; set; }

        /// <summary>
        /// 上次签到时间
        /// </summary>
        [StringLength(20)]
        public virtual string UpSignTime { get; set; }

        /// <summary>
        /// 本周签到数
        /// </summary>
        public virtual int? ContSignSum { get; set; }

        /// <summary>
        /// 签到周数
        /// </summary>
        public virtual int? SignWeekNum { get; set; }

        /// <summary>
        /// 自定义首页图标
        /// </summary>
        [StringLength(300)]
        public virtual string ColumnInfo { get; set; }

        /// <summary>
        /// 宝宝信息
        /// </summary>
        [StringLength(2000)]
        public virtual string BodyInfo { get; set; }

        /// <summary>
        /// 宝宝信息是否完整 0否 1是
        /// </summary>
        public virtual int? BodyInfoState { get; set; }

        /// <summary>
        /// 是否已经关注过人 0否 1是
        /// </summary>
        public virtual int? FirstFollowUserState { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [StringLength(11)]
        public virtual string PhoneNumber { get; set; }

        /// <summary>
        /// 来源 0自己平台 1 微信 2 qq
        /// </summary>
        public virtual int? FromId { get; set; }

        /// <summary>
        /// 头像的来源 0 自己资源 1 微信资源 2 qq资源
        /// </summary>
        public virtual int? HeardImgClass { get; set; }

        /// <summary>
        /// 自己邀请码
        /// </summary>
        [StringLength(20)]
        public virtual string InvitationCode { get; set; }

        /// <summary>
        /// 被邀请码
        /// </summary>
        [StringLength(20)]
        public virtual string LoginInvitationCode { get; set; }

        /// <summary>
        /// 交换屋是否开启 0 开启 1关闭
        /// </summary>
        public virtual int? ExchangHomeState { get; set; }

        /// <summary>
        /// 是否完成首次邀约了朋友 0 否 1 完成
        /// </summary>
        public virtual int? FirstInvitationFriend { get; set; }

        /// <summary>
        /// 在线时间 单位秒
        /// </summary>
        public virtual int? OnlineTimeLong { get; set; }

        /// <summary>
        /// 评论数量
        /// </summary>
        public virtual int? CommentSum { get; set; }

        /// <summary>
        /// 分享总数量
        /// </summary>
        public virtual int? ShareSum { get; set; }

        /// <summary>
        /// TalkDelTime
        /// </summary>
        public virtual int? TalkDelTime { get; set; }

        /// <summary>
        /// 是不是允许登入 1 允许 0 禁止
        /// </summary>
        public virtual int? IsLoginState { get; set; }

        /// <summary>
        /// DeviceToken
        /// </summary>
        [StringLength(200)]
        public virtual string DeviceToken { get; set; }

        /// <summary>
        /// BuuId
        /// </summary>
        public virtual string BuuId { get; set; }

        /// <summary>
        /// BindBUSum
        /// </summary>
        public virtual int? BindBUSum { get; set; }

        /// <summary>
        /// GetTreeIntDate
        /// </summary>
        [StringLength(100)]
        public virtual string GetTreeIntDate { get; set; }

        /// <summary>
        /// 活动需要砍的次数
        /// </summary>
        [StringLength(1000)]
        public virtual string UserNeedRedu { get; set; }
    }
}
