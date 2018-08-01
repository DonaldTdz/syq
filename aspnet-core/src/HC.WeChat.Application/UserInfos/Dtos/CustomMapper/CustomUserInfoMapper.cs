using AutoMapper;
using HC.WeChat.UserInfos;
using HC.WeChat.UserInfos;

namespace HC.WeChat.UserInfos.Dtos
{

	/// <summary>
	/// 配置UserInfo的AutoMapper
	/// </summary>
	internal static class CustomerUserInfoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <UserInfo, UserInfoListDto>();
            configuration.CreateMap <UserInfoEditDto, UserInfo>();
		
		    
			
		    //// custom codes 
		    
            //// custom codes end

        }
    }
}