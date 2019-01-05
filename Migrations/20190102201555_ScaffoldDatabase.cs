using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigThis.Migrations
{
    public partial class ScaffoldDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DISALLOWED_PARAMETER",
                columns: table => new
                {
                    OBJECT_ID = table.Column<int>(nullable: false),
                    DISALLOWED_RULE_ID = table.Column<int>(nullable: false),
                    PARAMETER_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DISALLOWED_PARAMETER", x => x.OBJECT_ID);
                });

            migrationBuilder.CreateTable(
                name: "DISALLOWED_RULE",
                columns: table => new
                {
                    OBJECT_ID = table.Column<int>(nullable: false),
                    NAME = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DISALLOWED_RULE", x => x.OBJECT_ID);
                });

            migrationBuilder.CreateTable(
                name: "DISALLOWED_VALUE",
                columns: table => new
                {
                    OBJECT_ID = table.Column<int>(nullable: false),
                    DISALLOWED_PARAMETER_ID = table.Column<int>(nullable: false),
                    PARAMETER_VALUE_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DISALLOWED_VALUE", x => x.OBJECT_ID);
                });

            migrationBuilder.CreateTable(
                name: "PARAMETER",
                columns: table => new
                {
                    OBJECT_ID = table.Column<int>(nullable: false),
                    PRODUCT_ID = table.Column<int>(nullable: false),
                    NAME = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARAMETER", x => x.OBJECT_ID);
                });

            migrationBuilder.CreateTable(
                name: "PARAMETER_VALUE",
                columns: table => new
                {
                    OBJECT_ID = table.Column<int>(nullable: false),
                    PARAMETER_ID = table.Column<int>(nullable: false),
                    NAME = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PARAMETER_VALUE", x => x.OBJECT_ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    OBJECT_ID = table.Column<int>(nullable: false),
                    NAME = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.OBJECT_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DISALLOWED_PARAMETER");

            migrationBuilder.DropTable(
                name: "DISALLOWED_RULE");

            migrationBuilder.DropTable(
                name: "DISALLOWED_VALUE");

            migrationBuilder.DropTable(
                name: "PARAMETER");

            migrationBuilder.DropTable(
                name: "PARAMETER_VALUE");

            migrationBuilder.DropTable(
                name: "PRODUCT");
        }
    }
}
