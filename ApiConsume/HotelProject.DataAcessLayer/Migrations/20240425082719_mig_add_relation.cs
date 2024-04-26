using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelProject.DataAcessLayer.Migrations
{
    public partial class mig_add_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryId",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "MessageCategoryId",
                table: "Contacts",
                newName: "MessageCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_MessageCategoryId",
                table: "Contacts",
                newName: "IX_Contacts_MessageCategoryID");

            migrationBuilder.AlterColumn<int>(
                name: "MessageCategoryID",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryID",
                table: "Contacts",
                column: "MessageCategoryID",
                principalTable: "MessageCategories",
                principalColumn: "MessageCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryID",
                table: "Contacts");

            migrationBuilder.RenameColumn(
                name: "MessageCategoryID",
                table: "Contacts",
                newName: "MessageCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Contacts_MessageCategoryID",
                table: "Contacts",
                newName: "IX_Contacts_MessageCategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "MessageCategoryId",
                table: "Contacts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_MessageCategories_MessageCategoryId",
                table: "Contacts",
                column: "MessageCategoryId",
                principalTable: "MessageCategories",
                principalColumn: "MessageCategoryId");
        }
    }
}
