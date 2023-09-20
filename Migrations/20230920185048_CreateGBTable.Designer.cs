﻿// <auto-generated />
using ContestantsApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContestantsApi.Migrations
{
    [DbContext(typeof(ContestantsApiContext))]
    [Migration("20230920185048_CreateGBTable")]
    partial class CreateGBTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ContestantsApi.Models.BipContestant", b =>
                {
                    b.Property<int>("BipContestantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PastAppearance")
                        .HasColumnType("longtext");

                    b.Property<int>("SeasonTotal")
                        .HasColumnType("int");

                    b.Property<string>("photo")
                        .HasColumnType("longtext");

                    b.HasKey("BipContestantId");

                    b.ToTable("BipContestants");
                });

            modelBuilder.Entity("ContestantsApi.Models.GbContestant", b =>
                {
                    b.Property<int>("GbContestantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("longtext");

                    b.Property<string>("Hometown")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Occupation")
                        .HasColumnType("longtext");

                    b.Property<string>("Photo")
                        .HasColumnType("longtext");

                    b.Property<int>("SeasonTotal")
                        .HasColumnType("int");

                    b.HasKey("GbContestantId");

                    b.ToTable("GbContestants");
                });
#pragma warning restore 612, 618
        }
    }
}
