using AutoMapper;

namespace HC.WeChat.Orders.Dtos
{

    /// <summary>
    /// 配置Order的AutoMapper
    /// </summary>
    internal static class CustomerOrderMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Order, OrderListDto>();
            configuration.CreateMap <OrderEditDto, Order>();
		
		    
			
		    //// custom codes 
		    
            //// custom codes end

        }
    }
}