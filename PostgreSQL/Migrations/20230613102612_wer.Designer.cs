﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PostgreSQL;

#nullable disable

namespace PostgreSQL.Migrations
{
    [DbContext(typeof(LastSportDBContext))]
    [Migration("20230613102612_wer")]
    partial class wer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PostgreSQL.Domain.HistoryLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("IP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("device_settings")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset>("last_login_time")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("HistoryLogins");
                });

            modelBuilder.Entity("PostgreSQL.Domain.Role", b =>
                {
                    b.Property<int>("role_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("role_id"));

                    b.Property<bool>("change_events")
                        .HasColumnType("boolean");

                    b.Property<bool>("change_user")
                        .HasColumnType("boolean");

                    b.Property<bool>("commentder_events")
                        .HasColumnType("boolean");

                    b.Property<bool>("read_events")
                        .HasColumnType("boolean");

                    b.Property<string>("role_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("role_id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("PostgreSQL.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("role_id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("role_id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PostgreSQL.Domain.HistoryLogin", b =>
                {
                    b.HasOne("PostgreSQL.Domain.User", "User")
                        .WithMany("HistoryLogins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("PostgreSQL.Domain.User", b =>
                {
                    b.HasOne("PostgreSQL.Domain.Role", "Role")
                        .WithMany("users")
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PostgreSQL.Domain.Role", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("PostgreSQL.Domain.User", b =>
                {
                    b.Navigation("HistoryLogins");
                });
#pragma warning restore 612, 618
        }
    }
}