using AutoMapper;
using HC.WeChat.Activities;
using HC.WeChat.Activities;

namespace HC.WeChat.Activities.Dtos
{

	/// <summary>
	/// 配置Activity的AutoMapper
	/// </summary>
	internal static class CustomerActivityMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Activity, ActivityListDto>();
            configuration.CreateMap <ActivityEditDto, Activity>();
		
		    
			
		    //// custom codes 
		    
            //// custom codes end

        }
    }
}