﻿// <auto-generated />
using System;
using Ecomm.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Ecomm.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220819135256_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Ecomm.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookCoverId")
                        .HasColumnType("integer");

                    b.Property<string>("BookUrl")
                        .HasColumnType("text");

                    b.Property<int>("BookWritterId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ISBNNUMBER")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<bool>("Trending")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("BookCoverId");

                    b.HasIndex("BookWritterId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Ecomm.Models.BookCover", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BookWritterId")
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BookWritterId");

                    b.ToTable("BookCovers");
                });

            modelBuilder.Entity("Ecomm.Models.BookWritter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BookWritters");
                });

            modelBuilder.Entity("Ecomm.Models.Book", b =>
                {
                    b.HasOne("Ecomm.Models.BookCover", null)
                        .WithMany("Books")
                        .HasForeignKey("BookCoverId");

                    b.HasOne("Ecomm.Models.BookWritter", null)
                        .WithMany("Books")
                        .HasForeignKey("BookWritterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ecomm.Models.BookCover", b =>
                {
                    b.HasOne("Ecomm.Models.BookWritter", "BookWritter")
                        .WithMany("BookCovers")
                        .HasForeignKey("BookWritterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookWritter");
                });

            modelBuilder.Entity("Ecomm.Models.BookCover", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Ecomm.Models.BookWritter", b =>
                {
                    b.Navigation("BookCovers");

                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}