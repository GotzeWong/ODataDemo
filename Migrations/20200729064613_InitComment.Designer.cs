﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ODataDemo.Data;

namespace ODataDemo.Migrations
{
    [DbContext(typeof(XxxDbContext))]
    [Migration("20200729064613_InitComment")]
    partial class InitComment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ODataDemo.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommentId1")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.HasIndex("CommentId1");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ODataDemo.Models.Form", b =>
                {
                    b.Property<decimal>("FormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormId");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("ODataDemo.Models.Patient", b =>
                {
                    b.Property<decimal>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("ODataDemo.Models.PatientForms", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("FormId")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("PatientId")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientForms");
                });

            modelBuilder.Entity("ODataDemo.Models.Comment", b =>
                {
                    b.HasOne("ODataDemo.Models.Comment", "comment")
                        .WithMany()
                        .HasForeignKey("CommentId1");
                });

            modelBuilder.Entity("ODataDemo.Models.PatientForms", b =>
                {
                    b.HasOne("ODataDemo.Models.Form", "Form")
                        .WithMany("PatientForms")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ODataDemo.Models.Patient", "Patient")
                        .WithMany("PatientForms")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
