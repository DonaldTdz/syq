using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace HC.WeChat.OrderListEnclosures.Dtos
{
    public class OrderListEnclosureEditDto : EntityDto<Guid?>
    {
        /// <summary>
        /// OrderId
        /// </summary>
        [Required(ErrorMessage = "OrderId不能为空")]
        public Guid OrderId { get; set; }


        /// <summary>
        /// ChnName
        /// </summary>
        public string ChnName { get; set; }


        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// IdCard
        /// </summary>
        public string IdCard { get; set; }


        /// <summary>
        /// Remark
        /// </summary>
        public string Remark { get; set; }






        //// custom codes 

        //// custom codes end
    }
}