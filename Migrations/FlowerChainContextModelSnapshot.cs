﻿// <auto-generated />
using System;
using FlowerChainAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlowerChainAPI.Migrations
{
    [DbContext(typeof(FlowerChainContext))]
    partial class FlowerChainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("newsLetter")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("personId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.Employee", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("personId")
                        .HasColumnType("int");

                    b.Property<DateTime>("workStartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.Flower", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("flowerType")
                        .HasColumnType("longtext");

                    b.Property<double>("price")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.ToTable("Flower");

                    b.HasData(
                        new
                        {
                            id = 1,
                            flowerType = "Roos",
                            price = 1.2
                        },
                        new
                        {
                            id = 2,
                            flowerType = "Madeliefje",
                            price = 1.3
                        },
                        new
                        {
                            id = 3,
                            flowerType = "Vergeet-me-nietje",
                            price = 1.0
                        },
                        new
                        {
                            id = 4,
                            flowerType = "Violetje",
                            price = 1.3999999999999999
                        });
                });

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.FlowerBouquet", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("amountSold")
                        .HasColumnType("int");

                    b.Property<string>("bouquetName")
                        .HasColumnType("longtext");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<double>("price")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.ToTable("FlowerBouquet");

                    b.HasData(
                        new
                        {
                            id = 1,
                            amountSold = 3,
                            bouquetName = "Liefde",
                            description = "4 rozen en 2 violetjes",
                            price = 4.0
                        },
                        new
                        {
                            id = 2,
                            amountSold = 2,
                            bouquetName = "Zonnenstraal",
                            description = "4 rozen en 6 vergeet me nietjes",
                            price = 5.0
                        },
                        new
                        {
                            id = 3,
                            amountSold = 4,
                            bouquetName = "Welkom terug",
                            description = "4 rozen, 2 madeliefjes en 3 violetjes",
                            price = 6.0
                        },
                        new
                        {
                            id = 4,
                            amountSold = 1,
                            bouquetName = "Tot ziens",
                            description = "4 rozen, 2 madeliefjes, 3 violetjes en 2 vergeet-me-nietjes",
                            price = 5.0
                        });
                });

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.FlowerBouquetOrder", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<int>("flowerBouquetId")
                        .HasColumnType("int");

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("FlowerBouquetOrder");
                });

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.FlowerFlowerBouquet", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("flowerBouquetId")
                        .HasColumnType("int");

                    b.Property<int>("flowerId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("FlowerFlowerBouquet");
                });

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.FlowerShop", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("houseNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("postalCode")
                        .HasColumnType("longtext");

                    b.Property<string>("shopName")
                        .HasColumnType("longtext");

                    b.Property<string>("streetName")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("FlowerShop");

                    b.HasData(
                        new
                        {
                            id = 1,
                            city = "Mechelen",
                            email = "debloemenkrans@hotmail.com",
                            houseNumber = "52",
                            phoneNumber = "015635478",
                            postalCode = "2800",
                            shopName = "De bloemenkrans",
                            streetName = "Van hoeystraat"
                        },
                        new
                        {
                            id = 2,
                            city = "Korbeek-Lo",
                            email = "blomke@hotmail.com",
                            houseNumber = "3",
                            phoneNumber = "015435878",
                            postalCode = "3000",
                            shopName = "Het Blomke",
                            streetName = "Dorpstraat"
                        },
                        new
                        {
                            id = 3,
                            city = "Tielt-Winge",
                            email = "petersbloemen@hotmail.com",
                            houseNumber = "14",
                            phoneNumber = "016258843",
                            postalCode = "3390",
                            shopName = "Peters bloemen",
                            streetName = "Broekstraat"
                        });
                });

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.FlowerShopSupplier", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("flowerShopId")
                        .HasColumnType("int");

                    b.Property<int>("supplierId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("FlowerShopSupplier");
                });

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("datTimeOrder")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("personId")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("firstName")
                        .HasColumnType("longtext");

                    b.Property<int>("flowerShopId")
                        .HasColumnType("int");

                    b.Property<string>("houseNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("isEmployee")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("lastName")
                        .HasColumnType("longtext");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("postalCode")
                        .HasColumnType("longtext");

                    b.Property<string>("streetName")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("FlowerChainAPI.Models.Domain.Supplier", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("houseNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("phoneNumber")
                        .HasColumnType("longtext");

                    b.Property<string>("postalCode")
                        .HasColumnType("longtext");

                    b.Property<string>("shopName")
                        .HasColumnType("longtext");

                    b.Property<string>("streetName")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("Supplier");
                });
#pragma warning restore 612, 618
        }
    }
}
