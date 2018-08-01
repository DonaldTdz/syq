using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HC.WeChat.OrderListEnclosures;

namespace HC.WeChat.OrderListEnclosures.Dtos
{
    public class CreateOrUpdateOrderListEnclosureInput
    {
        [Required]
        public OrderListEnclosureEditDto OrderListEnclosure { get; set; }


		
		//// custom codes 
		
        //// custom codes end
    }
}