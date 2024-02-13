﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SettingApi.Data;

#nullable disable

namespace SettingApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240213203649_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SettingApi.Entities.Models.NotificationSettings", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("NotificationType")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.HasKey("UserId");

                    b.ToTable("NotificationSettings");

                    b.HasDiscriminator<string>("NotificationType").HasValue("NotificationSettings");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("SettingApi.Entities.Models.EmailSettings", b =>
                {
                    b.HasBaseType("SettingApi.Entities.Models.NotificationSettings");

                    b.Property<bool>("IsDirectMessageEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFollowEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMentionEnabled")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Email");
                });

            modelBuilder.Entity("SettingApi.Entities.Models.PushSettings", b =>
                {
                    b.HasBaseType("SettingApi.Entities.Models.NotificationSettings");

                    b.Property<bool>("IsDirectMessageEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFollowEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMentionEnabled")
                        .HasColumnType("bit");

                    b.ToTable("NotificationSettings", t =>
                        {
                            t.Property("IsDirectMessageEnabled")
                                .HasColumnName("PushSettings_IsDirectMessageEnabled");

                            t.Property("IsFollowEnabled")
                                .HasColumnName("PushSettings_IsFollowEnabled");

                            t.Property("IsMentionEnabled")
                                .HasColumnName("PushSettings_IsMentionEnabled");
                        });

                    b.HasDiscriminator().HasValue("PushNotification");
                });

            modelBuilder.Entity("SettingApi.Entities.Models.SmsSettings", b =>
                {
                    b.HasBaseType("SettingApi.Entities.Models.NotificationSettings");

                    b.Property<bool>("IsPasswordChangeEnabled")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Sms");
                });
#pragma warning restore 612, 618
        }
    }
}