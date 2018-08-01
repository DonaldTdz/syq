﻿using HC.WeChat.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;


namespace HC.WeChat.Migrations
{
    [DbContext(typeof(WeChatDbContext))]
    [Migration("201807181130_SYQ_BLLTable")]
    partial class SYQ_BLLTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Abp.Application.Editions.Edition", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasMaxLength(64);

                b.Property<bool>("IsDeleted");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(32);

                b.HasKey("Id");

                b.ToTable("AbpEditions");
            });

            modelBuilder.Entity("Abp.Application.Features.FeatureSetting", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("Discriminator")
                    .IsRequired();

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<int?>("TenantId");

                b.Property<string>("Value")
                    .IsRequired()
                    .HasMaxLength(2000);

                b.HasKey("Id");

                b.ToTable("AbpFeatures");

                b.HasDiscriminator<string>("Discriminator").HasValue("FeatureSetting");
            });

            modelBuilder.Entity("Abp.Auditing.AuditLog", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("BrowserInfo")
                    .HasMaxLength(256);

                b.Property<string>("ClientIpAddress")
                    .HasMaxLength(64);

                b.Property<string>("ClientName")
                    .HasMaxLength(128);

                b.Property<string>("CustomData")
                    .HasMaxLength(2000);

                b.Property<string>("Exception")
                    .HasMaxLength(2000);

                b.Property<int>("ExecutionDuration");

                b.Property<DateTime>("ExecutionTime");

                b.Property<int?>("ImpersonatorTenantId");

                b.Property<long?>("ImpersonatorUserId");

                b.Property<string>("MethodName")
                    .HasMaxLength(256);

                b.Property<string>("Parameters")
                    .HasMaxLength(1024);

                b.Property<string>("ServiceName")
                    .HasMaxLength(256);

                b.Property<int?>("TenantId");

                b.Property<long?>("UserId");

                b.HasKey("Id");

                b.HasIndex("TenantId", "ExecutionDuration");

                b.HasIndex("TenantId", "ExecutionTime");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AbpAuditLogs");
            });

            modelBuilder.Entity("Abp.Authorization.PermissionSetting", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("Discriminator")
                    .IsRequired();

                b.Property<bool>("IsGranted");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("TenantId", "Name");

                b.ToTable("AbpPermissions");

                b.HasDiscriminator<string>("Discriminator").HasValue("PermissionSetting");
            });

            modelBuilder.Entity("Abp.Authorization.Roles.RoleClaim", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("ClaimType")
                    .HasMaxLength(256);

                b.Property<string>("ClaimValue");

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<int>("RoleId");

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("RoleId");

                b.HasIndex("TenantId", "ClaimType");

                b.ToTable("AbpRoleClaims");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserAccount", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("EmailAddress")
                    .HasMaxLength(256);

                b.Property<bool>("IsDeleted");

                b.Property<DateTime?>("LastLoginTime");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.Property<long?>("UserLinkId");

                b.Property<string>("UserName")
                    .HasMaxLength(32);

                b.HasKey("Id");

                b.HasIndex("EmailAddress");

                b.HasIndex("UserName");

                b.HasIndex("TenantId", "EmailAddress");

                b.HasIndex("TenantId", "UserId");

                b.HasIndex("TenantId", "UserName");

                b.ToTable("AbpUserAccounts");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserClaim", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("ClaimType")
                    .HasMaxLength(256);

                b.Property<string>("ClaimValue");

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("TenantId", "ClaimType");

                b.ToTable("AbpUserClaims");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserLogin", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("LoginProvider")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<string>("ProviderKey")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("TenantId", "UserId");

                b.HasIndex("TenantId", "LoginProvider", "ProviderKey");

                b.ToTable("AbpUserLogins");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserLoginAttempt", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("BrowserInfo")
                    .HasMaxLength(256);

                b.Property<string>("ClientIpAddress")
                    .HasMaxLength(64);

                b.Property<string>("ClientName")
                    .HasMaxLength(128);

                b.Property<DateTime>("CreationTime");

                b.Property<byte>("Result");

                b.Property<string>("TenancyName")
                    .HasMaxLength(64);

                b.Property<int?>("TenantId");

                b.Property<long?>("UserId");

                b.Property<string>("UserNameOrEmailAddress")
                    .HasMaxLength(255);

                b.HasKey("Id");

                b.HasIndex("UserId", "TenantId");

                b.HasIndex("TenancyName", "UserNameOrEmailAddress", "Result");

                b.ToTable("AbpUserLoginAttempts");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserOrganizationUnit", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<bool>("IsDeleted");

                b.Property<long>("OrganizationUnitId");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("TenantId", "OrganizationUnitId");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AbpUserOrganizationUnits");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserRole", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<int>("RoleId");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("TenantId", "RoleId");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AbpUserRoles");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserToken", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("LoginProvider");

                b.Property<string>("Name");

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.Property<string>("Value");

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AbpUserTokens");
            });

            modelBuilder.Entity("Abp.BackgroundJobs.BackgroundJobInfo", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<bool>("IsAbandoned");

                b.Property<string>("JobArgs")
                    .IsRequired()
                    .HasMaxLength(1048576);

                b.Property<string>("JobType")
                    .IsRequired()
                    .HasMaxLength(512);

                b.Property<DateTime?>("LastTryTime");

                b.Property<DateTime>("NextTryTime");

                b.Property<byte>("Priority");

                b.Property<short>("TryCount");

                b.HasKey("Id");

                b.HasIndex("IsAbandoned", "NextTryTime");

                b.ToTable("AbpBackgroundJobs");
            });

            modelBuilder.Entity("Abp.Configuration.Setting", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<int?>("TenantId");

                b.Property<long?>("UserId");

                b.Property<string>("Value")
                    .HasMaxLength(2000);

                b.HasKey("Id");

                b.HasIndex("UserId");

                b.HasIndex("TenantId", "Name");

                b.ToTable("AbpSettings");
            });

            modelBuilder.Entity("Abp.EntityHistory.EntityChange", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("ChangeTime");

                b.Property<byte>("ChangeType");

                b.Property<long>("EntityChangeSetId");

                b.Property<string>("EntityId")
                    .HasMaxLength(48);

                b.Property<string>("EntityTypeFullName")
                    .HasMaxLength(192);

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("EntityChangeSetId");

                b.HasIndex("EntityTypeFullName", "EntityId");

                b.ToTable("AbpEntityChanges");
            });

            modelBuilder.Entity("Abp.EntityHistory.EntityChangeSet", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("BrowserInfo")
                    .HasMaxLength(256);

                b.Property<string>("ClientIpAddress")
                    .HasMaxLength(64);

                b.Property<string>("ClientName")
                    .HasMaxLength(128);

                b.Property<DateTime>("CreationTime");

                b.Property<string>("ExtensionData");

                b.Property<int?>("ImpersonatorTenantId");

                b.Property<long?>("ImpersonatorUserId");

                b.Property<string>("Reason")
                    .HasMaxLength(256);

                b.Property<int?>("TenantId");

                b.Property<long?>("UserId");

                b.HasKey("Id");

                b.HasIndex("TenantId", "CreationTime");

                b.HasIndex("TenantId", "Reason");

                b.HasIndex("TenantId", "UserId");

                b.ToTable("AbpEntityChangeSets");
            });

            modelBuilder.Entity("Abp.EntityHistory.EntityPropertyChange", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<long>("EntityChangeId");

                b.Property<string>("NewValue")
                    .HasMaxLength(512);

                b.Property<string>("OriginalValue")
                    .HasMaxLength(512);

                b.Property<string>("PropertyName")
                    .HasMaxLength(96);

                b.Property<string>("PropertyTypeFullName")
                    .HasMaxLength(192);

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("EntityChangeId");

                b.ToTable("AbpEntityPropertyChanges");
            });

            modelBuilder.Entity("Abp.Localization.ApplicationLanguage", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasMaxLength(64);

                b.Property<string>("Icon")
                    .HasMaxLength(128);

                b.Property<bool>("IsDeleted");

                b.Property<bool>("IsDisabled");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(10);

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("TenantId", "Name");

                b.ToTable("AbpLanguages");
            });

            modelBuilder.Entity("Abp.Localization.ApplicationLanguageText", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("Key")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<string>("LanguageName")
                    .IsRequired()
                    .HasMaxLength(10);

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Source")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<int?>("TenantId");

                b.Property<string>("Value")
                    .IsRequired()
                    .HasMaxLength(67108864);

                b.HasKey("Id");

                b.HasIndex("TenantId", "Source", "LanguageName", "Key");

                b.ToTable("AbpLanguageTexts");
            });

            modelBuilder.Entity("Abp.Notifications.NotificationInfo", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("Data")
                    .HasMaxLength(1048576);

                b.Property<string>("DataTypeName")
                    .HasMaxLength(512);

                b.Property<string>("EntityId")
                    .HasMaxLength(96);

                b.Property<string>("EntityTypeAssemblyQualifiedName")
                    .HasMaxLength(512);

                b.Property<string>("EntityTypeName")
                    .HasMaxLength(250);

                b.Property<string>("ExcludedUserIds")
                    .HasMaxLength(131072);

                b.Property<string>("NotificationName")
                    .IsRequired()
                    .HasMaxLength(96);

                b.Property<byte>("Severity");

                b.Property<string>("TenantIds")
                    .HasMaxLength(131072);

                b.Property<string>("UserIds")
                    .HasMaxLength(131072);

                b.HasKey("Id");

                b.ToTable("AbpNotifications");
            });

            modelBuilder.Entity("Abp.Notifications.NotificationSubscriptionInfo", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("EntityId")
                    .HasMaxLength(96);

                b.Property<string>("EntityTypeAssemblyQualifiedName")
                    .HasMaxLength(512);

                b.Property<string>("EntityTypeName")
                    .HasMaxLength(250);

                b.Property<string>("NotificationName")
                    .HasMaxLength(96);

                b.Property<int?>("TenantId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("NotificationName", "EntityTypeName", "EntityId", "UserId");

                b.HasIndex("TenantId", "NotificationName", "EntityTypeName", "EntityId", "UserId");

                b.ToTable("AbpNotificationSubscriptions");
            });

            modelBuilder.Entity("Abp.Notifications.TenantNotificationInfo", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<string>("Data")
                    .HasMaxLength(1048576);

                b.Property<string>("DataTypeName")
                    .HasMaxLength(512);

                b.Property<string>("EntityId")
                    .HasMaxLength(96);

                b.Property<string>("EntityTypeAssemblyQualifiedName")
                    .HasMaxLength(512);

                b.Property<string>("EntityTypeName")
                    .HasMaxLength(250);

                b.Property<string>("NotificationName")
                    .IsRequired()
                    .HasMaxLength(96);

                b.Property<byte>("Severity");

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("TenantId");

                b.ToTable("AbpTenantNotifications");
            });

            modelBuilder.Entity("Abp.Notifications.UserNotificationInfo", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<DateTime>("CreationTime");

                b.Property<int>("State");

                b.Property<int?>("TenantId");

                b.Property<Guid>("TenantNotificationId");

                b.Property<long>("UserId");

                b.HasKey("Id");

                b.HasIndex("UserId", "State", "CreationTime");

                b.ToTable("AbpUserNotifications");
            });

            modelBuilder.Entity("Abp.Organizations.OrganizationUnit", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Code")
                    .IsRequired()
                    .HasMaxLength(95);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<bool>("IsDeleted");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<long?>("ParentId");

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("ParentId");

                b.HasIndex("TenantId", "Code");

                b.ToTable("AbpOrganizationUnits");
            });

            modelBuilder.Entity("HC.WeChat.Authorization.Roles.Role", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("Description")
                    .HasMaxLength(5000);

                b.Property<string>("DisplayName")
                    .IsRequired()
                    .HasMaxLength(64);

                b.Property<bool>("IsDefault");

                b.Property<bool>("IsDeleted");

                b.Property<bool>("IsStatic");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<string>("NormalizedName")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<int?>("TenantId");

                b.HasKey("Id");

                b.HasIndex("CreatorUserId");

                b.HasIndex("DeleterUserId");

                b.HasIndex("LastModifierUserId");

                b.HasIndex("TenantId", "NormalizedName");

                b.ToTable("AbpRoles");
            });

            modelBuilder.Entity("HC.WeChat.Authorization.Users.User", b =>
            {
                b.Property<long>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int>("AccessFailedCount");

                b.Property<string>("AuthenticationSource")
                    .HasMaxLength(64);

                b.Property<string>("ConcurrencyStamp")
                    .IsConcurrencyToken();

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<string>("EmailAddress")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<string>("EmailConfirmationCode")
                    .HasMaxLength(328);

                b.Property<bool>("IsActive");

                b.Property<bool>("IsDeleted");

                b.Property<bool>("IsEmailConfirmed");

                b.Property<bool>("IsLockoutEnabled");

                b.Property<bool>("IsPhoneNumberConfirmed");

                b.Property<bool>("IsTwoFactorEnabled");

                b.Property<DateTime?>("LastLoginTime");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<DateTime?>("LockoutEndDateUtc");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<string>("NormalizedEmailAddress")
                    .IsRequired()
                    .HasMaxLength(256);

                b.Property<string>("NormalizedUserName")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<string>("Password")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<string>("PasswordResetCode")
                    .HasMaxLength(328);

                b.Property<string>("PhoneNumber");

                b.Property<string>("SecurityStamp");

                b.Property<string>("Surname")
                    .IsRequired()
                    .HasMaxLength(32);

                b.Property<int?>("TenantId");

                b.Property<string>("UserName")
                    .IsRequired()
                    .HasMaxLength(32);

                b.HasKey("Id");

                b.HasIndex("CreatorUserId");

                b.HasIndex("DeleterUserId");

                b.HasIndex("LastModifierUserId");

                b.HasIndex("TenantId", "NormalizedEmailAddress");

                b.HasIndex("TenantId", "NormalizedUserName");

                b.ToTable("AbpUsers");
            });

            modelBuilder.Entity("HC.WeChat.MultiTenancy.Tenant", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("ConnectionString")
                    .HasMaxLength(1024);

                b.Property<DateTime>("CreationTime");

                b.Property<long?>("CreatorUserId");

                b.Property<long?>("DeleterUserId");

                b.Property<DateTime?>("DeletionTime");

                b.Property<int?>("EditionId");

                b.Property<bool>("IsActive");

                b.Property<bool>("IsDeleted");

                b.Property<DateTime?>("LastModificationTime");

                b.Property<long?>("LastModifierUserId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(128);

                b.Property<string>("TenancyName")
                    .IsRequired()
                    .HasMaxLength(64);

                b.HasKey("Id");

                b.HasIndex("CreatorUserId");

                b.HasIndex("DeleterUserId");

                b.HasIndex("EditionId");

                b.HasIndex("LastModifierUserId");

                b.HasIndex("TenancyName");

                b.ToTable("AbpTenants");
            });

            modelBuilder.Entity("Abp.Application.Features.EditionFeatureSetting", b =>
            {
                b.HasBaseType("Abp.Application.Features.FeatureSetting");

                b.Property<int>("EditionId");

                b.HasIndex("EditionId", "Name");

                b.ToTable("AbpFeatures");

                b.HasDiscriminator().HasValue("EditionFeatureSetting");
            });

            modelBuilder.Entity("Abp.MultiTenancy.TenantFeatureSetting", b =>
            {
                b.HasBaseType("Abp.Application.Features.FeatureSetting");


                b.HasIndex("TenantId", "Name");

                b.ToTable("AbpFeatures");

                b.HasDiscriminator().HasValue("TenantFeatureSetting");
            });

            modelBuilder.Entity("Abp.Authorization.Roles.RolePermissionSetting", b =>
            {
                b.HasBaseType("Abp.Authorization.PermissionSetting");

                b.Property<int>("RoleId");

                b.HasIndex("RoleId");

                b.ToTable("AbpPermissions");

                b.HasDiscriminator().HasValue("RolePermissionSetting");
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserPermissionSetting", b =>
            {
                b.HasBaseType("Abp.Authorization.PermissionSetting");

                b.Property<long>("UserId");

                b.HasIndex("UserId");

                b.ToTable("AbpPermissions");

                b.HasDiscriminator().HasValue("UserPermissionSetting");
            });

            modelBuilder.Entity("Abp.Authorization.Roles.RoleClaim", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Roles.Role")
                    .WithMany("Claims")
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserClaim", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Users.User")
                    .WithMany("Claims")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserLogin", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Users.User")
                    .WithMany("Logins")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserRole", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Users.User")
                    .WithMany("Roles")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserToken", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Users.User")
                    .WithMany("Tokens")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Configuration.Setting", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Users.User")
                    .WithMany("Settings")
                    .HasForeignKey("UserId");
            });

            modelBuilder.Entity("Abp.EntityHistory.EntityChange", b =>
            {
                b.HasOne("Abp.EntityHistory.EntityChangeSet")
                    .WithMany("EntityChanges")
                    .HasForeignKey("EntityChangeSetId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.EntityHistory.EntityPropertyChange", b =>
            {
                b.HasOne("Abp.EntityHistory.EntityChange")
                    .WithMany("PropertyChanges")
                    .HasForeignKey("EntityChangeId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Organizations.OrganizationUnit", b =>
            {
                b.HasOne("Abp.Organizations.OrganizationUnit", "Parent")
                    .WithMany("Children")
                    .HasForeignKey("ParentId");
            });

            modelBuilder.Entity("HC.WeChat.Authorization.Roles.Role", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Users.User", "CreatorUser")
                    .WithMany()
                    .HasForeignKey("CreatorUserId");

                b.HasOne("HC.WeChat.Authorization.Users.User", "DeleterUser")
                    .WithMany()
                    .HasForeignKey("DeleterUserId");

                b.HasOne("HC.WeChat.Authorization.Users.User", "LastModifierUser")
                    .WithMany()
                    .HasForeignKey("LastModifierUserId");
            });

            modelBuilder.Entity("HC.WeChat.Authorization.Users.User", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Users.User", "CreatorUser")
                    .WithMany()
                    .HasForeignKey("CreatorUserId");

                b.HasOne("HC.WeChat.Authorization.Users.User", "DeleterUser")
                    .WithMany()
                    .HasForeignKey("DeleterUserId");

                b.HasOne("HC.WeChat.Authorization.Users.User", "LastModifierUser")
                    .WithMany()
                    .HasForeignKey("LastModifierUserId");
            });

            modelBuilder.Entity("HC.WeChat.MultiTenancy.Tenant", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Users.User", "CreatorUser")
                    .WithMany()
                    .HasForeignKey("CreatorUserId");

                b.HasOne("HC.WeChat.Authorization.Users.User", "DeleterUser")
                    .WithMany()
                    .HasForeignKey("DeleterUserId");

                b.HasOne("Abp.Application.Editions.Edition", "Edition")
                    .WithMany()
                    .HasForeignKey("EditionId");

                b.HasOne("HC.WeChat.Authorization.Users.User", "LastModifierUser")
                    .WithMany()
                    .HasForeignKey("LastModifierUserId");
            });

            modelBuilder.Entity("Abp.Application.Features.EditionFeatureSetting", b =>
            {
                b.HasOne("Abp.Application.Editions.Edition", "Edition")
                    .WithMany()
                    .HasForeignKey("EditionId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Roles.RolePermissionSetting", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Roles.Role")
                    .WithMany("Permissions")
                    .HasForeignKey("RoleId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Abp.Authorization.Users.UserPermissionSetting", b =>
            {
                b.HasOne("HC.WeChat.Authorization.Users.User")
                    .WithMany("Permissions")
                    .HasForeignKey("UserId")
                    .OnDelete(DeleteBehavior.Cascade);
            });
#pragma warning restore 612, 618

            modelBuilder.Entity("HC.WeChat.WechatAppConfigs.WechatAppConfig", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd();
                b.Property<string>("Name").IsRequired().HasMaxLength(50);
                b.Property<string>("AppOrgId").IsRequired().HasMaxLength(250);
                b.Property<int>("AppType").IsRequired();
                b.Property<string>("AppId").IsRequired().HasMaxLength(250);
                b.Property<string>("AppSecret").IsRequired().HasMaxLength(250);
                b.Property<string>("EncodingAESKey").HasMaxLength(500);
                b.Property<string>("QRCodeUrl ").HasMaxLength(250);
                b.Property<string>("Token").IsRequired().HasMaxLength(250);
                b.Property<string>("AccessToken").HasMaxLength(255);
                b.Property<int?>("ExpiresIn");
                b.Property<DateTime?>("NextGettime");
                b.Property<int>("TenantId").IsRequired();
                b.Property<DateTime>("CreationTime").IsRequired();
                b.Property<long?>("CreatorUserId");
                b.Property<DateTime?>("LastModificationTime");
                b.Property<long>("LastModifierUserId");
                b.Property<string>("TemplateIds").HasMaxLength(500);
                b.HasKey("Id");

                //b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.ToTable("WechatAppConfigs");
            });

            modelBuilder.Entity("HC.WeChat.WechatMessages.WechatMessage", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd();
                b.Property<string>("KeyWord").IsRequired().HasMaxLength(50);
                b.Property<int>("MatchMode").IsRequired();
                b.Property<int>("MsgType").IsRequired();
                b.Property<string>("Content").IsRequired();
                b.Property<int>("TenantId").IsRequired();
                b.Property<DateTime>("CreationTime").IsRequired();
                b.Property<long?>("CreatorUserId");
                b.Property<DateTime?>("LastModificationTime");
                b.Property<long>("LastModifierUserId"); b.HasKey("Id");

                //b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.ToTable("WechatMessages");
            });

            modelBuilder.Entity("HC.WeChat.WechatSubscribes.WechatSubscribe", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd();
                b.Property<int>("MsgType").IsRequired();
                b.Property<string>("Content").IsRequired();
                b.Property<int>("TenantId").IsRequired();
                b.Property<DateTime>("CreationTime").IsRequired();
                b.Property<long?>("CreatorUserId");
                b.Property<DateTime?>("LastModificationTime");
                b.Property<long>("LastModifierUserId"); b.HasKey("Id");

                //b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.ToTable("WechatSubscribes");
            });

            modelBuilder.Entity("HC.WeChat.WeChatUsers.WeChatUser", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd();
                b.Property<string>("NickName").IsRequired().HasMaxLength(50);
                b.Property<string>("OpenId").IsRequired().HasMaxLength(50);
                b.Property<int>("UserType").IsRequired();
                b.Property<Guid?>("UserId");
                b.Property<string>("UserName").IsRequired().HasMaxLength(50);
                b.Property<int>("BindStatus").IsRequired();
                b.Property<DateTime?>("BindTime");
                b.Property<int?>("TenantId");
                b.Property<DateTime?>("UnBindTime");
                b.Property<string>("HeadImgUrl").HasMaxLength(500);
                b.Property<string>("Phone").HasMaxLength(20);
                b.Property<string>("MemberBarCode").HasMaxLength(30);
                b.Property<int?>("IntegralTotal");
                b.Property<bool?>("IsShopkeeper");
                b.Property<int>("UserType").IsRequired();
                b.Property<int?>("Status");
                b.Property<string>("Ticket").HasMaxLength(200);
                b.Property<int?>("SourceType");
                b.Property<string>("SourceId").HasMaxLength(100);

                b.HasKey("Id");

                //b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.ToTable("WeChatUsers");
            });

            modelBuilder.Entity("HC.WeChat.WeChatGroups.WeChatGroup", b =>
            {
                b.Property<int>("Id").ValueGeneratedOnAdd();
                b.Property<int>("TypeCode").IsRequired();
                b.Property<string>("TypeName");
                b.Property<int>("TagId").IsRequired();
                b.Property<string>("TagName").IsRequired().HasMaxLength(50);
                b.Property<int?>("TenantId");
                b.Property<DateTime>("CreationTime").IsRequired();
                b.Property<long>("CreatorUserId");
                b.Property<DateTime>("LastModificationTime");
                b.Property<long>("LastModifierUserId");
                b.HasKey("Id");

                //b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.ToTable("WeChatGroups");
            });

            modelBuilder.Entity("HC.WeChat.Orders.Order", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd();
                b.Property<string>("OrderId").HasMaxLength(300);
                b.Property<string>("UserId").HasMaxLength(300);
                b.Property<int?>("ActivityId");
                b.Property<DateTime?>("CreationTime");
                b.Property<int?>("State");
                b.Property<decimal?>("Money");
                b.Property<Guid?>("OpenOrder");
                b.Property<DateTime?>("NoticeTime");
                b.Property<int?>("RechargeSource");
                b.Property<decimal?>("Price");
                b.Property<int?>("AdultSum");
                b.Property<int?>("ChildSum");
                b.Property<int?>("IsUseIntegral");
                b.Property<string>("PlayerList").HasMaxLength(300);
                b.Property<string>("ExitOrderNo").HasMaxLength(100);
                b.Property<int?>("IsEnterState");
                b.Property<int?>("TicketSum");
                b.Property<string>("PriceIndex").HasMaxLength(50);
                b.Property<string>("PpriceTitle").HasMaxLength(200);
                b.Property<Guid?>("PlayBuuId");
                b.Property<int?>("PlayTime");
                b.Property<int?>("AllManSum");
                b.Property<decimal?>("AllSafePrice");
                b.Property<Guid?>("UseBillUnId");
                b.Property<int?>("UseBillState");
                b.Property<decimal?>("UseBillToMoney");
                b.Property<decimal?>("UseIntToMoney");
                b.Property<decimal?>("AllPriceInt");
                b.Property<int?>("IsCanToSee");
                b.Property<Guid?>("PlayShuId");
                b.Property<decimal?>("BuPrice");
                b.HasKey("Id");
                //b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.ToTable("Orders");
            });

            modelBuilder.Entity("HC.WeChat.OrderListEnclosures.OrderListEnclosure", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd();
                b.Property<Guid>("OrderId").IsRequired();
                b.Property<string>("ChnName").HasMaxLength(60);
                b.Property<string>("Phone").HasMaxLength(11);
                b.Property<string>("Address").HasMaxLength(500);
                b.Property<string>("IdCard").HasMaxLength(18);
                b.Property<string>("Remark").HasMaxLength(500);
                b.Property<Guid>("Id").ValueGeneratedOnAdd();
                b.Property<Guid>("OrderId").IsRequired();
                b.Property<string>("ChnName").HasMaxLength(60);
                b.Property<string>("Phone").HasMaxLength(11);
                b.Property<string>("Address").HasMaxLength(500);
                b.Property<string>("IdCard").HasMaxLength(18);
                b.Property<string>("Remark").HasMaxLength(500);
                b.HasKey("Id");

                //b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.ToTable("OrderListEnclosures");
            });

            modelBuilder.Entity("HC.WeChat.UserInfos.UserInfo", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd();
                b.Property<string>("OpenId").HasMaxLength(50);
                b.Property<string>("RoleName").HasMaxLength(150);
                b.Property<string>("Sex").HasMaxLength(1);
                b.Property<int?>("Integral");
                b.Property<int?>("FollowSum");
                b.Property<int?>("FollowedSum");
                b.Property<DateTime>("CreateTime");
                b.Property<int?>("NewClass1Sum");
                b.Property<int?>("NewClass2Sum");
                b.Property<string>("HeardImgName").HasMaxLength(250);
                b.Property<int?>("JoinTripSum");
                b.Property<string>("TaskTimeS").HasMaxLength(1000);
                b.Property<string>("CertificatesImgM").HasMaxLength(100);
                b.Property<string>("CertificatesImgS").HasMaxLength(100);
                b.Property<string>("Birthday").HasMaxLength(100);
                b.Property<string>("LiveAddress").HasMaxLength(300);
                b.Property<int?>("IsExamine");
                b.Property<DateTime>("ExamineTime");
                b.Property<string>("ExchangeTitle").HasMaxLength(200);
                b.Property<DateTime>("UpSignTime").HasMaxLength(20);
                b.Property<int?>("ContSignSum");
                b.Property<int?>("SignWeekNum");
                b.Property<string>("ColumnInfo").HasMaxLength(300);
                b.Property<string>("BodyInfo").HasMaxLength(2000);
                b.Property<int?>("BodyInfoState");
                b.Property<int?>("FirstFollowUserState");
                b.Property<string>("PhoneNumber").HasMaxLength(11);
                b.Property<int?>("FromId");
                b.Property<int?>("HeardImgClass");
                b.Property<string>("InvitationCode").HasMaxLength(20);
                b.Property<string>("LoginInvitationCode").HasMaxLength(20);
                b.Property<int?>("ExchangHomeState");
                b.Property<int?>("FirstInvitationFriend");
                b.Property<int?>("OnlineTimeLong");
                b.Property<int?>("CommentSum");
                b.Property<int?>("ShareSum");
                b.Property<DateTime>("TalkDelTime");
                b.Property<int?>("IsLoginState");
                b.Property<string>("DeviceToken").HasMaxLength(200);
                b.Property<Guid?>("BuuId");
                b.Property<int?>("BindBUSum");
                b.Property<string>("GetTreeIntDate").HasMaxLength(100);
                b.Property<string>("UserNeedRedu").HasMaxLength(1000);
                b.HasKey("Id");

                //b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.ToTable("UserInfos");
            });

            modelBuilder.Entity("HC.WeChat.Activitys.Activity", b => {
                b.Property<Guid>("Id").ValueGeneratedOnAdd();
                b.Property<int>("ActivityId");
                b.Property<string>("Title").HasMaxLength(50);
                b.Property<string>("ClassInt").HasMaxLength(300);
                b.Property<decimal?>("CostInt");
                b.Property<string>("AgeClassInt").HasMaxLength(300);
                b.Property<string>("IconImg").HasMaxLength(60);
                b.Property<string>("BTitle").HasMaxLength(1000);
                b.Property<Guid?>("LeaderInt");
                b.Property<string>("ActivityMessage");
                b.Property<string>("BeCarefulMessage").HasMaxLength(4000);
                b.Property<string>("OutActivityMessage").HasMaxLength(4000);
                b.Property<int?>("OneselfClass");
                b.Property<int?>("HuoClass");
                b.Property<string>("TitleIdClass").HasMaxLength(10);
                b.Property<DateTime?>("LimitTime");
                b.Property<string>("ImgArray").HasMaxLength(1000);
                b.Property<int?>("IsClose");
                b.Property<DateTime?>("CreationTime");
                b.Property<int?>("SortInt");
                b.Property<int?>("GoodSum");
                b.Property<int?>("FirstReState");
                b.Property<int?>("SeeSum");
                b.Property<DateTime?>("ActivityTime");
                b.Property<string>("ActivityAddress").HasMaxLength(300);
                b.Property<int?>("CommentSum");
                b.Property<int?>("CostIntClass");
                b.Property<decimal?>("AdultCostInt");
                b.Property<decimal?>("ChildCostInt");
                b.Property<int?>("AllTeamSum");
                b.Property<int?>("LoginTeamSum");
                b.Property<decimal?>("BUACMoneyPP");
                b.Property<int?>("WXShowState");
                b.Property<Guid?>("BuSendActivityId");
                b.Property<string>("WXPriceArray").HasMaxLength(2000);
                b.Property<Guid?>("BuuId");
                b.Property<int?>("SafeClass");
                b.Property<decimal?>("SafeMoneyChi");
                b.Property<decimal?>("SafeMoneyMan");
                b.Property<int?>("IsBillPay");
                b.Property<DateTime?>("ActivtiyEndTime");
                b.Property<int?>("IntPayLimit");
                b.Property<int?>("SendTicketState");
                b.Property<int?>("IsExitOrder");
                b.Property<string>("TicketsMessage").HasMaxLength(1000);
                b.Property<int?>("SendId");
                b.Property<decimal?>("MixPrice");
                b.Property<int?>("ReducePriceUser");
                b.Property<DateTime?>("ReducePriceLTime");
                b.Property<string>("ReducePriceMessage");
                b.Property<string>("WXAppUrlShow").HasMaxLength(500);
                b.Property<string>("UserNeedRedu").HasMaxLength(1000);
                b.Property<string>("PlayCQImg").HasMaxLength(200);
                b.Property<int?>("PlayCQImgState");
                b.Property<int?>("AcUrlCode");
                b.Property<int?>("SettlementClass");
                b.Property<string>("SettlementString").HasMaxLength(10);        
                b.HasKey("Id");

                //b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.ToTable("Activitys");
            });

            modelBuilder.Entity("HC.WeChat.BuSetInfos.BuSetInfo", b =>
            {
                b.Property<Guid>("Id").ValueGeneratedOnAdd();
                b.Property<string>("BuName").HasMaxLength(150);
                b.Property<string>("Phone").HasMaxLength(11);
                b.Property<string>("ContactsName").HasMaxLength(20);
                b.Property<string>("Address").HasMaxLength(150);
                b.Property<DateTime?>("CreationTime");
                b.Property<Guid>("Id").ValueGeneratedOnAdd();
                b.Property<string>("BuName").HasMaxLength(150);
                b.Property<string>("Phone").HasMaxLength(11);
                b.Property<string>("ContactsName").HasMaxLength(20);
                b.Property<string>("Address").HasMaxLength(150);
                b.Property<DateTime?>("CreationTime");
                b.HasKey("Id");

                //b.HasIndex("TargetTenantId", "TargetUserId", "ReadState");

                b.ToTable("BuSetInfos");
            });
        }
    }
}
