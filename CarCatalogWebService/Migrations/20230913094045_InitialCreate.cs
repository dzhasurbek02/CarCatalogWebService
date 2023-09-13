using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarCatalogWebService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyStyles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyStyles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarColors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarColors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BrandId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriveTrains",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriveTrains", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    LastLoginDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BranId = table.Column<Guid>(type: "uuid", nullable: false),
                    CarModelId = table.Column<Guid>(type: "uuid", nullable: false),
                    BodyStyleId = table.Column<Guid>(type: "uuid", nullable: false),
                    Year = table.Column<short>(type: "smallint", nullable: false),
                    Set = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    EngineCapacity = table.Column<float>(type: "real", nullable: false),
                    HorsePower = table.Column<int>(type: "integer", nullable: false),
                    FuelTypeId = table.Column<Guid>(type: "uuid", nullable: false),
                    TransmissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    DriveTrainId = table.Column<Guid>(type: "uuid", nullable: false),
                    CarColorId = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_BodyStyles_BodyStyleId",
                        column: x => x.BodyStyleId,
                        principalTable: "BodyStyles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BranId",
                        column: x => x.BranId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_CarColors_CarColorId",
                        column: x => x.CarColorId,
                        principalTable: "CarColors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_CarModels_CarModelId",
                        column: x => x.CarModelId,
                        principalTable: "CarModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_DriveTrains_DriveTrainId",
                        column: x => x.DriveTrainId,
                        principalTable: "DriveTrains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarFeatures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CarId = table.Column<Guid>(type: "uuid", nullable: false),
                    FeatureId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarFeatures_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarFeatures_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CarId = table.Column<Guid>(type: "uuid", nullable: false),
                    PhotoURL = table.Column<string>(type: "text", nullable: false),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    UpdatedByUserId = table.Column<Guid>(type: "uuid", nullable: true),
                    DeletedByUserId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_CarId_FeatureId",
                table: "CarFeatures",
                columns: new[] { "CarId", "FeatureId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarFeatures_FeatureId",
                table: "CarFeatures",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BodyStyleId",
                table: "Cars",
                column: "BodyStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BranId",
                table: "Cars",
                column: "BranId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarColorId",
                table: "Cars",
                column: "CarColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarModelId",
                table: "Cars",
                column: "CarModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_DriveTrainId",
                table: "Cars",
                column: "DriveTrainId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FuelTypeId",
                table: "Cars",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TransmissionId",
                table: "Cars",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_CarId",
                table: "Photos",
                column: "CarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarFeatures");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "BodyStyles");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "CarColors");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "DriveTrains");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Transmissions");
        }
    }
}
