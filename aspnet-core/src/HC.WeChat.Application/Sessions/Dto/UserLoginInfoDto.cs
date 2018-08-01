﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using HC.WeChat.Authorization.Users;

namespace HC.WeChat.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public int NotifyCount { get; set; }
    }
}
