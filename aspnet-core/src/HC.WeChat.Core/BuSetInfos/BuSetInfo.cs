using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using HC.WeChat.WechatEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.WeChat.BuSetInfos
{
    /// <summary>
    /// 商家表
    /// </summary>
    [Table("BuSetInfos")]
    public class BuSetInfo : Entity<Guid>
    {

        /// <summary>
        /// 商家名称
        /// </summary>
        [StringLength(150)]
        public virtual string BuName { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [StringLength(11)]
        public virtual string Phone { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [StringLength(20)]
        public virtual string ContactsName { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [StringLength(150)]
        public virtual string Address { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime? CreationTime { get; set; }
    }
}
