﻿// <auto-generated />
using Hotel2.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotel2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20211005172327_SeedingDataAttempt6")]
    partial class SeedingDataAttempt6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hotel2.data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "United States",
                            ShortName = "USA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Spain",
                            ShortName = "ESP"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Switzerland",
                            ShortName = "CH"
                        });
                });

            modelBuilder.Entity("Hotel2.data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Cherry Moon",
                            CountryId = 1,
                            Name = "USA No 1",
                            Rating = 1.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Cherry Luna",
                            CountryId = 2,
                            Name = "ESP No 1",
                            Rating = 1.0
                        },
                        new
                        {
                            Id = 3,
                            Address = "Cherry Mond",
                            CountryId = 3,
                            Name = "CH No 1",
                            Rating = 1.0
                        });
                });

            modelBuilder.Entity("Hotel2.data.Hotel", b =>
                {
                    b.HasOne("Hotel2.data.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });
#pragma warning restore 612, 618
        }
    }
}
