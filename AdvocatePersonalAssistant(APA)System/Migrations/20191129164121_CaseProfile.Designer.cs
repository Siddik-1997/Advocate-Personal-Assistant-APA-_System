﻿// <auto-generated />
using AdvocatePersonalAssistantSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvocatePersonalAssistantSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191129164121_CaseProfile")]
    partial class CaseProfile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvocatePersonalAssistantSystem.Models.CaseProfile", b =>
                {
                    b.Property<int>("Case_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("CaseName")
                        .IsRequired();

                    b.Property<string>("ClientName")
                        .IsRequired();

                    b.Property<string>("Defendant")
                        .IsRequired();

                    b.Property<string>("Fee")
                        .IsRequired();

                    b.Property<string>("Hdate")
                        .IsRequired();

                    b.Property<string>("Idate")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Plaintiff")
                        .IsRequired();

                    b.HasKey("Case_Id");

                    b.ToTable("CaseProfiles");
                });
#pragma warning restore 612, 618
        }
    }
}
