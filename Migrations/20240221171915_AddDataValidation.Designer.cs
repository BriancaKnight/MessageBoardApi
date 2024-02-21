﻿// <auto-generated />
using System;
using MessageBoardApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MessageBoardApi.Migrations
{
    [DbContext(typeof(MessageBoardApiContext))]
    [Migration("20240221171915_AddDataValidation")]
    partial class AddDataValidation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoardApi.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("longtext");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "abc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f32f0c29-8455-4199-a0f2-495ed1318a4a",
                            Email = "jimothy@proton.me",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAECTt9A+AH54zc/erlrP/382jwI4kuPVxQ9LzBJY2dkB1XFICmqInCr7fYhk6yafvAg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7a6c20f3-9abf-47b9-960a-6086356efefe",
                            TwoFactorEnabled = false,
                            UserName = "Jimothy"
                        },
                        new
                        {
                            Id = "def",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "97aa0e12-567f-4ba0-8e34-aff2e89a6f8f",
                            Email = "Timmet@tutanota.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAEIVCn0yqIeytajSqTHNUJ9OOsdHaA7mC4BPDsC8d75KFt17oJNd2Uc+PTUIjIQiEUQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6399598e-9e95-453d-9485-b678181dadb3",
                            TwoFactorEnabled = false,
                            UserName = "Timmet"
                        },
                        new
                        {
                            Id = "ghi",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8ef2ffac-599f-4afd-9e04-72470c39d2cc",
                            Email = "Woxanda@soverin.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAEAACcQAAAAELpQhiR60Lw9DBS9ieVCOuq3I9oWKzdoN3D+iV70bHZTUFdTZ6vdnLIlI0NSHj85SQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "44730422-ce7d-4ed6-9b82-600048c15914",
                            TwoFactorEnabled = false,
                            UserName = "Woxanda"
                        });
                });

            modelBuilder.Entity("MessageBoardApi.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            GroupId = 1,
                            Topic = "Hellos"
                        },
                        new
                        {
                            GroupId = 2,
                            Topic = "Goodbyes"
                        },
                        new
                        {
                            GroupId = 3,
                            Topic = "Nonsense"
                        });
                });

            modelBuilder.Entity("MessageBoardApi.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("MessageId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            MessageId = 1,
                            Date = new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 1,
                            Text = "Hi I need more discount hogs!",
                            UserId = "abc"
                        },
                        new
                        {
                            MessageId = 2,
                            Date = new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 2,
                            Text = "Goodbye, thank you for teaching me how to shave my cat ",
                            UserId = "def"
                        },
                        new
                        {
                            MessageId = 3,
                            Date = new DateTime(1924, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GroupId = 3,
                            Text = "Kim Jong Un is so dreamy!!",
                            UserId = "ghi"
                        });
                });

            modelBuilder.Entity("MessageBoardApi.Models.Message", b =>
                {
                    b.HasOne("MessageBoardApi.Models.Group", "Group")
                        .WithMany("Messages")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MessageBoardApi.Models.ApplicationUser", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MessageBoardApi.Models.ApplicationUser", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("MessageBoardApi.Models.Group", b =>
                {
                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
