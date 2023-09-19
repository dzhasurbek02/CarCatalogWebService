using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCatalogWebService.Migrations
{
    public partial class car_brandId_mistake_corrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BranId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_CarFeatures_CarId_FeatureId",
                table: "CarFeatures");

            migrationBuilder.RenameColumn(
                name: "BranId",
                table: "Cars",
                newName: "BrandId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BranId",
                table: "Cars",
                newName: "IX_Cars_BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarId",
                table: "CarFeatures",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_CarFeatures_CarId",
                table: "CarFeatures");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Cars",
                newName: "BranId");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                newName: "IX_Cars_BranId");

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarId_FeatureId",
                table: "CarFeatures",
                columns: new[] { "CarId", "FeatureId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BranId",
                table: "Cars",
                column: "BranId",
                principalTable: "Brands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
