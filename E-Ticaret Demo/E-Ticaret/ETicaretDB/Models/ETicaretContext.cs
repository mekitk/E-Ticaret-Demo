using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class ETicaretContext : DbContext
    {
        public ETicaretContext()
        {
        }

        public ETicaretContext(DbContextOptions<ETicaretContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspnetApplication> AspnetApplications { get; set; }
        public virtual DbSet<AspnetPath> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; }
        public virtual DbSet<AspnetRole> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUser> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRole> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; }
        public virtual DbSet<Begeniler> Begenilers { get; set; }
        public virtual DbSet<Favoriler> Favorilers { get; set; }
        public virtual DbSet<Kargo> Kargos { get; set; }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Marka> Markas { get; set; }
        public virtual DbSet<Musteri> Musteris { get; set; }
        public virtual DbSet<MusteriAdre> MusteriAdres { get; set; }
        public virtual DbSet<OzellikDeger> OzellikDegers { get; set; }
        public virtual DbSet<OzellikTip> OzellikTips { get; set; }
        public virtual DbSet<Resim> Resims { get; set; }
        public virtual DbSet<Sati> Satis { get; set; }
        public virtual DbSet<SatisDetay> SatisDetays { get; set; }
        public virtual DbSet<SiparisDurum> SiparisDurums { get; set; }
        public virtual DbSet<Urun> Uruns { get; set; }
        public virtual DbSet<UrunOzellik> UrunOzelliks { get; set; }
        public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; }
        public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; }
        public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; }
        public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; }
        public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; }
        public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; }
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; }
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; }
        public virtual DbSet<Yorumlar> Yorumlars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-AN4DOSQ\\SQLEXPRESS;Database=eticaret;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<AspnetApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C9853001CA7")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_A__17477DE42E7B018F")
                    .IsUnique();

                entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_A__309103310BCF8998")
                    .IsUnique();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetPath>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC58A5580190")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__6D0D32F4");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC59183F8846");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUser)
                    .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__6E01572D");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC060D8D8AA5")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__6EF57B66");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__22751F6C");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4CE6889C66");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__236943A5");
            });

            modelBuilder.Entity<AspnetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1BBB64E726")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__71D1E811");
            });

            modelBuilder.Entity<AspnetSchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC127B4742D");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4D161672C4")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Isadmin).HasColumnName("isadmin");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__25518C17");
            });

            modelBuilder.Entity<AspnetUsersInRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__aspnet_U__AF2760AD755FD473");

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__73BA3083");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__2739D489");
            });

            modelBuilder.Entity<AspnetWebEventEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C810AC0AAD31");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<Begeniler>(entity =>
            {
                entity.ToTable("Begeniler");

                entity.Property(e => e.Puan)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.HasOne(d => d.Begeni)
                    .WithMany(p => p.Begenilers)
                    .HasForeignKey(d => d.BegeniId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Begeniler_Musteri");
            });

            modelBuilder.Entity<Favoriler>(entity =>
            {
                entity.ToTable("Favoriler");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Favori)
                    .WithMany(p => p.Favorilers)
                    .HasForeignKey(d => d.FavoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Favoriler_Musteri");
            });

            modelBuilder.Entity<Kargo>(entity =>
            {
                entity.ToTable("Kargo");

                entity.Property(e => e.Adres).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.SirketAdi)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsFixedLength(true);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.ToTable("Kategori");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.ResimId).HasColumnName("ResimID");

                entity.HasOne(d => d.Resim)
                    .WithMany(p => p.Kategoris)
                    .HasForeignKey(d => d.ResimId)
                    .HasConstraintName("FK_Kategori_Resim");
            });

            modelBuilder.Entity<Marka>(entity =>
            {
                entity.ToTable("Marka");

                entity.Property(e => e.Aciklama).HasMaxLength(50);

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.Resimyol)
                    .HasMaxLength(100)
                    .HasColumnName("resimyol");
            });

            modelBuilder.Entity<Musteri>(entity =>
            {
                entity.ToTable("Musteri");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Adi).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("EMail");

                entity.Property(e => e.KullaniciAdi).HasMaxLength(50);

                entity.Property(e => e.Soyadi).HasMaxLength(50);

                entity.Property(e => e.Telefon)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Musteri)
                    .HasForeignKey<Musteri>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Musteri_aspnet_Users");
            });

            modelBuilder.Entity<MusteriAdre>(entity =>
            {
                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Adres)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MusteriId).HasColumnName("MusteriID");

                entity.HasOne(d => d.Musteri)
                    .WithMany(p => p.MusteriAdres)
                    .HasForeignKey(d => d.MusteriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MusteriAdres_Musteri");
            });

            modelBuilder.Entity<OzellikDeger>(entity =>
            {
                entity.ToTable("OzellikDeger");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .IsFixedLength(true);

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.OzellikTipId).HasColumnName("OzellikTipID");
            });

            modelBuilder.Entity<OzellikTip>(entity =>
            {
                entity.ToTable("OzellikTip");

                entity.Property(e => e.Id).HasMaxLength(50);

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(500)
                    .IsFixedLength(true);

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.KategoriId).HasColumnName("KategoriID");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.OzellikTip)
                    .HasForeignKey<OzellikTip>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OzellikTip_OzellikDeger");

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.OzellikTips)
                    .HasForeignKey(d => d.KategoriId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OzellikTip_Kategori");
            });

            modelBuilder.Entity<Resim>(entity =>
            {
                entity.ToTable("Resim");

                entity.Property(e => e.BuyukYol).HasMaxLength(250);

                entity.Property(e => e.KucukYol).HasMaxLength(250);

                entity.Property(e => e.OrtaYol).HasMaxLength(250);

                entity.Property(e => e.UrunId).HasColumnName("UrunID");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.Resims)
                    .HasForeignKey(d => d.UrunId)
                    .HasConstraintName("FK_Resim_Urun");
            });

            modelBuilder.Entity<Sati>(entity =>
            {
                entity.Property(e => e.KargoId).HasColumnName("KargoID");

                entity.Property(e => e.KargoTakipNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.MusteriId).HasColumnName("MusteriID");

                entity.Property(e => e.SatisTarihi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SepetMi)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SiparişDurumId).HasColumnName("SiparişDurumID");

                entity.Property(e => e.ToplamTutar).HasColumnType("money");

                entity.HasOne(d => d.Kargo)
                    .WithMany(p => p.Satis)
                    .HasForeignKey(d => d.KargoId)
                    .HasConstraintName("FK_Satis_Kargo");

                entity.HasOne(d => d.Musteri)
                    .WithMany(p => p.Satis)
                    .HasForeignKey(d => d.MusteriId)
                    .HasConstraintName("FK_Satis_Musteri");

                entity.HasOne(d => d.SiparişDurum)
                    .WithMany(p => p.Satis)
                    .HasForeignKey(d => d.SiparişDurumId)
                    .HasConstraintName("FK_Satis_SiparisDurum");
            });

            modelBuilder.Entity<SatisDetay>(entity =>
            {
                entity.HasKey(e => new { e.SatisId, e.UrunId });

                entity.ToTable("SatisDetay");

                entity.Property(e => e.SatisId).HasColumnName("SatisID");

                entity.Property(e => e.UrunId).HasColumnName("UrunID");

                entity.Property(e => e.Fiyat).HasColumnType("money");

                entity.HasOne(d => d.Satis)
                    .WithMany(p => p.SatisDetays)
                    .HasForeignKey(d => d.SatisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SatisDetay_Satis");

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.SatisDetays)
                    .HasForeignKey(d => d.UrunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SatisDetay_Urun");
            });

            modelBuilder.Entity<SiparisDurum>(entity =>
            {
                entity.ToTable("SiparisDurum");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Adi).HasMaxLength(50);
            });

            modelBuilder.Entity<Urun>(entity =>
            {
                entity.ToTable("Urun");

                entity.Property(e => e.Aciklama).HasMaxLength(500);

                entity.Property(e => e.Adi)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);

                entity.Property(e => e.AlisFiyat).HasColumnType("money");

                entity.Property(e => e.EklenmeTarihi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.KategoriId).HasColumnName("KategoriID");

                entity.Property(e => e.Marka).HasMaxLength(50);

                entity.Property(e => e.SatisFiyat).HasColumnType("money");

                entity.Property(e => e.SonKullanmaTarihi).HasColumnType("datetime");

                entity.HasOne(d => d.Kategori)
                    .WithMany(p => p.Uruns)
                    .HasForeignKey(d => d.KategoriId)
                    .HasConstraintName("FK_Urun_Kategori");
            });

            modelBuilder.Entity<UrunOzellik>(entity =>
            {
                entity.HasKey(e => e.UrunId)
                    .HasName("PK_UrunOzellik_1");

                entity.ToTable("UrunOzellik");

                entity.Property(e => e.UrunId)
                    .ValueGeneratedNever()
                    .HasColumnName("UrunID");

                entity.HasOne(d => d.Urun)
                    .WithOne(p => p.UrunOzellik)
                    .HasForeignKey<UrunOzellik>(d => d.UrunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UrunOzellik_Urun");
            });

            modelBuilder.Entity<VwAspnetApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Yorumlar>(entity =>
            {
                entity.ToTable("Yorumlar");

                entity.Property(e => e.Açıklama).IsRequired();

                entity.HasOne(d => d.Urun)
                    .WithMany(p => p.Yorumlars)
                    .HasForeignKey(d => d.UrunId)
                    .HasConstraintName("FK_Yorumlar_Urun");

                entity.HasOne(d => d.Yorum)
                    .WithMany(p => p.Yorumlars)
                    .HasForeignKey(d => d.YorumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Yorumlar_Musteri");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
