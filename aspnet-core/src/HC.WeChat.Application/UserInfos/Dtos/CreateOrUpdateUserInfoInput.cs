using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HC.WeChat.UserInfos;

namespace HC.WeChat.UserInfos.Dtos
{
    public class CreateOrUpdateUserInfoInput
    {
        [Required]
        public UserInfoEditDto UserInfo { get; set; }


		
		//// custom codes 
		
        //// custom codes end
    }
}