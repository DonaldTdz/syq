
using AutoMapper;
using HC.WeChat.Contacts;
using HC.WeChat.Contacts.Dtos;

namespace HC.WeChat.Contacts.Mapper
{

	/// <summary>
    /// 配置Contact的AutoMapper
    /// </summary>
	internal static class ContactMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap <Contact,ContactListDto>();
            configuration.CreateMap <ContactListDto,Contact>();

            configuration.CreateMap <ContactEditDto,Contact>();
            configuration.CreateMap <Contact,ContactEditDto>();

        }
	}
}
