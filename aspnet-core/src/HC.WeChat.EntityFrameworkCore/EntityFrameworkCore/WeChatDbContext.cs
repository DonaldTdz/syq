using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HC.WeChat.Authorization.Roles;
using HC.WeChat.Authorization.Users;
using HC.WeChat.MultiTenancy;
using HC.WeChat.WechatAppConfigs;
using HC.WeChat.WechatMessages;
using HC.WeChat.WechatSubscribes;
using HC.WeChat.WeChatUsers;
using HC.WeChat.WeChatGroups;
using HC.WeChat.Orders;
using HC.WeChat.OrderListEnclosures;
using HC.WeChat.UserInfos;

using HC.WeChat.BuSetInfos;
using HC.WeChat.Activities;
using HC.WeChat.Contacts;

namespace HC.WeChat.EntityFrameworkCore
{
    public class WeChatDbContext : AbpZeroDbContext<Tenant, Role, User, WeChatDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public WeChatDbContext(DbContextOptions<WeChatDbContext> options)
            : base(options)
        {
        }


        public virtual DbSet<WechatAppConfig> WechatAppConfigs { get; set; }

        public virtual DbSet<WechatMessage> WechatMessages { get; set; }

        public virtual DbSet<WechatSubscribe> WechatSubscribes { get; set; }

        public virtual DbSet<WeChatUser> WeChatUsers { get; set; }

        public virtual DbSet<WeChatGroup> WeChatGroups { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderListEnclosure> OrderListEnclosures { get; set; }
        public virtual DbSet<UserInfo> UserInfos { get; set; }
        public virtual DbSet<Activity> Activitys { get; set; }
        public virtual DbSet<BuSetInfo> BuSetInfos { get; set; }

        public virtual DbSet<Contact> Contacts { get; set; }
    }
}
