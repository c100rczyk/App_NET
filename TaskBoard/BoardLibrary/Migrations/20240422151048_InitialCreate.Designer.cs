﻿// <auto-generated />
using BoardLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoardLibrary.Migrations
{
    [DbContext(typeof(BoardContext))]
    [Migration("20240422151048_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BoardLibrary.PersonModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectModelId")
                        .HasColumnType("int");

                    b.Property<int>("TaskModelId")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectModelId");

                    b.HasIndex("TaskModelId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("BoardLibrary.ProjectModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Technology")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("BoardLibrary.TaskModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Deadline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DifLevel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectModelId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectModelId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("BoardLibrary.PersonModel", b =>
                {
                    b.HasOne("BoardLibrary.ProjectModel", "ProjectModel")
                        .WithMany()
                        .HasForeignKey("ProjectModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardLibrary.TaskModel", "TaskModel")
                        .WithMany("PersonModels")
                        .HasForeignKey("TaskModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectModel");

                    b.Navigation("TaskModel");
                });

            modelBuilder.Entity("BoardLibrary.TaskModel", b =>
                {
                    b.HasOne("BoardLibrary.ProjectModel", "ProjectModel")
                        .WithMany()
                        .HasForeignKey("ProjectModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectModel");
                });

            modelBuilder.Entity("BoardLibrary.TaskModel", b =>
                {
                    b.Navigation("PersonModels");
                });
#pragma warning restore 612, 618
        }
    }
}
