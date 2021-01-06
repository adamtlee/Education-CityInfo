﻿// <auto-generated />
using CityInfo.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CityInfo.Migrations
{
    [DbContext(typeof(CityInfoContext))]
    partial class CityInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CityInfo.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Denver, Colorado.",
                            Name = "Denver"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Arvada, Colorado.",
                            Name = "Arvada"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Boulder, Colorado",
                            Name = "Boulder"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Estes Park, Colorado",
                            Name = "Estes Park"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Glenwood Springs, Colorado",
                            Name = "Glenwood Springs"
                        });
                });

            modelBuilder.Entity("CityInfo.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointsOfInterest");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "Place that has wonderful Nature",
                            Name = "Botanic Gardens"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "A place with historical artifacts",
                            Name = "Museum of Nature and Science"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Description = "Pretty much the downtown of Arvada",
                            Name = "Olde Town"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 3,
                            Description = "Pretty much the downtown of Arvada",
                            Name = "Olde Town"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 4,
                            Description = "A Haunted Hotel In Estes",
                            Name = "Stanley Hotel"
                        },
                        new
                        {
                            Id = 6,
                            CityId = 5,
                            Description = "A Haunted Hotel in Glenwood",
                            Name = "Hotel Colorado"
                        },
                        new
                        {
                            Id = 7,
                            CityId = 5,
                            Description = "Relaxing hot springs in Glenwood",
                            Name = "Iron Mountain Hotsprings"
                        });
                });

            modelBuilder.Entity("CityInfo.Entities.PointOfInterest", b =>
                {
                    b.HasOne("CityInfo.Entities.City", "City")
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CityInfo.Entities.City", b =>
                {
                    b.Navigation("PointsOfInterest");
                });
#pragma warning restore 612, 618
        }
    }
}
