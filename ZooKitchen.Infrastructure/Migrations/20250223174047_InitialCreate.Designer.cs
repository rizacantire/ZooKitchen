﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZooKitchen.Infrastructure.Persistence;

#nullable disable

namespace ZooKitchen.Infrastructure.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20250223174047_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("ZooKitchen.Domain.Entities.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("ZooKitchen.Domain.Entities.DeliveryDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("AnimalId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("ProductId");

                    b.ToTable("DeliveryDetails");
                });

            modelBuilder.Entity("ZooKitchen.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ZooKitchen.Domain.Entities.DeliveryDetail", b =>
                {
                    b.HasOne("ZooKitchen.Domain.Entities.Animal", "Animal")
                        .WithMany("DeliveryDetails")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooKitchen.Domain.Entities.Product", "Product")
                        .WithMany("DeliveryDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ZooKitchen.Domain.Entities.Animal", b =>
                {
                    b.Navigation("DeliveryDetails");
                });

            modelBuilder.Entity("ZooKitchen.Domain.Entities.Product", b =>
                {
                    b.Navigation("DeliveryDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
