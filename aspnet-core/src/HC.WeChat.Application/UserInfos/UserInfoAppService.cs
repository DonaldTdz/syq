using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.Linq;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;

using System.Linq.Dynamic.Core;
 using Microsoft.EntityFrameworkCore; 
using HC.WeChat.UserInfos.Authorization;
using HC.WeChat.UserInfos.DomainServices;
using HC.WeChat.UserInfos.Dtos;
using System;
using HC.WeChat.Authorization;

namespace HC.WeChat.UserInfos
{
    /// <summary>
    /// UserInfo应用层服务的接口实现方法
    /// </summary>
    //[AbpAuthorize(UserInfoAppPermissions.UserInfo)]
    [AbpAuthorize(AppPermissions.Pages)]
    public class UserInfoAppService : WeChatAppServiceBase, IUserInfoAppService
    {
		private readonly IRepository<UserInfo, Guid> _userinfoRepository;

		private readonly IUserInfoManager _userinfoManager;
		
		/// <summary>
		/// 构造函数
		/// </summary>
		public UserInfoAppService(
			IRepository<UserInfo, Guid> userinfoRepository
			,IUserInfoManager userinfoManager
		)
		{
			_userinfoRepository = userinfoRepository;
			 _userinfoManager=userinfoManager;
		}
		
		
		/// <summary>
		/// 获取UserInfo的分页列表信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public  async  Task<PagedResultDto<UserInfoListDto>> GetPagedUserInfos(GetUserInfosInput input)
		{
		    
		    var query = _userinfoRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
		
			var userinfoCount = await query.CountAsync();
		
			var userinfos = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();
		
				// var userinfoListDtos = ObjectMapper.Map<List <UserInfoListDto>>(userinfos);
				var userinfoListDtos =userinfos.MapTo<List<UserInfoListDto>>();
		
				return new PagedResultDto<UserInfoListDto>(
							userinfoCount,
							userinfoListDtos
					);
		}
		

		/// <summary>
		/// 通过指定id获取UserInfoListDto信息
		/// </summary>
		public async Task<UserInfoListDto> GetUserInfoByIdAsync(EntityDto<Guid> input)
		{
			var entity = await _userinfoRepository.GetAsync(input.Id);
		
		    return entity.MapTo<UserInfoListDto>();
		}
		
		/// <summary>
		/// MPA版本才会用到的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async  Task<GetUserInfoForEditOutput> GetUserInfoForEdit(NullableIdDto<Guid> input)
		{
			var output = new GetUserInfoForEditOutput();
			UserInfoEditDto userinfoEditDto;
		
			if (input.Id.HasValue)
			{
				var entity = await _userinfoRepository.GetAsync(input.Id.Value);
		
				userinfoEditDto = entity.MapTo<UserInfoEditDto>();
		
				//userinfoEditDto = ObjectMapper.Map<List <userinfoEditDto>>(entity);
			}
			else
			{
				userinfoEditDto = new UserInfoEditDto();
			}
		
			output.UserInfo = userinfoEditDto;
			return output;
		}
		
		
		/// <summary>
		/// 添加或者修改UserInfo的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task CreateOrUpdateUserInfo(CreateOrUpdateUserInfoInput input)
		{
		    
			if (input.UserInfo.Id.HasValue)
			{
				await UpdateUserInfoAsync(input.UserInfo);
			}
			else
			{
				await CreateUserInfoAsync(input.UserInfo);
			}
		}
		

		/// <summary>
		/// 新增UserInfo
		/// </summary>
		[AbpAuthorize(UserInfoAppPermissions.UserInfo_CreateUserInfo)]
		protected virtual async Task<UserInfoEditDto> CreateUserInfoAsync(UserInfoEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增
		
			var entity = ObjectMapper.Map <UserInfo>(input);
		
			entity = await _userinfoRepository.InsertAsync(entity);
			return entity.MapTo<UserInfoEditDto>();
		}
		
		/// <summary>
		/// 编辑UserInfo
		/// </summary>
		[AbpAuthorize(UserInfoAppPermissions.UserInfo_EditUserInfo)]
		protected virtual async Task UpdateUserInfoAsync(UserInfoEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新
		
			var entity = await _userinfoRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);
		
			// ObjectMapper.Map(input, entity);
		    await _userinfoRepository.UpdateAsync(entity);
		}
		

		
		/// <summary>
		/// 删除UserInfo信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(UserInfoAppPermissions.UserInfo_DeleteUserInfo)]
		public async Task DeleteUserInfo(EntityDto<Guid> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _userinfoRepository.DeleteAsync(input.Id);
		}
		
		
		
		/// <summary>
		/// 批量删除UserInfo的方法
		/// </summary>
		[AbpAuthorize(UserInfoAppPermissions.UserInfo_BatchDeleteUserInfos)]
		public async Task BatchDeleteUserInfosAsync(List<Guid> input)
		{
			//TODO:批量删除前的逻辑判断，是否允许删除
			await _userinfoRepository.DeleteAsync(s => input.Contains(s.Id));
		}

    }
}


 