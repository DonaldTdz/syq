using System;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace HC.WeChat.BuSetInfos.Dtos
{
    public class BuSetInfoEditDto : EntityDto<Guid?>
    {
        /// <summary>
        /// BuName
        /// </summary>
        public string BuName { get; set; }


        /// <summary>
        /// Phone
        /// </summary>
        public string Phone { get; set; }


        /// <summary>
        /// ContactsName
        /// </summary>
        public string ContactsName { get; set; }


        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }


        /// <summary>
        /// CreationTime
        /// </summary>
        public DateTime? CreationTime { get; set; }






        //// custom codes 

        //// custom codes end
    }
}