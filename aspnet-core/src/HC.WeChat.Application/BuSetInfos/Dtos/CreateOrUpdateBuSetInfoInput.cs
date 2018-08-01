using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HC.WeChat.BuSetInfos;

namespace HC.WeChat.BuSetInfos.Dtos
{
    public class CreateOrUpdateBuSetInfoInput
    {
        [Required]
        public BuSetInfoEditDto BuSetInfo { get; set; }


		
		//// custom codes 
		
        //// custom codes end
    }
}