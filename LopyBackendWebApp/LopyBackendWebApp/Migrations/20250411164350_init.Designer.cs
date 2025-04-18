﻿// <auto-generated />
using System;
using LopyBackendWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LopyBackendWebApp.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250411164350_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LopyBackendWebApp.Data.Flight", b =>
                {
                    b.Property<string>("Airline")
                        .HasColumnType("nvarchar(450)");

                    b.Property<TimeSpan>("ArrivalTime")
                        .HasColumnType("time");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("DayNumber")
                        .HasColumnType("int");

                    b.Property<string>("Degree")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("DepTime")
                        .HasColumnType("time");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<double>("PriceUSD")
                        .HasColumnType("float");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalStops")
                        .HasColumnType("float");

                    b.HasKey("Airline");

                    b.ToTable("flights");
                });
#pragma warning restore 612, 618
        }
    }
}
