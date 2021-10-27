﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentInfoAPI.Models;

namespace StudentInfoAPI.Migrations
{
    [DbContext(typeof(StudentDBContext))]
    partial class StudentDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentInfoAPI.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("S_FirstName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("S_LastName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("S_MiddleName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("StudentContacts")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("StudentEmail")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("StudentLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("TDT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UDT")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentID");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}
