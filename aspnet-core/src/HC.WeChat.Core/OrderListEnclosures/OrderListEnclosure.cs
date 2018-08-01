using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using HC.WeChat.WechatEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.WeChat.OrderListEnclosures
{
    /// <summary>
    /// 订单列表附件
    /// </summary>
    [Table("OrderListEnclosures")]
    public class OrderListEnclosure : Entity<Guid>
    {

        /// <summary>
        /// 订单Id
        /// </summary>
        [Required]
        public virtual Guid OrderId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [StringLength(60)]
        public virtual string ChnName { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [StringLength(11)]
        public virtual string Phone { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [StringLength(500)]
        public virtual string Address { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [StringLength(18)]
        public virtual string IdCard { get; set; }

        /// <summary>
        /// 保存其它信息字段
        /// </summary>
        [StringLength(500)]
        public virtual string Remark { get; set; }
    }
}
