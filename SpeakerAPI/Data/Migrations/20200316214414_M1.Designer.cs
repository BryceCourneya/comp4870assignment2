﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SpeakerAPI.Data.Migrations
{
    [DbContext(typeof(SpeakerDbContext))]
    [Migration("20200316214414_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment2Library.Speaker", b =>
                {
                    b.Property<string>("SpeakerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpeakerId");

                    b.ToTable("Speakers");

                    b.HasData(
                        new
                        {
                            SpeakerId = "202227c3-0a88-457e-bebe-bdbc81c39d92",
                            FirstName = "Tom",
                            LastName = "Day"
                        },
                        new
                        {
                            SpeakerId = "68c95d72-621d-4939-bd08-475f10794f64",
                            FirstName = "Ann",
                            LastName = "Fox"
                        },
                        new
                        {
                            SpeakerId = "0cbd8424-0f3a-4860-abba-0ef4a05734b7",
                            FirstName = "Art",
                            LastName = "Ash"
                        },
                        new
                        {
                            SpeakerId = "5b8c8adc-02d4-4dd4-b6a6-bfd986c79cc8",
                            FirstName = "Mia",
                            LastName = "Hay"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
