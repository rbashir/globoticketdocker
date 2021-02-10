﻿// <auto-generated />
using System;
using GloboTicket.Services.Discount.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GloboTicket.Services.Discount.Migrations
{
    [DbContext(typeof(DiscountDbContext))]
    partial class DiscountDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GloboTicket.Services.Discount.Entities.Coupon", b =>
                {
                    b.Property<Guid>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CouponId");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            CouponId = new Guid("12de6791-38ef-474c-abf6-80a0651341a8"),
                            Amount = 10,
                            UserId = new Guid("e455a3df-7fa5-47e0-8435-179b300d531f")
                        },
                        new
                        {
                            CouponId = new Guid("b99910b8-fd95-4f80-84b4-32eaa8159d35"),
                            Amount = 20,
                            UserId = new Guid("bbf594b0-3761-4a65-b04c-eec4836d9070")
                        });
                });
#pragma warning restore 612, 618
        }
    }
}