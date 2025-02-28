﻿// <auto-generated />
using System;
using DiaryApp.Controllers.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiaryApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DiaryApp.Models.DiaryEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "This is my first diary entry.",
                            DateCreated = new DateTime(2024, 11, 27, 18, 4, 27, 523, DateTimeKind.Local).AddTicks(4899),
                            Title = "First Entry"
                        },
                        new
                        {
                            Id = 2,
                            Content = "This is my second diary entry.",
                            DateCreated = new DateTime(2024, 11, 27, 18, 4, 27, 523, DateTimeKind.Local).AddTicks(4903),
                            Title = "Second Entry"
                        },
                        new
                        {
                            Id = 3,
                            Content = "This is my third unhappy entry.",
                            DateCreated = new DateTime(2024, 11, 27, 18, 4, 27, 523, DateTimeKind.Local).AddTicks(4907),
                            Title = "Third Entry"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
