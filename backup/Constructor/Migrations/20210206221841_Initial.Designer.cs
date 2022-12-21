﻿// <auto-generated />
using System;
using Constructor.Storage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Constructor.Migrations
{
    [DbContext(typeof(DbContent))]
    [Migration("20210206221841_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Constructor.Storage.Containers.DriveAndAssemblyPair", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdOfAssembly")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdOfDrive")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("DAPairs");
                });

            modelBuilder.Entity("Constructor.Storage.Containers.FanAndAssemblyPair", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdOfAssembly")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdOfFan")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("FAPairs");
                });

            modelBuilder.Entity("Constructor.Storage.Containers.RamAndAssemblyPair", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdOfAssembly")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdOfRam")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("RAPairs");
                });

            modelBuilder.Entity("Constructor.Storage.Models.Assembly", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CPU")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Case")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CpuFan")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("DriveCount")
                        .HasColumnType("int");

                    b.Property<int>("FANCount")
                        .HasColumnType("int");

                    b.Property<Guid>("FSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GPU")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Motherboard")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RAMCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Assemblies");
                });

            modelBuilder.Entity("Constructor.Storage.Models.CPU", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnName("DoubCost")
                        .HasColumnType("float");

                    b.Property<int>("Count")
                        .HasColumnName("IntCount")
                        .HasColumnType("int");

                    b.Property<string>("ECC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Frequency")
                        .HasColumnType("float");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnName("StrImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("StrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnName("IntPopularity")
                        .HasColumnType("int");

                    b.Property<string>("Socket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TDP")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("StrType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CPUs");
                });

            modelBuilder.Entity("Constructor.Storage.Models.Case", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnName("DoubCost")
                        .HasColumnType("float");

                    b.Property<int>("Count")
                        .HasColumnName("IntCount")
                        .HasColumnType("int");

                    b.Property<int>("Drive25Count")
                        .HasColumnName("IntDriveCount")
                        .HasColumnType("int");

                    b.Property<int>("Drive35Count")
                        .HasColumnType("int");

                    b.Property<int>("Fan120Count")
                        .HasColumnType("int");

                    b.Property<int>("Fan140Count")
                        .HasColumnName("IntFanCount")
                        .HasColumnType("int");

                    b.Property<int>("Fan90Count")
                        .HasColumnType("int");

                    b.Property<string>("FormFactor")
                        .IsRequired()
                        .HasColumnName("StrFormFactor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnName("StrImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("StrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnName("IntPopularity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("StrType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("Constructor.Storage.Models.CpuFan", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnName("DoubCost")
                        .HasColumnType("float");

                    b.Property<int>("Count")
                        .HasColumnName("IntCount")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnName("StrImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("StrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnName("IntPopularity")
                        .HasColumnType("int");

                    b.Property<string>("Sockets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TDP")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("StrType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CpuFans");
                });

            modelBuilder.Entity("Constructor.Storage.Models.Drive", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnName("DoubCost")
                        .HasColumnType("float");

                    b.Property<int>("Count")
                        .HasColumnName("IntCount")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnName("StrImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("StrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnName("IntPopularity")
                        .HasColumnType("int");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("StrType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Drives");
                });

            modelBuilder.Entity("Constructor.Storage.Models.FAN", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnName("DoubCost")
                        .HasColumnType("float");

                    b.Property<int>("Count")
                        .HasColumnName("IntCount")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnName("StrImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("StrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnName("IntPopularity")
                        .HasColumnType("int");

                    b.Property<double>("Size")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("StrType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FANs");
                });

            modelBuilder.Entity("Constructor.Storage.Models.FSP", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnName("DoubCost")
                        .HasColumnType("float");

                    b.Property<int>("Count")
                        .HasColumnName("IntCount")
                        .HasColumnType("int");

                    b.Property<string>("FormFactor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnName("StrImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("StrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Output")
                        .HasColumnType("float");

                    b.Property<int>("Popularity")
                        .HasColumnName("IntPopularity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("StrType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FSPs");
                });

            modelBuilder.Entity("Constructor.Storage.Models.GPU", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Clock")
                        .HasColumnType("float");

                    b.Property<double>("Cost")
                        .HasColumnName("DoubCost")
                        .HasColumnType("float");

                    b.Property<int>("Count")
                        .HasColumnName("IntCount")
                        .HasColumnType("int");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnName("StrImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MemorySize")
                        .HasColumnType("float");

                    b.Property<string>("MemoryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("StrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnName("IntPopularity")
                        .HasColumnType("int");

                    b.Property<double>("RecommendFSPPower")
                        .HasColumnType("float");

                    b.Property<double>("TDP")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("StrType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GPUs");
                });

            modelBuilder.Entity("Constructor.Storage.Models.Motherboard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Chipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Cost")
                        .HasColumnName("DoubCost")
                        .HasColumnType("float");

                    b.Property<int>("Count")
                        .HasColumnName("IntCount")
                        .HasColumnType("int");

                    b.Property<int>("DriveCount")
                        .HasColumnType("int");

                    b.Property<string>("ECC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FANCount")
                        .HasColumnType("int");

                    b.Property<string>("FormFactor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnName("StrImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemoryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("StrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnName("IntPopularity")
                        .HasColumnType("int");

                    b.Property<int>("RAMCount")
                        .HasColumnType("int");

                    b.Property<string>("Socket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("StrType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Motherboards");
                });

            modelBuilder.Entity("Constructor.Storage.Models.RAM", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("GuidId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Cost")
                        .HasColumnName("DoubCost")
                        .HasColumnType("float");

                    b.Property<int>("Count")
                        .HasColumnName("IntCount")
                        .HasColumnType("int");

                    b.Property<string>("ECC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnName("StrImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MemorySize")
                        .HasColumnType("float");

                    b.Property<string>("MemoryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("StrName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Popularity")
                        .HasColumnName("IntPopularity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("StrType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RAMs");
                });
#pragma warning restore 612, 618
        }
    }
}
