﻿// <auto-generated />
using KRFTemplateApi.Infrastructure.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KRFTemplateApi.Infrastructure.Migrations
{
    [DbContext(typeof(SampleDBContext))]
    partial class SampleDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("KRFTemplateApi.Domain.Database.Sample.SampleTable", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureMax")
                        .HasColumnType("int");

                    b.Property<int>("TemperatureMin")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.ToTable("SampleTable");

                    b.HasData(
                        new
                        {
                            Code = "Freezing",
                            Description = "It's freezing today",
                            TemperatureMax = -5,
                            TemperatureMin = -15
                        },
                        new
                        {
                            Code = "Bracing",
                            Description = "It's Bracing",
                            TemperatureMax = 0,
                            TemperatureMin = -4
                        },
                        new
                        {
                            Code = "Chilly",
                            Description = "It's Chilly tonight",
                            TemperatureMax = 5,
                            TemperatureMin = 1
                        },
                        new
                        {
                            Code = "Cool",
                            Description = "Cool day",
                            TemperatureMax = 10,
                            TemperatureMin = 6
                        },
                        new
                        {
                            Code = "Mild",
                            Description = "Mild mornigng",
                            TemperatureMax = 15,
                            TemperatureMin = 11
                        },
                        new
                        {
                            Code = "Warm",
                            Description = "The afternoon will be Warm",
                            TemperatureMax = 20,
                            TemperatureMin = 16
                        },
                        new
                        {
                            Code = "Balmy",
                            Description = "Balmy it is",
                            TemperatureMax = 25,
                            TemperatureMin = 21
                        },
                        new
                        {
                            Code = "Hot",
                            Description = "The day is too Hot",
                            TemperatureMax = 30,
                            TemperatureMin = 26
                        },
                        new
                        {
                            Code = "Sweltering",
                            Description = "Sweltering, i need a pool",
                            TemperatureMax = 35,
                            TemperatureMin = 31
                        },
                        new
                        {
                            Code = "Scorching",
                            Description = "It's Scorching, i'm going to the beach and swim all day",
                            TemperatureMax = 45,
                            TemperatureMin = 36
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
