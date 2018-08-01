using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HC.WeChat.Roles.Dto;
using HC.WeChat.Users.Dto;
using HC.WeChat.Authorization.Users;

namespace HC.WeChat.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        /// <summary>
        /// �޸�����
        /// </summary>
        /// <param name="password">������</param>
        /// <returns></returns>
        Task UpdatePassword(string password);

        /// <summary>
        /// ��������ԭ���������ݿ��������Ƿ����
        /// </summary>
        /// <returns></returns>
        Task<bool> CheckOldPassword(string oldPassword);
    }
}
