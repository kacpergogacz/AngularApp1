﻿// <auto-generated />
using System;
using AngularApp1.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AngularApp1.Server.Migrations
{
    [DbContext(typeof(ContactDbContext))]
    partial class ContactDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AngularApp1.Server.Models.ContactDetails", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactID"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nchar(16)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nchar(70)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nchar(40)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nchar(40)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nchar(32)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nchar(9)");

                    b.Property<string>("SubCategory")
                        .IsRequired()
                        .HasColumnType("nchar(32)");

                    b.HasKey("ContactID");

                    b.ToTable("ContactDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
