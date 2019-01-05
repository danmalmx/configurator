using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigThis.Migrations
{
    public partial class PopulateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO DISALLOWED_PARAMETER (OBJECT_ID, DISALLOWED_RULE_ID, PARAMETER_ID) VALUES (1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_PARAMETER (OBJECT_ID, DISALLOWED_RULE_ID, PARAMETER_ID) VALUES (2, 1, 2)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_PARAMETER (OBJECT_ID, DISALLOWED_RULE_ID, PARAMETER_ID) VALUES (3, 2, 3)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_PARAMETER (OBJECT_ID, DISALLOWED_RULE_ID, PARAMETER_ID) VALUES (4, 2, 4)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_PARAMETER (OBJECT_ID, DISALLOWED_RULE_ID, PARAMETER_ID) VALUES (5, 3, 3)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_PARAMETER (OBJECT_ID, DISALLOWED_RULE_ID, PARAMETER_ID) VALUES (6, 3, 4)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_PARAMETER (OBJECT_ID, DISALLOWED_RULE_ID, PARAMETER_ID) VALUES (7, 4, 1)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_PARAMETER (OBJECT_ID, DISALLOWED_RULE_ID, PARAMETER_ID) VALUES (8, 4, 3)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_RULE (OBJECT_ID, NAME) VALUES (1, N'Not all lift types are made for outdoor execution')");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_RULE (OBJECT_ID, NAME) VALUES (2, N'50 Hz power supply is not used in all countries')");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_RULE (OBJECT_ID, NAME) VALUES (3, N'60 Hz power supply is not used in all countries')");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_RULE (OBJECT_ID, NAME) VALUES (4, N'Aritco 4000 is not available with 380 V, 60 Hz')");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (1, 1, 2)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (2, 1, 4)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (3, 2, 5)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (4, 3, 7)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (5, 3, 10)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (6, 4, 14)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (7, 4, 15)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (8, 5, 8)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (9, 5, 9)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (10, 6, 11)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (11, 6, 12)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (12, 6, 13)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (13, 7, 1)");
            migrationBuilder.Sql("INSERT INTO DISALLOWED_VALUE (OBJECT_ID, DISALLOWED_PARAMETER_ID, PARAMETER_VALUE_ID) VALUES (14, 8, 9)");
            migrationBuilder.Sql("INSERT INTO PARAMETER (OBJECT_ID, PRODUCT_ID, NAME) VALUES (1, 1, N'Lift type')");
            migrationBuilder.Sql("INSERT INTO PARAMETER (OBJECT_ID, PRODUCT_ID, NAME) VALUES (2, 1, N'Outdoor')");
            migrationBuilder.Sql("INSERT INTO PARAMETER (OBJECT_ID, PRODUCT_ID, NAME) VALUES (3, 1, N'Power supply')");
            migrationBuilder.Sql("INSERT INTO PARAMETER (OBJECT_ID, PRODUCT_ID, NAME) VALUES (4, 1, N'Country of installation')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (1, 1, N'4000')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (2, 1, N'6000')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (3, 1, N'7000')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (4, 1, N'9000')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (5, 2, N'Yes')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (6, 2, N'No')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (7, 3, N'230 V, 1-phase, 50 Hz')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (8, 3, N'230 V, 3-phase, 60 Hz')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (9, 3, N'380 V, 3-phase, 60 Hz')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (10, 3, N'400 V, 3-phase, 50 Hz')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (11, 4, N'Austria')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (12, 4, N'Netherlands')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (13, 4, N'Sweden')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (14, 4, N'United States')");
            migrationBuilder.Sql("INSERT INTO PARAMETER_VALUE (OBJECT_ID, PARAMETER_ID, NAME) VALUES (15, 4, N'Taiwan')");
            migrationBuilder.Sql("INSERT INTO PRODUCT (OBJECT_ID, NAME) VALUES (1, N'Lift')");
            migrationBuilder.Sql("INSERT INTO PRODUCT (OBJECT_ID, NAME) VALUES (2, N'Elevator')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
