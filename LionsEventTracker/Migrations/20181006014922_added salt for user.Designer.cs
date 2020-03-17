﻿// <auto-generated />
using System;
using LionsEventTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LionsEventTracker.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20181006014922_added salt for user")]
    partial class addedsaltforuser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LionsEventTracker.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Time")
                        .IsRequired();

                    b.Property<string>("Venue")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("LionsEventTracker.Models.EventUser", b =>
                {
                    b.Property<int>("userId");

                    b.Property<int>("eventId");

                    b.HasKey("userId", "eventId");

                    b.HasIndex("eventId");

                    b.ToTable("EventUser");
                });

            modelBuilder.Entity("LionsEventTracker.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<byte[]>("salt");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LionsEventTracker.Models.EventUser", b =>
                {
                    b.HasOne("LionsEventTracker.Models.Event", "Events")
                        .WithMany("eventUsers")
                        .HasForeignKey("eventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LionsEventTracker.Models.User", "Users")
                        .WithMany("eventUsers")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
