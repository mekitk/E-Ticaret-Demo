using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaretDB.Migrations
{
    public partial class eticaretdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "aspnet_Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    ApplicationName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LoweredApplicationName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__aspnet_A__C93A4C9853001CA7", x => x.ApplicationId)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_SchemaVersions",
                columns: table => new
                {
                    Feature = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CompatibleSchemaVersion = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsCurrentVersion = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__aspnet_S__5A1E6BC127B4742D", x => new { x.Feature, x.CompatibleSchemaVersion });
                });

            migrationBuilder.CreateTable(
                name: "aspnet_WebEvent_Events",
                columns: table => new
                {
                    EventId = table.Column<string>(type: "char(32)", unicode: false, fixedLength: true, maxLength: 32, nullable: false),
                    EventTimeUtc = table.Column<DateTime>(type: "datetime", nullable: false),
                    EventTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    EventSequence = table.Column<decimal>(type: "decimal(19,0)", nullable: false),
                    EventOccurrence = table.Column<decimal>(type: "decimal(19,0)", nullable: false),
                    EventCode = table.Column<int>(type: "int", nullable: false),
                    EventDetailCode = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    ApplicationPath = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ApplicationVirtualPath = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    MachineName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    RequestUrl = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    ExceptionType = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Details = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__aspnet_W__7944C810AC0AAD31", x => x.EventId);
                });

            migrationBuilder.CreateTable(
                name: "Kargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SirketAdi = table.Column<string>(type: "nchar(150)", fixedLength: true, maxLength: 150, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Telefon = table.Column<string>(type: "char(15)", unicode: false, fixedLength: true, maxLength: 15, nullable: true),
                    WebSite = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    resimyol = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OzellikDeger",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adi = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nchar(500)", fixedLength: true, maxLength: 500, nullable: true),
                    OzellikTipID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzellikDeger", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiparisDurum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisDurum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_Paths",
                columns: table => new
                {
                    PathId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LoweredPath = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__aspnet_P__CD67DC58A5580190", x => x.PathId)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK__aspnet_Pa__Appli__6D0D32F4",
                        column: x => x.ApplicationId,
                        principalTable: "aspnet_Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_Roles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LoweredRoleName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__aspnet_R__8AFACE1BBB64E726", x => x.RoleId)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK__aspnet_Ro__Appli__71D1E811",
                        column: x => x.ApplicationId,
                        principalTable: "aspnet_Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    ApplicationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    LoweredUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    MobileAlias = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    IsAnonymous = table.Column<bool>(type: "bit", nullable: false),
                    LastActivityDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Password = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    isadmin = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__aspnet_U__1788CC4D161672C4", x => x.UserId)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK__aspnet_Us__Appli__25518C17",
                        column: x => x.ApplicationId,
                        principalTable: "aspnet_Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_PersonalizationAllUsers",
                columns: table => new
                {
                    PathId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageSettings = table.Column<byte[]>(type: "image", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__aspnet_P__CD67DC59183F8846", x => x.PathId);
                    table.ForeignKey(
                        name: "FK__aspnet_Pe__PathI__6E01572D",
                        column: x => x.PathId,
                        principalTable: "aspnet_Paths",
                        principalColumn: "PathId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_PersonalizationPerUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newid())"),
                    PathId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PageSettings = table.Column<byte[]>(type: "image", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__aspnet_P__3214EC060D8D8AA5", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK__aspnet_Pe__PathI__6EF57B66",
                        column: x => x.PathId,
                        principalTable: "aspnet_Paths",
                        principalColumn: "PathId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__aspnet_Pe__UserI__22751F6C",
                        column: x => x.UserId,
                        principalTable: "aspnet_Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_Profile",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PropertyNames = table.Column<string>(type: "ntext", nullable: false),
                    PropertyValuesString = table.Column<string>(type: "ntext", nullable: false),
                    PropertyValuesBinary = table.Column<byte[]>(type: "image", nullable: false),
                    LastUpdatedDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__aspnet_P__1788CC4CE6889C66", x => x.UserId);
                    table.ForeignKey(
                        name: "FK__aspnet_Pr__UserI__236943A5",
                        column: x => x.UserId,
                        principalTable: "aspnet_Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "aspnet_UsersInRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__aspnet_U__AF2760AD755FD473", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK__aspnet_Us__RoleI__73BA3083",
                        column: x => x.RoleId,
                        principalTable: "aspnet_Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__aspnet_Us__UserI__2739D489",
                        column: x => x.UserId,
                        principalTable: "aspnet_Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Musteri",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Soyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telefon = table.Column<string>(type: "char(15)", unicode: false, fixedLength: true, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteri_aspnet_Users",
                        column: x => x.Id,
                        principalTable: "aspnet_Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Begeniler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puan = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    BegeniId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Begeniler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Begeniler_Musteri",
                        column: x => x.BegeniId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Favoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FavoriId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favoriler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favoriler_Musteri",
                        column: x => x.FavoriId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MusteriAdres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriAdres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MusteriAdres_Musteri",
                        column: x => x.MusteriID,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Satis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SatisTarihi = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    ToplamTutar = table.Column<decimal>(type: "money", nullable: false),
                    SepetMi = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    KargoID = table.Column<int>(type: "int", nullable: true),
                    SiparişDurumID = table.Column<int>(type: "int", nullable: true),
                    KargoTakipNo = table.Column<string>(type: "nchar(20)", fixedLength: true, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Satis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Satis_Kargo",
                        column: x => x.KargoID,
                        principalTable: "Kargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Satis_Musteri",
                        column: x => x.MusteriID,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Satis_SiparisDurum",
                        column: x => x.SiparişDurumID,
                        principalTable: "SiparisDurum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OzellikTip",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adi = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nchar(500)", fixedLength: true, maxLength: 500, nullable: true),
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OzellikTip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OzellikTip_OzellikDeger",
                        column: x => x.Id,
                        principalTable: "OzellikDeger",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AlisFiyat = table.Column<decimal>(type: "money", nullable: false),
                    SatisFiyat = table.Column<decimal>(type: "money", nullable: false),
                    EklenmeTarihi = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    SonKullanmaTarihi = table.Column<DateTime>(type: "datetime", nullable: true),
                    KategoriID = table.Column<int>(type: "int", nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuyukYol = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    OrtaYol = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    KucukYol = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Varsayilan = table.Column<bool>(type: "bit", nullable: true),
                    SiraNo = table.Column<byte>(type: "tinyint", nullable: true),
                    UrunID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resim_Urun",
                        column: x => x.UrunID,
                        principalTable: "Urun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SatisDetay",
                columns: table => new
                {
                    SatisID = table.Column<int>(type: "int", nullable: false),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: true),
                    Fiyat = table.Column<decimal>(type: "money", nullable: true),
                    İndirim = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SatisDetay", x => new { x.SatisID, x.UrunID });
                    table.ForeignKey(
                        name: "FK_SatisDetay_Satis",
                        column: x => x.SatisID,
                        principalTable: "Satis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SatisDetay_Urun",
                        column: x => x.UrunID,
                        principalTable: "Urun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UrunOzellik",
                columns: table => new
                {
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    Ozellikler = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunOzellik_1", x => x.UrunID);
                    table.ForeignKey(
                        name: "FK_UrunOzellik_Urun",
                        column: x => x.UrunID,
                        principalTable: "Urun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Açıklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YorumId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Yorumlar_Musteri",
                        column: x => x.YorumId,
                        principalTable: "Musteri",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Yorumlar_Urun",
                        column: x => x.UrunId,
                        principalTable: "Urun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ResimID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kategori_Resim",
                        column: x => x.ResimID,
                        principalTable: "Resim",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__aspnet_A__17477DE42E7B018F",
                table: "aspnet_Applications",
                column: "LoweredApplicationName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__aspnet_A__309103310BCF8998",
                table: "aspnet_Applications",
                column: "ApplicationName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_aspnet_Paths_ApplicationId",
                table: "aspnet_Paths",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_aspnet_PersonalizationPerUser_PathId",
                table: "aspnet_PersonalizationPerUser",
                column: "PathId");

            migrationBuilder.CreateIndex(
                name: "IX_aspnet_PersonalizationPerUser_UserId",
                table: "aspnet_PersonalizationPerUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_aspnet_Roles_ApplicationId",
                table: "aspnet_Roles",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_aspnet_Users_ApplicationId",
                table: "aspnet_Users",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_aspnet_UsersInRoles_RoleId",
                table: "aspnet_UsersInRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Begeniler_BegeniId",
                table: "Begeniler",
                column: "BegeniId");

            migrationBuilder.CreateIndex(
                name: "IX_Favoriler_FavoriId",
                table: "Favoriler",
                column: "FavoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Kategori_ResimID",
                table: "Kategori",
                column: "ResimID");

            migrationBuilder.CreateIndex(
                name: "IX_MusteriAdres_MusteriID",
                table: "MusteriAdres",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_OzellikTip_KategoriID",
                table: "OzellikTip",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Resim_UrunID",
                table: "Resim",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Satis_KargoID",
                table: "Satis",
                column: "KargoID");

            migrationBuilder.CreateIndex(
                name: "IX_Satis_MusteriID",
                table: "Satis",
                column: "MusteriID");

            migrationBuilder.CreateIndex(
                name: "IX_Satis_SiparişDurumID",
                table: "Satis",
                column: "SiparişDurumID");

            migrationBuilder.CreateIndex(
                name: "IX_SatisDetay_UrunID",
                table: "SatisDetay",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_KategoriID",
                table: "Urun",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_UrunId",
                table: "Yorumlar",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlar_YorumId",
                table: "Yorumlar",
                column: "YorumId");

            migrationBuilder.AddForeignKey(
                name: "FK_OzellikTip_Kategori",
                table: "OzellikTip",
                column: "KategoriID",
                principalTable: "Kategori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Urun_Kategori",
                table: "Urun",
                column: "KategoriID",
                principalTable: "Kategori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategori_Resim",
                table: "Kategori");

            migrationBuilder.DropTable(
                name: "aspnet_PersonalizationAllUsers");

            migrationBuilder.DropTable(
                name: "aspnet_PersonalizationPerUser");

            migrationBuilder.DropTable(
                name: "aspnet_Profile");

            migrationBuilder.DropTable(
                name: "aspnet_SchemaVersions");

            migrationBuilder.DropTable(
                name: "aspnet_UsersInRoles");

            migrationBuilder.DropTable(
                name: "aspnet_WebEvent_Events");

            migrationBuilder.DropTable(
                name: "Begeniler");

            migrationBuilder.DropTable(
                name: "Favoriler");

            migrationBuilder.DropTable(
                name: "Marka");

            migrationBuilder.DropTable(
                name: "MusteriAdres");

            migrationBuilder.DropTable(
                name: "OzellikTip");

            migrationBuilder.DropTable(
                name: "SatisDetay");

            migrationBuilder.DropTable(
                name: "UrunOzellik");

            migrationBuilder.DropTable(
                name: "Yorumlar");

            migrationBuilder.DropTable(
                name: "aspnet_Paths");

            migrationBuilder.DropTable(
                name: "aspnet_Roles");

            migrationBuilder.DropTable(
                name: "OzellikDeger");

            migrationBuilder.DropTable(
                name: "Satis");

            migrationBuilder.DropTable(
                name: "Kargo");

            migrationBuilder.DropTable(
                name: "Musteri");

            migrationBuilder.DropTable(
                name: "SiparisDurum");

            migrationBuilder.DropTable(
                name: "aspnet_Users");

            migrationBuilder.DropTable(
                name: "aspnet_Applications");

            migrationBuilder.DropTable(
                name: "Resim");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
