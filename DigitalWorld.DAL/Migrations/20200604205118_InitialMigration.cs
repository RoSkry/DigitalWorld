using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalWorld.DAL.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dimension = table.Column<string>(maxLength: 255, nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    ColourType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(maxLength: 255, nullable: false),
                    Information = table.Column<string>(maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Card_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "dbo",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GenreType = table.Column<int>(nullable: false),
                    Localization = table.Column<string>(maxLength: 255, nullable: false),
                    AgeLimit = table.Column<int>(nullable: false),
                    DevCompany = table.Column<string>(maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Game_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "dbo",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePad",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(maxLength: 255, nullable: false),
                    ButtonsCount = table.Column<int>(nullable: false),
                    Сompatibility = table.Column<string>(maxLength: 255, nullable: false),
                    Battery = table.Column<string>(maxLength: 255, nullable: false),
                    ProductSizeId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePad_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "dbo",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePad_ProductSize_ProductSizeId",
                        column: x => x.ProductSizeId,
                        principalTable: "ProductSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayStation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(maxLength: 255, nullable: false),
                    HardDiskType = table.Column<int>(nullable: false),
                    CPU = table.Column<string>(maxLength: 255, nullable: false),
                    CPUModel = table.Column<string>(maxLength: 255, nullable: false),
                    CPUFrequency = table.Column<float>(nullable: false),
                    CoreCount = table.Column<int>(nullable: false),
                    GraphicCore = table.Column<string>(maxLength: 255, nullable: false),
                    VideoMemoryVolume = table.Column<string>(maxLength: 255, nullable: false),
                    RAMVolume = table.Column<int>(nullable: false),
                    RAMType = table.Column<string>(maxLength: 255, nullable: false),
                    InternalMemoryVolume = table.Column<int>(nullable: false),
                    Сomplectation = table.Column<string>(maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ProductSizeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayStation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayStation_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "dbo",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayStation_ProductSize_ProductSizeId",
                        column: x => x.ProductSizeId,
                        principalTable: "ProductSize",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_CategoryId",
                schema: "dbo",
                table: "Card",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_CategoryId",
                schema: "dbo",
                table: "Game",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePad_CategoryId",
                schema: "dbo",
                table: "GamePad",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePad_ProductSizeId",
                schema: "dbo",
                table: "GamePad",
                column: "ProductSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayStation_CategoryId",
                schema: "dbo",
                table: "PlayStation",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayStation_ProductSizeId",
                schema: "dbo",
                table: "PlayStation",
                column: "ProductSizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Game",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GamePad",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PlayStation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ProductSize");
        }
    }
}
