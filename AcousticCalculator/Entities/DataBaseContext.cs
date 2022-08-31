using Microsoft.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AcousticCalculator.Entities
{
    public partial class DataBaseContext : DbContext
    {
        public DataBaseContext()
        {
        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Napowiet> Napowiet { get; set; }
        public virtual DbSet<PakSzyb> PakSzyb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=SERWER3\\WHOKNA;Database=GLOWNA_NEW;Trusted_Connection=False;User Id=excel2k18;Password=excel;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Napowiet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("napowiet");

                entity.Property(e => e.DnEW).HasColumnName("dn,e,w");

                entity.Property(e => e.Hide).HasColumnName("hide");

                entity.Property(e => e.Lp).HasColumnName("lp");

                entity.Property(e => e.Modyfwzmoc).HasColumnName("modyfwzmoc");

                entity.Property(e => e.NieDealer).HasColumnName("nie_dealer");

                entity.Property(e => e.NrArt)
                    .HasColumnName("nr_art")
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasColumnName("opis");

                entity.Property(e => e.Recno).HasColumnName("recno");

                entity.Property(e => e.RegIdx).HasColumnName("reg_idx");

                entity.Property(e => e.RegSys)
                    .HasColumnName("reg_sys")
                    .IsUnicode(false);

                entity.Property(e => e.Szosciez)
                    .HasColumnName("szosciez")
                    .HasMaxLength(50);

                entity.Property(e => e.Szskrzyd)
                    .HasColumnName("szskrzyd")
                    .HasMaxLength(50);

                entity.Property(e => e.TechWewn)
                    .HasColumnName("tech_wewn")
                    .HasMaxLength(50);

                entity.Property(e => e.TechZewn)
                    .HasColumnName("tech_zewn")
                    .HasMaxLength(50);

                entity.Property(e => e.W1)
                    .HasColumnName("w1")
                    .HasColumnType("numeric(6, 1)");

                entity.Property(e => e.W2)
                    .HasColumnName("w2")
                    .HasColumnType("numeric(5, 1)");
            });

            modelBuilder.Entity<PakSzyb>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("pak_szyb");

                entity.Property(e => e.BlokR1).HasColumnName("blok_r1");

                entity.Property(e => e.BlokR2).HasColumnName("blok_r2");

                entity.Property(e => e.BlokR3).HasColumnName("blok_r3");

                entity.Property(e => e.BlokS1).HasColumnName("blok_s1");

                entity.Property(e => e.BlokS2).HasColumnName("blok_s2");

                entity.Property(e => e.BlokS3).HasColumnName("blok_s3");

                entity.Property(e => e.BlokS4).HasColumnName("blok_s4");

                entity.Property(e => e.CenaMin).HasColumnName("cena_min");

                entity.Property(e => e.CenaWal)
                    .HasColumnName("cena_wal")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Cenazakupu).HasColumnName("cenazakupu");

                entity.Property(e => e.Cennikdopl)
                    .HasColumnName("cennikdopl")
                    .HasColumnType("numeric(7, 2)");

                entity.Property(e => e.Dostawca)
                    .HasColumnName("dostawca")
                    .HasMaxLength(50);

                entity.Property(e => e.DzwC).HasColumnName("dzw_c");

                entity.Property(e => e.DzwCtr).HasColumnName("dzw_ctr");

                entity.Property(e => e.DzwRwigu).HasColumnName("dzw_rwigu");

                entity.Property(e => e.Eksportwz).HasColumnName("eksportwz");

                entity.Property(e => e.Exlink)
                    .HasColumnName("exlink")
                    .HasMaxLength(255);

                entity.Property(e => e.FizZReki).HasColumnName("fiz_z_reki");

                entity.Property(e => e.GrupMat).HasColumnName("grup_mat");

                entity.Property(e => e.Hide).HasColumnName("hide");

                entity.Property(e => e.Hitcnt).HasColumnName("hitcnt");

                entity.Property(e => e.IzolAkust)
                    .HasColumnName("izol_akust")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.Kolo).HasColumnName("kolo");

                entity.Property(e => e.Lp).HasColumnName("lp");

                entity.Property(e => e.Lt).HasColumnName("lt");

                entity.Property(e => e.Luk).HasColumnName("luk");

                entity.Property(e => e.NieDealer).HasColumnName("nie_dealer");

                entity.Property(e => e.NrArt)
                    .HasColumnName("nr_art")
                    .HasMaxLength(50);

                entity.Property(e => e.NrArtlong)
                    .HasColumnName("nr_artlong")
                    .HasMaxLength(80);

                entity.Property(e => e.Opis).HasColumnName("opis");

                entity.Property(e => e.Opis2)
                    .HasColumnName("opis2")
                    .HasMaxLength(100);

                entity.Property(e => e.Ornament).HasColumnName("ornament");

                entity.Property(e => e.PrzenikU)
                    .HasColumnName("przenik_u")
                    .HasColumnType("numeric(4, 2)");

                entity.Property(e => e.Przenikpsi)
                    .HasColumnName("przenikpsi")
                    .HasColumnType("numeric(6, 4)");

                entity.Property(e => e.PrzepEner)
                    .HasColumnName("przep_ener")
                    .HasColumnType("numeric(5, 2)");

                entity.Property(e => e.PrzepSwia)
                    .HasColumnName("przep_swia")
                    .HasColumnType("numeric(4, 1)");

                entity.Property(e => e.Ramka1)
                    .HasColumnName("ramka1")
                    .HasMaxLength(50);

                entity.Property(e => e.Ramka2)
                    .HasColumnName("ramka2")
                    .HasMaxLength(50);

                entity.Property(e => e.Ramka3)
                    .HasColumnName("ramka3")
                    .HasMaxLength(50);

                entity.Property(e => e.Recno).HasColumnName("recno");

                entity.Property(e => e.RegIdx).HasColumnName("reg_idx");

                entity.Property(e => e.RegSys)
                    .HasColumnName("reg_sys")
                    .IsUnicode(false);

                entity.Property(e => e.Replguid)
                    .HasColumnName("replguid")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SkryptWyc)
                    .HasColumnName("skrypt_wyc")
                    .HasMaxLength(50);

                entity.Property(e => e.Skryptbszr)
                    .HasColumnName("skryptbszr")
                    .HasMaxLength(50);

                entity.Property(e => e.Szlif).HasColumnName("szlif");

                entity.Property(e => e.SzlifWal)
                    .HasColumnName("szlif_wal")
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Szyba1)
                    .HasColumnName("szyba1")
                    .HasMaxLength(50);

                entity.Property(e => e.Szyba2)
                    .HasColumnName("szyba2")
                    .HasMaxLength(50);

                entity.Property(e => e.Szyba3)
                    .HasColumnName("szyba3")
                    .HasMaxLength(50);

                entity.Property(e => e.Szyba4)
                    .HasColumnName("szyba4")
                    .HasMaxLength(50);

                entity.Property(e => e.TypPakiet)
                    .HasColumnName("typ_pakiet")
                    .HasMaxLength(50);

                entity.Property(e => e.Wgszablonu).HasColumnName("wgszablonu");

                entity.Property(e => e.Wielobok).HasColumnName("wielobok");

                entity.Property(e => e.WspolczG).HasColumnName("wspolcz_g");

                entity.Property(e => e.ZaMetr).HasColumnName("za_metr");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
