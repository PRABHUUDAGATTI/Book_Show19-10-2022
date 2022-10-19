﻿// <auto-generated />
using System;
using Book_Show_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Book_Show_DAL.Migrations
{
    [DbContext(typeof(Book_show_db))]
    partial class Book_show_dbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Book_Show_Entity.BookShow", b =>
                {
                    b.Property<int>("BookShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NoOfTickets")
                        .HasColumnType("int");

                    b.Property<int>("ShowTimingId")
                        .HasColumnType("int");

                    b.Property<double>("TicketCost")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BookShowId");

                    b.HasIndex("ShowTimingId");

                    b.HasIndex("UserId");

                    b.ToTable("bookShow");
                });

            modelBuilder.Entity("Book_Show_Entity.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LocationDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocationId");

                    b.ToTable("location");
                });

            modelBuilder.Entity("Book_Show_Entity.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte[]>("ImgPoster")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("MovieDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieLanguage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("movies");
                });

            modelBuilder.Entity("Book_Show_Entity.ShowTiming", b =>
                {
                    b.Property<int>("ShowTimingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShowTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TheatreId")
                        .HasColumnType("int");

                    b.HasKey("ShowTimingId");

                    b.HasIndex("MovieId");

                    b.HasIndex("TheatreId");

                    b.ToTable("showTiming");
                });

            modelBuilder.Entity("Book_Show_Entity.Theater", b =>
                {
                    b.Property<int>("TheatreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TheatreId");

                    b.HasIndex("LocationId");

                    b.ToTable("theater");
                });

            modelBuilder.Entity("Book_Show_Entity.UserDetails", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UserPhoneNo")
                        .HasColumnType("float");

                    b.HasKey("UserId");

                    b.ToTable("userDetails");
                });

            modelBuilder.Entity("Book_Show_Entity.BookShow", b =>
                {
                    b.HasOne("Book_Show_Entity.ShowTiming", "ShowTiming")
                        .WithMany()
                        .HasForeignKey("ShowTimingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Book_Show_Entity.UserDetails", "UserDetails")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShowTiming");

                    b.Navigation("UserDetails");
                });

            modelBuilder.Entity("Book_Show_Entity.ShowTiming", b =>
                {
                    b.HasOne("Book_Show_Entity.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Book_Show_Entity.Theater", "Theater")
                        .WithMany()
                        .HasForeignKey("TheatreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Theater");
                });

            modelBuilder.Entity("Book_Show_Entity.Theater", b =>
                {
                    b.HasOne("Book_Show_Entity.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });
#pragma warning restore 612, 618
        }
    }
}
