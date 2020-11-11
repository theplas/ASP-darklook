﻿// <auto-generated />
using System;
using ASP_darklook.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP_darklook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201110155144_nguyen")]
    partial class nguyen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ASP_darklook.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Games"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Playstation"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Reviews"
                        });
                });

            modelBuilder.Entity("ASP_darklook.Models.Posts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Content = " lorem very carrots, enhanced undergraduate developer, but they do occaecat time and vitality, such as labor and obesity. Who suspend basketball very pregnant .... ",
                            DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "./img/blog/1.jpg",
                            Title = "The best online game is out now!"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Content = " Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed tempor and vitality, so that the labor and sorrow, some important things to do eiusmod. Ultrices gravida .... Who hung up the very hard work ",
                            DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "./img/blog/2.jpg",
                            Title = "Top 5 best games in november"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Content = " To be honest, the main undergraduate developer, but they do occaecat time and vitality, such as labor and obesity. Who recommended that pregnant basketball ncididunt to work .... ",
                            DateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "./img/blog/3.jpg",
                            Title = "The best online game is out now!"
                        });
                });

            modelBuilder.Entity("ASP_darklook.Models.Posts", b =>
                {
                    b.HasOne("ASP_darklook.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ASP_darklook.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
