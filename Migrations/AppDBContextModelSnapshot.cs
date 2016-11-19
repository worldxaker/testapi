using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAPIApplication.Models;

namespace WebAPIApplication.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("WebAPIApplication.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cron");

                    b.Property<int>("Interval");

                    b.Property<string>("Message");

                    b.Property<int>("Times");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("WebAPIApplication.Models.Geo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("isAlert");

                    b.Property<string>("lang");

                    b.Property<string>("lax");

                    b.Property<int>("timestamp");

                    b.HasKey("Id");

                    b.ToTable("Geo");
                });

            modelBuilder.Entity("WebAPIApplication.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebAPIApplication.Models.Event", b =>
                {
                    b.HasOne("WebAPIApplication.Models.User")
                        .WithMany("sheduler")
                        .HasForeignKey("UserId");
                });
        }
    }
}
