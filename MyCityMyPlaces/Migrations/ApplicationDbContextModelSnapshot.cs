﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCityMyPlaces.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MyCityMyPlaces.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("MyCityMyPlaces.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(8,6)");

                    b.Property<decimal>("Lon")
                        .HasColumnType("decimal(8,6)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<bool>("Shared")
                        .HasColumnType("boolean");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LocationId");

                    b.HasIndex("UserEmail");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MyCityMyPlaces.Models.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("User");
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.Property<string>("FamilyRequestsInEmail")
                        .HasColumnType("text");

                    b.Property<string>("FamilyRequestsOutEmail")
                        .HasColumnType("text");

                    b.HasKey("FamilyRequestsInEmail", "FamilyRequestsOutEmail");

                    b.HasIndex("FamilyRequestsOutEmail");

                    b.ToTable("UserUser");
                });

            modelBuilder.Entity("MyCityMyPlaces.Models.Location", b =>
                {
                    b.HasOne("MyCityMyPlaces.Models.User", "User")
                        .WithMany("Locations")
                        .HasForeignKey("UserEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.HasOne("MyCityMyPlaces.Models.User", null)
                        .WithMany()
                        .HasForeignKey("FamilyRequestsInEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyCityMyPlaces.Models.User", null)
                        .WithMany()
                        .HasForeignKey("FamilyRequestsOutEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyCityMyPlaces.Models.User", b =>
                {
                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}