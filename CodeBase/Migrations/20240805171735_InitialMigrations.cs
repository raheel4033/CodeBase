using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeBase.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PinCodes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GetEmailCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EnterPhoneCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PinCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrivacyPolicies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgreeToTermsAndConditions = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivacyPolicies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CreateAccounts",
                columns: table => new
                {
                    NicNumber = table.Column<long>(type: "bigint", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateAccounts", x => x.NicNumber);
                    table.ForeignKey(
                        name: "FK_CreateAccounts_PinCodes_NicNumber",
                        column: x => x.NicNumber,
                        principalTable: "PinCodes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateAccounts");

            migrationBuilder.DropTable(
                name: "PrivacyPolicies");

            migrationBuilder.DropTable(
                name: "PinCodes");
        }
    }
}
