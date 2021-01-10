using Microsoft.EntityFrameworkCore.Migrations;

namespace PlatformForJobSeeking.Migrations
{
    public partial class AddForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegionId",
                table: "Towns",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TownId",
                table: "CustomerSeekers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CustomerSeekers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TownId",
                table: "CustomerEmployers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CustomerEmployers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TownId",
                table: "Adverts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Towns_RegionId",
                table: "Towns",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSeekers_TownId",
                table: "CustomerSeekers",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSeekers_UserId",
                table: "CustomerSeekers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEmployers_TownId",
                table: "CustomerEmployers",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEmployers_UserId",
                table: "CustomerEmployers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Adverts_TownId",
                table: "Adverts",
                column: "TownId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adverts_Towns_TownId",
                table: "Adverts",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerEmployers_Towns_TownId",
                table: "CustomerEmployers",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerEmployers_Users_UserId",
                table: "CustomerEmployers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerSeekers_Towns_TownId",
                table: "CustomerSeekers",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerSeekers_Users_UserId",
                table: "CustomerSeekers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Regions_RegionId",
                table: "Towns",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adverts_Towns_TownId",
                table: "Adverts");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerEmployers_Towns_TownId",
                table: "CustomerEmployers");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerEmployers_Users_UserId",
                table: "CustomerEmployers");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerSeekers_Towns_TownId",
                table: "CustomerSeekers");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerSeekers_Users_UserId",
                table: "CustomerSeekers");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Regions_RegionId",
                table: "Towns");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Towns_RegionId",
                table: "Towns");

            migrationBuilder.DropIndex(
                name: "IX_CustomerSeekers_TownId",
                table: "CustomerSeekers");

            migrationBuilder.DropIndex(
                name: "IX_CustomerSeekers_UserId",
                table: "CustomerSeekers");

            migrationBuilder.DropIndex(
                name: "IX_CustomerEmployers_TownId",
                table: "CustomerEmployers");

            migrationBuilder.DropIndex(
                name: "IX_CustomerEmployers_UserId",
                table: "CustomerEmployers");

            migrationBuilder.DropIndex(
                name: "IX_Adverts_TownId",
                table: "Adverts");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RegionId",
                table: "Towns");

            migrationBuilder.DropColumn(
                name: "TownId",
                table: "CustomerSeekers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CustomerSeekers");

            migrationBuilder.DropColumn(
                name: "TownId",
                table: "CustomerEmployers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CustomerEmployers");

            migrationBuilder.DropColumn(
                name: "TownId",
                table: "Adverts");
        }
    }
}
