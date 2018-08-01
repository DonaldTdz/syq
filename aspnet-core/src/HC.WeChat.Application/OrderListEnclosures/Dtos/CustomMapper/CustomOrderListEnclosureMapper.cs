using AutoMapper;
using HC.WeChat.OrderListEnclosures;
using HC.WeChat.OrderListEnclosures;

namespace HC.WeChat.OrderListEnclosures.Dtos
{

	/// <summary>
	/// 配置OrderListEnclosure的AutoMapper
	/// </summary>
	internal static class CustomerOrderListEnclosureMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <OrderListEnclosure, OrderListEnclosureListDto>();
            configuration.CreateMap <OrderListEnclosureEditDto, OrderListEnclosure>();
		
		    
			
		    //// custom codes 
		    
            //// custom codes end

        }
    }
}