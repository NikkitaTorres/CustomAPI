﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoeStoreApi.Models;

#nullable disable

namespace ShoeStoreApi.Migrations
{
    [DbContext(typeof(ShoeStoreApiContext))]
    partial class ShoeStoreApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ShoeStoreApi.Models.Shoe", b =>
                {
                    b.Property<int>("ShoeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .HasColumnType("longtext");

                    b.Property<string>("Colors")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("ShoeId");

                    b.ToTable("Shoes");

                    b.HasData(
                        new
                        {
                            ShoeId = 1,
                            Brand = "Jordan",
                            Colors = "Black/Red",
                            Name = "Bred Reimagined"
                        },
                        new
                        {
                            ShoeId = 2,
                            Brand = "Nike",
                            Colors = "Brown",
                            Name = "Air Force 1"
                        },
                        new
                        {
                            ShoeId = 3,
                            Brand = "Yeezy",
                            Colors = "Slate Grey",
                            Name = "Slide"
                        },
                        new
                        {
                            ShoeId = 4,
                            Brand = "Adidas",
                            Colors = "Core Black",
                            Name = "Campus 00s"
                        },
                        new
                        {
                            ShoeId = 5,
                            Brand = "Converse",
                            Colors = "Black",
                            Name = "PLAY"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
