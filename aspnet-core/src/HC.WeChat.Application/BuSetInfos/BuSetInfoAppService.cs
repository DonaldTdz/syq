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
using HC.WeChat.BuSetInfos.Authorization;
using HC.WeChat.BuSetInfos.DomainServices;
using HC.WeChat.BuSetInfos.Dtos;
using System;
using HC.WeChat.Authorization;

namespace HC.WeChat.BuSetInfos
{
    /// <summary>
    /// BuSetInfo应用层服务的接口实现方法
    /// </summary>
    //[AbpAuthorize(BuSetInfoAppPermissions.BuSetInfo)]
    [AbpAuthorize(AppPermissions.Pages)]
    public class BuSetInfoAppService : WeChatAppServiceBase, IBuSetInfoAppService
    {
		private readonly IRepository<BuSetInfo, Guid> _busetinfoRepository;

		private readonly IBuSetInfoManager _busetinfoManager;
		
		/// <summary>
		/// 构造函数
		/// </summary>
		public BuSetInfoAppService(
			IRepository<BuSetInfo, Guid> busetinfoRepository
			,IBuSetInfoManager busetinfoManager
		)
		{
			_busetinfoRepository = busetinfoRepository;
			 _busetinfoManager=busetinfoManager;
		}
		
		
		/// <summary>
		/// 获取BuSetInfo的分页列表信息
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public  async  Task<PagedResultDto<BuSetInfoListDto>> GetPagedBuSetInfos(GetBuSetInfosInput input)
		{
		    
		    var query = _busetinfoRepository.GetAll();
			// TODO:根据传入的参数添加过滤条件
		
			var busetinfoCount = await query.CountAsync();
		
			var busetinfos = await query
					.OrderBy(input.Sorting).AsNoTracking()
					.PageBy(input)
					.ToListAsync();
		
				// var busetinfoListDtos = ObjectMapper.Map<List <BuSetInfoListDto>>(busetinfos);
				var busetinfoListDtos =busetinfos.MapTo<List<BuSetInfoListDto>>();
		
				return new PagedResultDto<BuSetInfoListDto>(
							busetinfoCount,
							busetinfoListDtos
					);
		}
		

		/// <summary>
		/// 通过指定id获取BuSetInfoListDto信息
		/// </summary>
		public async Task<BuSetInfoListDto> GetBuSetInfoByIdAsync(EntityDto<Guid> input)
		{
			var entity = await _busetinfoRepository.GetAsync(input.Id);
		
		    return entity.MapTo<BuSetInfoListDto>();
		}
		
		/// <summary>
		/// MPA版本才会用到的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async  Task<GetBuSetInfoForEditOutput> GetBuSetInfoForEdit(NullableIdDto<Guid> input)
		{
			var output = new GetBuSetInfoForEditOutput();
			BuSetInfoEditDto busetinfoEditDto;
		
			if (input.Id.HasValue)
			{
				var entity = await _busetinfoRepository.GetAsync(input.Id.Value);
		
				busetinfoEditDto = entity.MapTo<BuSetInfoEditDto>();
		
				//busetinfoEditDto = ObjectMapper.Map<List <busetinfoEditDto>>(entity);
			}
			else
			{
				busetinfoEditDto = new BuSetInfoEditDto();
			}
		
			output.BuSetInfo = busetinfoEditDto;
			return output;
		}
		
		
		/// <summary>
		/// 添加或者修改BuSetInfo的公共方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public async Task CreateOrUpdateBuSetInfo(CreateOrUpdateBuSetInfoInput input)
		{
		    
			if (input.BuSetInfo.Id.HasValue)
			{
				await UpdateBuSetInfoAsync(input.BuSetInfo);
			}
			else
			{
				await CreateBuSetInfoAsync(input.BuSetInfo);
			}
		}
		

		/// <summary>
		/// 新增BuSetInfo
		/// </summary>
		[AbpAuthorize(BuSetInfoAppPermissions.BuSetInfo_CreateBuSetInfo)]
		protected virtual async Task<BuSetInfoEditDto> CreateBuSetInfoAsync(BuSetInfoEditDto input)
		{
			//TODO:新增前的逻辑判断，是否允许新增
		
			var entity = ObjectMapper.Map <BuSetInfo>(input);
		
			entity = await _busetinfoRepository.InsertAsync(entity);
			return entity.MapTo<BuSetInfoEditDto>();
		}
		
		/// <summary>
		/// 编辑BuSetInfo
		/// </summary>
		[AbpAuthorize(BuSetInfoAppPermissions.BuSetInfo_EditBuSetInfo)]
		protected virtual async Task UpdateBuSetInfoAsync(BuSetInfoEditDto input)
		{
			//TODO:更新前的逻辑判断，是否允许更新
		
			var entity = await _busetinfoRepository.GetAsync(input.Id.Value);
			input.MapTo(entity);
		
			// ObjectMapper.Map(input, entity);
		    await _busetinfoRepository.UpdateAsync(entity);
		}
		

		
		/// <summary>
		/// 删除BuSetInfo信息的方法
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		[AbpAuthorize(BuSetInfoAppPermissions.BuSetInfo_DeleteBuSetInfo)]
		public async Task DeleteBuSetInfo(EntityDto<Guid> input)
		{
			//TODO:删除前的逻辑判断，是否允许删除
			await _busetinfoRepository.DeleteAsync(input.Id);
		}
		
		
		
		/// <summary>
		/// 批量删除BuSetInfo的方法
		/// </summary>
		[AbpAuthorize(BuSetInfoAppPermissions.BuSetInfo_BatchDeleteBuSetInfos)]
		public async Task BatchDeleteBuSetInfosAsync(List<Guid> input)
		{
			//TODO:批量删除前的逻辑判断，是否允许删除
			await _busetinfoRepository.DeleteAsync(s => input.Contains(s.Id));
		}


		/// <summary>
		/// 导出BuSetInfo为excel表
		/// </summary>
		/// <returns></returns>
		//public async Task<FileDto> GetBuSetInfosToExcel()
		//{
		//	var users = await UserManager.Users.ToListAsync();
		//	var userListDtos = ObjectMapper.Map<List<UserListDto>>(users);
		//	await FillRoleNames(userListDtos);
		//	return _userListExcelExporter.ExportToFile(userListDtos);
		//}


		
		//// custom codes 
		
        //// custom codes end

    }
}


 