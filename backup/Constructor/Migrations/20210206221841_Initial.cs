using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Constructor.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assemblies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Case = table.Column<Guid>(nullable: false),
                    CPU = table.Column<Guid>(nullable: false),
                    CpuFan = table.Column<Guid>(nullable: false),
                    DriveCount = table.Column<int>(nullable: false),
                    FANCount = table.Column<int>(nullable: false),
                    FSP = table.Column<Guid>(nullable: false),
                    GPU = table.Column<Guid>(nullable: false),
                    Motherboard = table.Column<Guid>(nullable: false),
                    RAMCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assemblies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    GuidId = table.Column<Guid>(nullable: false),
                    StrName = table.Column<string>(nullable: false),
                    StrImg = table.Column<string>(nullable: false),
                    IntCount = table.Column<int>(nullable: false),
                    DoubCost = table.Column<double>(nullable: false),
                    IntPopularity = table.Column<int>(nullable: false),
                    StrType = table.Column<string>(nullable: false),
                    StrFormFactor = table.Column<string>(nullable: false),
                    IntFanCount = table.Column<int>(nullable: false),
                    Fan120Count = table.Column<int>(nullable: false),
                    Fan90Count = table.Column<int>(nullable: false),
                    IntDriveCount = table.Column<int>(nullable: false),
                    Drive35Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.GuidId);
                });

            migrationBuilder.CreateTable(
                name: "CpuFans",
                columns: table => new
                {
                    GuidId = table.Column<Guid>(nullable: false),
                    StrName = table.Column<string>(nullable: false),
                    StrImg = table.Column<string>(nullable: false),
                    IntCount = table.Column<int>(nullable: false),
                    DoubCost = table.Column<double>(nullable: false),
                    IntPopularity = table.Column<int>(nullable: false),
                    StrType = table.Column<string>(nullable: false),
                    TDP = table.Column<double>(nullable: false),
                    Sockets = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CpuFans", x => x.GuidId);
                });

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    GuidId = table.Column<Guid>(nullable: false),
                    StrName = table.Column<string>(nullable: false),
                    StrImg = table.Column<string>(nullable: false),
                    IntCount = table.Column<int>(nullable: false),
                    DoubCost = table.Column<double>(nullable: false),
                    IntPopularity = table.Column<int>(nullable: false),
                    StrType = table.Column<string>(nullable: false),
                    Socket = table.Column<string>(nullable: true),
                    Frequency = table.Column<double>(nullable: false),
                    ECC = table.Column<string>(nullable: true),
                    TDP = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.GuidId);
                });

            migrationBuilder.CreateTable(
                name: "DAPairs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdOfDrive = table.Column<Guid>(nullable: false),
                    IdOfAssembly = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DAPairs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drives",
                columns: table => new
                {
                    GuidId = table.Column<Guid>(nullable: false),
                    StrName = table.Column<string>(nullable: false),
                    StrImg = table.Column<string>(nullable: false),
                    IntCount = table.Column<int>(nullable: false),
                    DoubCost = table.Column<double>(nullable: false),
                    IntPopularity = table.Column<int>(nullable: false),
                    StrType = table.Column<string>(nullable: false),
                    Size = table.Column<double>(nullable: false),
                    Volume = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drives", x => x.GuidId);
                });

            migrationBuilder.CreateTable(
                name: "FANs",
                columns: table => new
                {
                    GuidId = table.Column<Guid>(nullable: false),
                    StrName = table.Column<string>(nullable: false),
                    StrImg = table.Column<string>(nullable: false),
                    IntCount = table.Column<int>(nullable: false),
                    DoubCost = table.Column<double>(nullable: false),
                    IntPopularity = table.Column<int>(nullable: false),
                    StrType = table.Column<string>(nullable: false),
                    Size = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FANs", x => x.GuidId);
                });

            migrationBuilder.CreateTable(
                name: "FAPairs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdOfAssembly = table.Column<Guid>(nullable: false),
                    IdOfFan = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAPairs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FSPs",
                columns: table => new
                {
                    GuidId = table.Column<Guid>(nullable: false),
                    StrName = table.Column<string>(nullable: false),
                    StrImg = table.Column<string>(nullable: false),
                    IntCount = table.Column<int>(nullable: false),
                    DoubCost = table.Column<double>(nullable: false),
                    IntPopularity = table.Column<int>(nullable: false),
                    StrType = table.Column<string>(nullable: false),
                    Output = table.Column<double>(nullable: false),
                    FormFactor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FSPs", x => x.GuidId);
                });

            migrationBuilder.CreateTable(
                name: "GPUs",
                columns: table => new
                {
                    GuidId = table.Column<Guid>(nullable: false),
                    StrName = table.Column<string>(nullable: false),
                    StrImg = table.Column<string>(nullable: false),
                    IntCount = table.Column<int>(nullable: false),
                    DoubCost = table.Column<double>(nullable: false),
                    IntPopularity = table.Column<int>(nullable: false),
                    StrType = table.Column<string>(nullable: false),
                    Clock = table.Column<double>(nullable: false),
                    MemorySize = table.Column<double>(nullable: false),
                    MemoryType = table.Column<string>(nullable: true),
                    TDP = table.Column<double>(nullable: false),
                    RecommendFSPPower = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUs", x => x.GuidId);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    GuidId = table.Column<Guid>(nullable: false),
                    StrName = table.Column<string>(nullable: false),
                    StrImg = table.Column<string>(nullable: false),
                    IntCount = table.Column<int>(nullable: false),
                    DoubCost = table.Column<double>(nullable: false),
                    IntPopularity = table.Column<int>(nullable: false),
                    StrType = table.Column<string>(nullable: false),
                    Socket = table.Column<string>(nullable: true),
                    Chipset = table.Column<string>(nullable: true),
                    MemoryType = table.Column<string>(nullable: true),
                    ECC = table.Column<string>(nullable: true),
                    RAMCount = table.Column<int>(nullable: false),
                    DriveCount = table.Column<int>(nullable: false),
                    FANCount = table.Column<int>(nullable: false),
                    FormFactor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.GuidId);
                });

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    GuidId = table.Column<Guid>(nullable: false),
                    StrName = table.Column<string>(nullable: false),
                    StrImg = table.Column<string>(nullable: false),
                    IntCount = table.Column<int>(nullable: false),
                    DoubCost = table.Column<double>(nullable: false),
                    IntPopularity = table.Column<int>(nullable: false),
                    StrType = table.Column<string>(nullable: false),
                    MemorySize = table.Column<double>(nullable: false),
                    MemoryType = table.Column<string>(nullable: true),
                    ECC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.GuidId);
                });

            migrationBuilder.CreateTable(
                name: "RAPairs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdOfRam = table.Column<Guid>(nullable: false),
                    IdOfAssembly = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAPairs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assemblies");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "CpuFans");

            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "DAPairs");

            migrationBuilder.DropTable(
                name: "Drives");

            migrationBuilder.DropTable(
                name: "FANs");

            migrationBuilder.DropTable(
                name: "FAPairs");

            migrationBuilder.DropTable(
                name: "FSPs");

            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "RAMs");

            migrationBuilder.DropTable(
                name: "RAPairs");
        }
    }
}
