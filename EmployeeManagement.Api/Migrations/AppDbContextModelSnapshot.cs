﻿// <auto-generated />
using System;
using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeManagement.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeManagement.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            DepartmentName = "IT"
                        },
                        new
                        {
                            DepartmentId = 2,
                            DepartmentName = "HR"
                        },
                        new
                        {
                            DepartmentId = 3,
                            DepartmentName = "Payroll"
                        },
                        new
                        {
                            DepartmentId = 4,
                            DepartmentName = "Admin"
                        });
                });

            modelBuilder.Entity("EmployeeManagement.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfBirth = new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "David@testmail.com",
                            FirstName = "John",
                            Gender = 0,
                            LastName = "Hastings",
                            PhotoPath = "images/emp1.jpg"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfBirth = new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 2,
                            Email = "Sam@testmail.com",
                            FirstName = "Sam",
                            Gender = 0,
                            LastName = "Galloway",
                            PhotoPath = "images/emp2.jpg"
                        },
                        new
                        {
                            EmployeeId = 3,
                            DateOfBirth = new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 1,
                            Email = "mary@testmail.com",
                            FirstName = "Mary",
                            Gender = 1,
                            LastName = "Smith",
                            PhotoPath = "images/emp3.jpg"
                        },
                        new
                        {
                            EmployeeId = 4,
                            DateOfBirth = new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DepartmentId = 3,
                            Email = "sara@testmail.com",
                            FirstName = "Sara",
                            Gender = 1,
                            LastName = "Longway",
                            PhotoPath = "images/emp4.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
