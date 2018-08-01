using System.ComponentModel.DataAnnotations;

namespace HC.WeChat.Orders.Dtos
{
    public class CreateOrUpdateOrderInput
    {
        [Required]
        public OrderEditDto Order { get; set; }


		
		//// custom codes 
		
        //// custom codes end
    }
}