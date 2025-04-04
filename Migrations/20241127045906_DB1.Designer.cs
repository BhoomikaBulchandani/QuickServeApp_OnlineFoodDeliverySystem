﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickServeAPP.Data;

#nullable disable

namespace QuickServeAPP.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241127045906_DB1")]
    partial class DB1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuickServeAPP.Models.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartID"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("QuickServeAPP.Models.CartItem", b =>
                {
                    b.Property<int>("CartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartItemID"));

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CartItemID");

                    b.HasIndex("CartID");

                    b.HasIndex("MenuID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Menu", b =>
                {
                    b.Property<int>("MenuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuID"));

                    b.Property<string>("AvailabilityTime")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("DietaryInfo")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("MenuID");

                    b.HasIndex("ItemName")
                        .IsUnique();

                    b.HasIndex("RestaurantID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("OrderDate");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("QuickServeAPP.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemID"));

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("OrderID")
                        .IsUnique();

                    b.HasIndex("UserID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Rating", b =>
                {
                    b.Property<int>("RatingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingID"));

                    b.Property<int?>("MenuID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.Property<DateTime>("RatingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RatingScore")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantID")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("RatingID");

                    b.HasIndex("MenuID");

                    b.HasIndex("OrderID");

                    b.HasIndex("RestaurantID");

                    b.HasIndex("UserID");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantID"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("RestaurantID");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("QuickServeAPP.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Cart", b =>
                {
                    b.HasOne("QuickServeAPP.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("QuickServeAPP.Models.Cart", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuickServeAPP.Models.CartItem", b =>
                {
                    b.HasOne("QuickServeAPP.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickServeAPP.Models.Menu", "Menu")
                        .WithMany("CartItems")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Menu", b =>
                {
                    b.HasOne("QuickServeAPP.Models.Restaurant", "Restaurant")
                        .WithMany("Menus")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Order", b =>
                {
                    b.HasOne("QuickServeAPP.Models.Restaurant", "Restaurant")
                        .WithMany("Orders")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickServeAPP.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Restaurant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuickServeAPP.Models.OrderItem", b =>
                {
                    b.HasOne("QuickServeAPP.Models.Menu", "Menu")
                        .WithMany("OrderItems")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("QuickServeAPP.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Payment", b =>
                {
                    b.HasOne("QuickServeAPP.Models.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("QuickServeAPP.Models.Payment", "OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuickServeAPP.Models.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Rating", b =>
                {
                    b.HasOne("QuickServeAPP.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuID");

                    b.HasOne("QuickServeAPP.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID");

                    b.HasOne("QuickServeAPP.Models.Restaurant", "Restaurant")
                        .WithMany("Ratings")
                        .HasForeignKey("RestaurantID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("QuickServeAPP.Models.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Order");

                    b.Navigation("Restaurant");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Menu", b =>
                {
                    b.Navigation("CartItems");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("QuickServeAPP.Models.Order", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Payment")
                        .IsRequired();
                });

            modelBuilder.Entity("QuickServeAPP.Models.Restaurant", b =>
                {
                    b.Navigation("Menus");

                    b.Navigation("Orders");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("QuickServeAPP.Models.User", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Payments");

                    b.Navigation("Ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
