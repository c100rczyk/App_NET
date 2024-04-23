using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardLibrary.Migrations
{
    /// <inheritdoc />
    public partial class PierwszeConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Projects_ProjectModelId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Tasks_TaskModelId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Projects_ProjectModelId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ProjectModelId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ProjectModelId",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_Persons_TaskModelId",
                table: "Person",
                newName: "IX_Person_TaskModelId");

            migrationBuilder.AlterColumn<int>(
                name: "TaskModelId",
                table: "Person",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Tasks_TaskModelId",
                table: "Person",
                column: "TaskModelId",
                principalTable: "Tasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Project_ProjectModelId",
                table: "Tasks",
                column: "ProjectModelId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Tasks_TaskModelId",
                table: "Person");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Project_ProjectModelId",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");

            migrationBuilder.RenameIndex(
                name: "IX_Person_TaskModelId",
                table: "Persons",
                newName: "IX_Persons_TaskModelId");

            migrationBuilder.AlterColumn<int>(
                name: "TaskModelId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectModelId",
                table: "Persons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ProjectModelId",
                table: "Persons",
                column: "ProjectModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Projects_ProjectModelId",
                table: "Persons",
                column: "ProjectModelId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Tasks_TaskModelId",
                table: "Persons",
                column: "TaskModelId",
                principalTable: "Tasks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Projects_ProjectModelId",
                table: "Tasks",
                column: "ProjectModelId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
