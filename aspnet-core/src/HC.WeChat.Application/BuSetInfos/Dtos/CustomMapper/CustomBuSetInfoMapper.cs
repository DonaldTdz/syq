using AutoMapper;
using HC.WeChat.BuSetInfos;
using HC.WeChat.BuSetInfos;

namespace HC.WeChat.BuSetInfos.Dtos
{

	/// <summary>
	/// 配置BuSetInfo的AutoMapper
	/// </summary>
	internal static class CustomerBuSetInfoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <BuSetInfo, BuSetInfoListDto>();
            configuration.CreateMap <BuSetInfoEditDto, BuSetInfo>();
		
		    
			
		    //// custom codes 
		    
            //// custom codes end

        }
    }
}