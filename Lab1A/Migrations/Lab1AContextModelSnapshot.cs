﻿// <auto-generated />
using System;
using Lab1A.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab1A.Migrations
{
    [DbContext(typeof(Lab1AContext))]
    partial class Lab1AContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab1A.Models.Car", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<int?>("DealershipID");

                    b.Property<string>("Make")
                        .IsRequired();

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<int>("VIN");

                    b.Property<int>("Year");

                    b.HasKey("ID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Lab1A.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate");

                    b.Property<string>("Company");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Position");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("MemberID");

                    b.ToTable("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
