﻿// <auto-generated />
using System;
using System.Collections.Generic;
using BandBlender.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BandBlender.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230914085005_AddMusicianNewFields")]
    partial class AddMusicianNewFields
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BandBlender.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("BandBlender.Models.Band", b =>
                {
                    b.Property<Guid>("BandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Biography")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("DemoUrl")
                        .HasColumnType("text");

                    b.Property<int?>("GenreId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("text");

                    b.HasKey("BandId");

                    b.HasIndex("GenreId");

                    b.ToTable("Bands");
                });

            modelBuilder.Entity("BandBlender.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GenreId"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("BandBlender.Models.Musician", b =>
                {
                    b.Property<Guid>("MusicianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("BandId")
                        .HasColumnType("uuid");

                    b.Property<List<Guid>>("BandIds")
                        .IsRequired()
                        .HasColumnType("uuid[]");

                    b.Property<string>("Biography")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Demo")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("InstrumentId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("MusicianId");

                    b.HasIndex("BandId");

                    b.ToTable("Musicians");
                });

            modelBuilder.Entity("BandBlender.Models.Band", b =>
                {
                    b.HasOne("BandBlender.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("BandBlender.Models.Musician", b =>
                {
                    b.HasOne("BandBlender.Models.Band", null)
                        .WithMany("Musicians")
                        .HasForeignKey("BandId");
                });

            modelBuilder.Entity("BandBlender.Models.Band", b =>
                {
                    b.Navigation("Musicians");
                });
#pragma warning restore 612, 618
        }
    }
}
