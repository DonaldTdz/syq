using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HC.WeChat.Activities;

namespace HC.WeChat.Activities.Dtos
{
    public class CreateOrUpdateActivityInput
    {
        [Required]
        public ActivityEditDto Activity { get; set; }


		
		//// custom codes 
		
        //// custom codes end
    }
}