﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PKWebApp.Data;

namespace PKWebApp.Migrations
{
    [DbContext(typeof(PKContext))]
    [Migration("20200718180333_updatedDb")]
    partial class updatedDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PKWebApp.Data.Entities.ClientContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientPhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ClientContacts");
                });

            modelBuilder.Entity("PKWebApp.Data.Entities.CoreService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CoreServicDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoreServiceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CoreServices");
                });

            modelBuilder.Entity("PKWebApp.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PKWebApp.Data.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CoreServiceId")
                        .HasColumnType("int");

                    b.Property<int>("ServicePriceTag")
                        .HasColumnType("int");

                    b.Property<string>("ServiceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoreServiceId");

                    b.HasIndex("TicketId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("PKWebApp.Data.Entities.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientContactInfoId")
                        .HasColumnType("int");

                    b.Property<int>("EstimatedBudget")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientContactInfoId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("PKWebApp.Data.Entities.Order", b =>
                {
                    b.HasOne("PKWebApp.Data.Entities.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("PKWebApp.Data.Entities.Service", b =>
                {
                    b.HasOne("PKWebApp.Data.Entities.CoreService", null)
                        .WithMany("Services")
                        .HasForeignKey("CoreServiceId");

                    b.HasOne("PKWebApp.Data.Entities.Ticket", null)
                        .WithMany("Services")
                        .HasForeignKey("TicketId");
                });

            modelBuilder.Entity("PKWebApp.Data.Entities.Ticket", b =>
                {
                    b.HasOne("PKWebApp.Data.Entities.ClientContactInfo", "ClientContactInfo")
                        .WithMany()
                        .HasForeignKey("ClientContactInfoId");
                });
#pragma warning restore 612, 618
        }
    }
}
