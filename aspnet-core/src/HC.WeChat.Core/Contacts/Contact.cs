using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HC.WeChat.Contacts
{
    [Table("Contacts")]
    public class Contact : Entity , IHasCreationTime
    {
        [StringLength(50)]
        public virtual string Name { get; set; }

        [StringLength(200)]
        public virtual string Email { get; set; }

        [StringLength(20)]
        public virtual string Phone { get; set; }

        [StringLength(200)]
        public virtual string Area { get; set; }

        [StringLength(500)]
        public virtual string Message { get; set; }

        public virtual DateTime CreationTime { get; set; }

    }
}
