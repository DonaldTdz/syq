using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace HC.WeChat.UserInfos.Dtos
{
    public class UserInfoEditDto : EntityDto<Guid?>
    {

        public string OpenId { get; set; }
        /// <summary>
        /// RoleName
        /// </summary>
        public string RoleName { get; set; }


        /// <summary>
        /// Sex
        /// </summary>
        public string Sex { get; set; }


        /// <summary>
        /// Integral
        /// </summary>
        public int? Integral { get; set; }


        /// <summary>
        /// FollowSum
        /// </summary>
        public int? FollowSum { get; set; }


        /// <summary>
        /// FollowedSum
        /// </summary>
        public int? FollowedSum { get; set; }


        /// <summary>
        /// CreateTime
        /// </summary>
        public int? CreateTime { get; set; }


        /// <summary>
        /// NewClass1Sum
        /// </summary>
        public int? NewClass1Sum { get; set; }


        /// <summary>
        /// NewClass2Sum
        /// </summary>
        public int? NewClass2Sum { get; set; }


        /// <summary>
        /// HeardImgName
        /// </summary>
        public string HeardImgName { get; set; }


        /// <summary>
        /// JoinTripSum
        /// </summary>
        public int? JoinTripSum { get; set; }


        /// <summary>
        /// TaskTimeS
        /// </summary>
        public string TaskTimeS { get; set; }


        /// <summary>
        /// CertificatesImgM
        /// </summary>
        public string CertificatesImgM { get; set; }


        /// <summary>
        /// CertificatesImgS
        /// </summary>
        public string CertificatesImgS { get; set; }


        /// <summary>
        /// Birthday
        /// </summary>
        public string Birthday { get; set; }


        /// <summary>
        /// LiveAddress
        /// </summary>
        public string LiveAddress { get; set; }


        /// <summary>
        /// IsExamine
        /// </summary>
        public int? IsExamine { get; set; }


        /// <summary>
        /// ExamineTime
        /// </summary>
        public int? ExamineTime { get; set; }


        /// <summary>
        /// ExchangeTitle
        /// </summary>
        public string ExchangeTitle { get; set; }


        /// <summary>
        /// UpSignTime
        /// </summary>
        public string UpSignTime { get; set; }


        /// <summary>
        /// ContSignSum
        /// </summary>
        public int? ContSignSum { get; set; }


        /// <summary>
        /// SignWeekNum
        /// </summary>
        public int? SignWeekNum { get; set; }


        /// <summary>
        /// ColumnInfo
        /// </summary>
        public string ColumnInfo { get; set; }


        /// <summary>
        /// BodyInfo
        /// </summary>
        public string BodyInfo { get; set; }


        /// <summary>
        /// BodyInfoState
        /// </summary>
        public int? BodyInfoState { get; set; }


        /// <summary>
        /// FirstFollowUserState
        /// </summary>
        public int? FirstFollowUserState { get; set; }


        /// <summary>
        /// PhoneNumber
        /// </summary>
        public string PhoneNumber { get; set; }


        /// <summary>
        /// FromId
        /// </summary>
        public int? FromId { get; set; }


        /// <summary>
        /// HeardImgClass
        /// </summary>
        public int? HeardImgClass { get; set; }


        /// <summary>
        /// InvitationCode
        /// </summary>
        public string InvitationCode { get; set; }


        /// <summary>
        /// LoginInvitationCode
        /// </summary>
        public string LoginInvitationCode { get; set; }


        /// <summary>
        /// ExchangHomeState
        /// </summary>
        public int? ExchangHomeState { get; set; }


        /// <summary>
        /// FirstInvitationFriend
        /// </summary>
        public int? FirstInvitationFriend { get; set; }


        /// <summary>
        /// OnlineTimeLong
        /// </summary>
        public int? OnlineTimeLong { get; set; }


        /// <summary>
        /// CommentSum
        /// </summary>
        public int? CommentSum { get; set; }


        /// <summary>
        /// ShareSum
        /// </summary>
        public int? ShareSum { get; set; }


        /// <summary>
        /// TalkDelTime
        /// </summary>
        public int? TalkDelTime { get; set; }


        /// <summary>
        /// IsLoginState
        /// </summary>
        public int? IsLoginState { get; set; }


        /// <summary>
        /// DeviceToken
        /// </summary>
        public string DeviceToken { get; set; }


        /// <summary>
        /// BuuId
        /// </summary>
        public Guid? BuuId { get; set; }


        /// <summary>
        /// BindBUSum
        /// </summary>
        public int? BindBUSum { get; set; }


        /// <summary>
        /// GetTreeIntDate
        /// </summary>
        public string GetTreeIntDate { get; set; }


        /// <summary>
        /// UserNeedRedu
        /// </summary>
        public string UserNeedRedu { get; set; }






        //// custom codes 

        //// custom codes end
    }
}