﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SpeakerAPI.Data.Migrations
{
    [DbContext(typeof(SpeakerDbContext))]
    [Migration("20200316231222_M3")]
    partial class M3
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
                            SpeakerId = "fdccf36f-b096-4c13-9d3a-7a802d361701",
                            FirstName = "Tom",
                            LastName = "Day"
                        },
                        new
                        {
                            SpeakerId = "995752f3-2e48-4636-a4c0-977641929ad9",
                            FirstName = "Ann",
                            LastName = "Fox"
                        },
                        new
                        {
                            SpeakerId = "41fb7377-dbcf-46ee-b7a6-19dcd0728f04",
                            FirstName = "Art",
                            LastName = "Ash"
                        },
                        new
                        {
                            SpeakerId = "c69fed55-9a5b-4c6e-b27c-45e1c3da011d",
                            FirstName = "Mia",
                            LastName = "Hay"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
