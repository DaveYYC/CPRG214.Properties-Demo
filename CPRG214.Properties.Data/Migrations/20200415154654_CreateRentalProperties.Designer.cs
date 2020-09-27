﻿// <auto-generated />
using System;
using CPRG214.Properties.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CPRG214.Properties.Data.Migrations
{
    [DbContext(typeof(RentalsContext))]
    [Migration("20200415154654_CreateRentalProperties")]
    partial class CreateRentalProperties
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CPRG214.Properties.Domain.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owner");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ben King",
                            Phone = "403-555-8500"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Paul Wilson",
                            Phone = "403-555-6935"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kimberly Dunne",
                            Phone = "403-555-4770"
                        });
                });

            modelBuilder.Entity("CPRG214.Properties.Domain.PropertyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Style")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PropertyType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Style = "Apartment"
                        },
                        new
                        {
                            Id = 2,
                            Style = "Townhouse"
                        },
                        new
                        {
                            Id = 3,
                            Style = "Bungalow"
                        },
                        new
                        {
                            Id = 4,
                            Style = "Suite"
                        });
                });

            modelBuilder.Entity("CPRG214.Properties.Domain.RentalProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RenterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("PropertyTypeId");

                    b.HasIndex("RenterId")
                        .IsUnique()
                        .HasFilter("[RenterId] IS NOT NULL");

                    b.ToTable("RentalProperty");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "1345 - 670 14th Ave SW",
                            City = "Calgary",
                            OwnerId = 2,
                            PostalCode = "T3T 3T3",
                            PropertyTypeId = 1,
                            Province = "AB",
                            Rent = 1200m,
                            RenterId = 3
                        },
                        new
                        {
                            Id = 2,
                            Address = "4567 66th Ave NW",
                            City = "Calgary",
                            OwnerId = 1,
                            PostalCode = "T2T 2D2",
                            PropertyTypeId = 3,
                            Province = "AB",
                            Rent = 2400m,
                            RenterId = 2
                        },
                        new
                        {
                            Id = 3,
                            Address = "240 - 2111 4th St NW",
                            City = "Calgary",
                            OwnerId = 3,
                            PostalCode = "T5T 5T5",
                            PropertyTypeId = 4,
                            Province = "AB",
                            Rent = 1000m
                        });
                });

            modelBuilder.Entity("CPRG214.Properties.Domain.Renter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Renter");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Sam",
                            LastName = "Munro",
                            Phone = "403-555-3456"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Sarah",
                            LastName = "Carr",
                            Phone = "403-555-7666"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "John",
                            LastName = "Hudon",
                            Phone = "403-555-3000"
                        });
                });

            modelBuilder.Entity("CPRG214.Properties.Domain.RentalProperty", b =>
                {
                    b.HasOne("CPRG214.Properties.Domain.Owner", "Owner")
                        .WithMany("RentalProperties")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CPRG214.Properties.Domain.PropertyType", "PropertyType")
                        .WithMany("RentalProperties")
                        .HasForeignKey("PropertyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CPRG214.Properties.Domain.Renter", "Renter")
                        .WithOne("RentalProperty")
                        .HasForeignKey("CPRG214.Properties.Domain.RentalProperty", "RenterId");
                });
#pragma warning restore 612, 618
        }
    }
}
