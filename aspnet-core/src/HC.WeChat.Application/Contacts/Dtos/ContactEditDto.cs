
using System;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using HC.WeChat.Contacts;

namespace  HC.WeChat.Contacts.Dtos
{
    [AutoMapTo(typeof(Contact))]
    public class ContactEditDto
    {

        /// <summary>
        /// Id
        /// </summary>
        public int? Id { get; set; }         


        
		/// <summary>
		/// Name
		/// </summary>
		public string Name { get; set; }



		/// <summary>
		/// Email
		/// </summary>
		public string Email { get; set; }



		/// <summary>
		/// Phone
		/// </summary>
		public string Phone { get; set; }



		/// <summary>
		/// Area
		/// </summary>
		public string Area { get; set; }



		/// <summary>
		/// Message
		/// </summary>
		public string Message { get; set; }



		/// <summary>
		/// CreationTime
		/// </summary>
		public DateTime? CreationTime { get; set; }




    }
}