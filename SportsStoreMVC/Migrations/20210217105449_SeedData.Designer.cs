﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsStoreMVC.Models;

namespace SportsStoreMVC.Migrations
{
    [DbContext(typeof(SportsStoreDb))]
    [Migration("20210217105449_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsStoreMVC.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8, 2)");

                    b.HasKey("ProductID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductID = 1L,
                            Category = "Watersports",
                            Description = "Protective and fashionable",
                            Name = "Lifejacket",
                            Price = 48.95m
                        },
                        new
                        {
                            ProductID = 2L,
                            Category = "Soccer",
                            Description = "FIFA-approved size and weight",
                            Name = "Soccer Ball",
                            Price = 19.50m
                        },
                        new
                        {
                            ProductID = 3L,
                            Category = "Soccer",
                            Description = "Give your playing field a professional touch",
                            Name = "Corner Flags",
                            Price = 34.95m
                        },
                        new
                        {
                            ProductID = 4L,
                            Category = "Soccer",
                            Description = "Flat-packed 35,000-seat stadium",
                            Name = "Stadium",
                            Price = 79500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
