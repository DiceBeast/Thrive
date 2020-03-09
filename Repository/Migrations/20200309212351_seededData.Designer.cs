﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Data;

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200309212351_seededData")]
    partial class seededData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repository.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            ClassId = 1,
                            Subject = "Math"
                        },
                        new
                        {
                            ClassId = 2,
                            Subject = "Science"
                        },
                        new
                        {
                            ClassId = 3,
                            Subject = "History"
                        });
                });

            modelBuilder.Entity("Repository.Models.Parent", b =>
                {
                    b.Property<int>("ParentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ParentId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Parents");

                    b.HasData(
                        new
                        {
                            ParentId = 1,
                            Name = "Kelly Madison",
                            StudentId = 1
                        },
                        new
                        {
                            ParentId = 2,
                            Name = "Kim Clennan",
                            StudentId = 2
                        },
                        new
                        {
                            ParentId = 3,
                            Name = "Steve Melton",
                            StudentId = 3
                        },
                        new
                        {
                            ParentId = 4,
                            Name = "Bill Johnson",
                            StudentId = 4
                        },
                        new
                        {
                            ParentId = 5,
                            Name = "Jeff Sather",
                            StudentId = 5
                        },
                        new
                        {
                            ParentId = 6,
                            Name = "Amy Sanchez",
                            StudentId = 6
                        },
                        new
                        {
                            ParentId = 7,
                            Name = "Samuel Martinez",
                            StudentId = 7
                        },
                        new
                        {
                            ParentId = 8,
                            Name = "Frank Madison",
                            StudentId = 8
                        },
                        new
                        {
                            ParentId = 9,
                            Name = "Max Collins",
                            StudentId = 9
                        },
                        new
                        {
                            ParentId = 10,
                            Name = "Bob Vogg",
                            StudentId = 10
                        });
                });

            modelBuilder.Entity("Repository.Models.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FavoriteSubject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearningStyle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfileId");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Repository.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Name = "Aaron Madison"
                        },
                        new
                        {
                            StudentId = 2,
                            Name = "Sean Clennan"
                        },
                        new
                        {
                            StudentId = 3,
                            Name = "Zac Melton"
                        },
                        new
                        {
                            StudentId = 4,
                            Name = "Marcus Johnson"
                        },
                        new
                        {
                            StudentId = 5,
                            Name = "Charlie Sather"
                        },
                        new
                        {
                            StudentId = 6,
                            Name = "Abraham Sanchez"
                        },
                        new
                        {
                            StudentId = 7,
                            Name = "Jacob Martinez"
                        },
                        new
                        {
                            StudentId = 8,
                            Name = "Billy Madison"
                        },
                        new
                        {
                            StudentId = 9,
                            Name = "Phil Collins"
                        },
                        new
                        {
                            StudentId = 10,
                            Name = "Parker Vogg"
                        });
                });

            modelBuilder.Entity("Repository.Models.StudentClassGrade", b =>
                {
                    b.Property<int>("StudentClassGradeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("StudentClassGradeId");

                    b.HasIndex("ClassId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentClassGrades");
                });

            modelBuilder.Entity("Repository.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.HasIndex("ClassId")
                        .IsUnique();

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            ClassId = 1,
                            Name = "Mike Terrill",
                            PhoneNumber = "111-111-1111",
                            Subject = "Math"
                        },
                        new
                        {
                            TeacherId = 2,
                            ClassId = 2,
                            Name = "Nevin Seibel",
                            PhoneNumber = "222-222-2222",
                            Subject = "Science"
                        },
                        new
                        {
                            TeacherId = 3,
                            ClassId = 3,
                            Name = "David Lagrange",
                            PhoneNumber = "555-555-5555",
                            Subject = "History"
                        });
                });

            modelBuilder.Entity("Repository.Models.Class", b =>
                {
                    b.HasOne("Repository.Models.Student", null)
                        .WithMany("Classes")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Repository.Models.Parent", b =>
                {
                    b.HasOne("Repository.Models.Student", "Student")
                        .WithOne("Parent")
                        .HasForeignKey("Repository.Models.Parent", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repository.Models.Student", b =>
                {
                    b.HasOne("Repository.Models.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileId");
                });

            modelBuilder.Entity("Repository.Models.StudentClassGrade", b =>
                {
                    b.HasOne("Repository.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Repository.Models.Teacher", b =>
                {
                    b.HasOne("Repository.Models.Class", "Class")
                        .WithOne("Teacher")
                        .HasForeignKey("Repository.Models.Teacher", "ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}