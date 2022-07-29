﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model_ViewModel.Models;

namespace Model_ViewModel.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220729182909_someechangegggggg")]
    partial class someechangegggggg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model_ViewModel.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Model_ViewModel.Models.Degree", b =>
                {
                    b.Property<int>("DegreeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DegreeName");

                    b.HasKey("DegreeID");

                    b.ToTable("Degree");
                });

            modelBuilder.Entity("Model_ViewModel.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired();

                    b.Property<int>("Degree");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Gender");

                    b.Property<bool>("IAccept");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.Property<string>("Website")
                        .IsRequired();

                    b.HasKey("PersonID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Model_ViewModel.Models.Product", b =>
                {
                    b.Property<int>("ProductID");

                    b.Property<int>("CategoryID");

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Deleted");

                    b.Property<DateTime?>("DeletedDate");

                    b.Property<int>("PersonID");

                    b.Property<int>("ProductCategoryID");

                    b.Property<string>("ProductDesc");

                    b.Property<string>("ProductImage");

                    b.Property<string>("ProductName");

                    b.Property<long>("ProductPrice");

                    b.Property<string>("ProductShortDesc");

                    b.HasKey("ProductID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Model_ViewModel.Models.ProductFeatures", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("DeletedTime");

                    b.Property<string>("DisplayName");

                    b.Property<DateTime>("InsertTime");

                    b.Property<int>("ProductId");

                    b.Property<DateTime?>("UpdateTime");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductFeatures");
                });

            modelBuilder.Entity("Model_ViewModel.Models.ProductImages", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Deleted");

                    b.Property<DateTime?>("DeletedTime");

                    b.Property<DateTime>("InsertTime");

                    b.Property<int>("ProductId");

                    b.Property<string>("Src");

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Model_ViewModel.Models.Product", b =>
                {
                    b.HasOne("Model_ViewModel.Models.Category", "Category")
                        .WithMany("Product")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Model_ViewModel.Models.Person", "Person")
                        .WithMany("Product")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model_ViewModel.Models.ProductFeatures", b =>
                {
                    b.HasOne("Model_ViewModel.Models.Product", "Product")
                        .WithMany("ProductFeatures")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model_ViewModel.Models.ProductImages", b =>
                {
                    b.HasOne("Model_ViewModel.Models.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
