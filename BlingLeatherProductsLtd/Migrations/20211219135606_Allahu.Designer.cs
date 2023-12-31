﻿// <auto-generated />
using BlingLeatherProductsLtd.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlingLeatherProductsLtd.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20211219135606_Allahu")]
    partial class Allahu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlingLeatherProductsLtd.Models.Accessories", b =>
                {
                    b.Property<int>("AID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ATotalQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AID");

                    b.ToTable("AccessoriesList");
                });

            modelBuilder.Entity("BlingLeatherProductsLtd.Models.ChemicalMaterials", b =>
                {
                    b.Property<int>("CMID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BalancedQuantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BinNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChalanNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateRecieved")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HSCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderedQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecievedQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CMID");

                    b.ToTable("ChemicalMaterials");
                });

            modelBuilder.Entity("BlingLeatherProductsLtd.Models.ChemicalMaterialsDetails", b =>
                {
                    b.Property<int>("CMDID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BalanceQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CMID")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequisitionNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionOrDepartment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CMDID");

                    b.ToTable("ChemicalMaterialsDetails");
                });

            modelBuilder.Entity("BlingLeatherProductsLtd.Models.RawMaterials", b =>
                {
                    b.Property<int>("RMID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArticleNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BalancedQuantity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BinNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChalanNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateRecieved")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HSCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderedQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecievedQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RMID");

                    b.ToTable("RawMaterials");
                });

            modelBuilder.Entity("BlingLeatherProductsLtd.Models.RawMaterialsDetails", b =>
                {
                    b.Property<int>("RMDID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BalanceQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssuedQuantity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RMID")
                        .HasColumnType("int");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequisitionNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionOrDepartment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RMDID");

                    b.ToTable("RawMaterialsDetails");
                });

            modelBuilder.Entity("BlingLeatherProductsLtd.Models.RecievedAccessoriess", b =>
                {
                    b.Property<int>("ARID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AID")
                        .HasColumnType("int");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Invoices")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderedQnty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecievedQnty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ARID");

                    b.ToTable("RecievedAccessories");
                });
#pragma warning restore 612, 618
        }
    }
}
