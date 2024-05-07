using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.DBService.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageGroupLoaderInfos",
                columns: table => new
                {
                    ImageGroupId = table.Column<int>(type: "integer", nullable: false),
                    LoaderId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGroupLoaderInfos", x => new { x.ImageGroupId, x.LoaderId });
                });

            migrationBuilder.CreateTable(
                name: "ImageGroupTransferInfos",
                columns: table => new
                {
                    ImageGroupId = table.Column<int>(type: "integer", nullable: false),
                    TransferId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGroupTransferInfos", x => new { x.ImageGroupId, x.TransferId });
                });

            migrationBuilder.CreateTable(
                name: "ImageGroupTransformInfos",
                columns: table => new
                {
                    ImageGroupId = table.Column<int>(type: "integer", nullable: false),
                    TransformId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGroupTransformInfos", x => new { x.ImageGroupId, x.TransformId });
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ServiceInfoId = table.Column<int>(type: "integer", nullable: true),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageGroups_Services_ServiceInfoId",
                        column: x => x.ServiceInfoId,
                        principalTable: "Services",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LoaderInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    LookDir = table.Column<string>(type: "text", nullable: false),
                    ModeDir = table.Column<string>(type: "text", nullable: false),
                    RepeatTime = table.Column<TimeSpan>(type: "interval", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaderInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoaderInfos_Services_Id",
                        column: x => x.Id,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransferInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    SendDir = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransferInfos_Services_Id",
                        column: x => x.Id,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TransformInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Width = table.Column<double>(type: "double precision", nullable: false),
                    Height = table.Column<double>(type: "double precision", nullable: false),
                    FileType = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransformInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransformInfos_Services_Id",
                        column: x => x.Id,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false),
                    Size = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_ImageGroups_Id",
                        column: x => x.Id,
                        principalTable: "ImageGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageGroupLoaderInfo",
                columns: table => new
                {
                    ImageGroupsId = table.Column<int>(type: "integer", nullable: false),
                    LoaderInfosId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGroupLoaderInfo", x => new { x.ImageGroupsId, x.LoaderInfosId });
                    table.ForeignKey(
                        name: "FK_ImageGroupLoaderInfo_ImageGroups_ImageGroupsId",
                        column: x => x.ImageGroupsId,
                        principalTable: "ImageGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageGroupLoaderInfo_LoaderInfos_LoaderInfosId",
                        column: x => x.LoaderInfosId,
                        principalTable: "LoaderInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageGroupTransferInfo",
                columns: table => new
                {
                    ImageGroupsId = table.Column<int>(type: "integer", nullable: false),
                    TransferInfosId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGroupTransferInfo", x => new { x.ImageGroupsId, x.TransferInfosId });
                    table.ForeignKey(
                        name: "FK_ImageGroupTransferInfo_ImageGroups_ImageGroupsId",
                        column: x => x.ImageGroupsId,
                        principalTable: "ImageGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageGroupTransferInfo_TransferInfos_TransferInfosId",
                        column: x => x.TransferInfosId,
                        principalTable: "TransferInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageGroupTransformInfo",
                columns: table => new
                {
                    ImageGroupsId = table.Column<int>(type: "integer", nullable: false),
                    TransformInfosId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageGroupTransformInfo", x => new { x.ImageGroupsId, x.TransformInfosId });
                    table.ForeignKey(
                        name: "FK_ImageGroupTransformInfo_ImageGroups_ImageGroupsId",
                        column: x => x.ImageGroupsId,
                        principalTable: "ImageGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImageGroupTransformInfo_TransformInfos_TransformInfosId",
                        column: x => x.TransformInfosId,
                        principalTable: "TransformInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageGroupLoaderInfo_LoaderInfosId",
                table: "ImageGroupLoaderInfo",
                column: "LoaderInfosId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageGroups_ServiceInfoId",
                table: "ImageGroups",
                column: "ServiceInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageGroupTransferInfo_TransferInfosId",
                table: "ImageGroupTransferInfo",
                column: "TransferInfosId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageGroupTransformInfo_TransformInfosId",
                table: "ImageGroupTransformInfo",
                column: "TransformInfosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "ImageGroupLoaderInfo");

            migrationBuilder.DropTable(
                name: "ImageGroupLoaderInfos");

            migrationBuilder.DropTable(
                name: "ImageGroupTransferInfo");

            migrationBuilder.DropTable(
                name: "ImageGroupTransferInfos");

            migrationBuilder.DropTable(
                name: "ImageGroupTransformInfo");

            migrationBuilder.DropTable(
                name: "ImageGroupTransformInfos");

            migrationBuilder.DropTable(
                name: "LoaderInfos");

            migrationBuilder.DropTable(
                name: "TransferInfos");

            migrationBuilder.DropTable(
                name: "ImageGroups");

            migrationBuilder.DropTable(
                name: "TransformInfos");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
