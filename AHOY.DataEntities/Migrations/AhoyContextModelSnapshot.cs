﻿// <auto-generated />
using System;
using AHOY.DataEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AHOY.DataEntities.Migrations
{
    [DbContext(typeof(AhoyContext))]
    partial class AhoyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AHOY.DataEntities.Entities.FacilityMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FacilityMaster");
                });

            modelBuilder.Entity("AHOY.DataEntities.Entities.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsPopular")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRecomended")
                        .HasColumnType("bit");

                    b.Property<bool>("IsTopRated")
                        .HasColumnType("bit");

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte?>("Ratings")
                        .HasColumnType("tinyint");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("AHOY.DataEntities.Entities.HotelFacility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("FacelityId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityId")
                        .HasColumnType("int");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FacelityId");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelFacility");
                });

            modelBuilder.Entity("AHOY.DataEntities.Entities.HotelImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelImage");
                });

            modelBuilder.Entity("AHOY.DataEntities.Entities.HotelFacility", b =>
                {
                    b.HasOne("AHOY.DataEntities.Entities.FacilityMaster", "Facility")
                        .WithMany()
                        .HasForeignKey("FacelityId");

                    b.HasOne("AHOY.DataEntities.Entities.Hotel", "Hotel")
                        .WithMany("HotelFacilities")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Facility");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("AHOY.DataEntities.Entities.HotelImage", b =>
                {
                    b.HasOne("AHOY.DataEntities.Entities.Hotel", "Hotel")
                        .WithMany("HotelImages")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("AHOY.DataEntities.Entities.Hotel", b =>
                {
                    b.Navigation("HotelFacilities");

                    b.Navigation("HotelImages");
                });
#pragma warning restore 612, 618
        }
    }
}
