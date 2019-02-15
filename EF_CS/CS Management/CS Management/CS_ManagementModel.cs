namespace CS_Management
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CS_ManagementModel : DbContext
    {
        public CS_ManagementModel()
            : base("name=CS_ManagementModel1")
        {
        }

        public virtual DbSet<Dijelovi> Dijelovi { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<Servis> Servis { get; set; }
        public virtual DbSet<Serviser> Serviser { get; set; }
        public virtual DbSet<Stavka_servisa> Stavka_servisa { get; set; }
        public virtual DbSet<Usluge> Usluge { get; set; }
        public virtual DbSet<Varijanta> Varijanta { get; set; }
        public virtual DbSet<Vlasnik> Vlasnik { get; set; }
        public virtual DbSet<Vlasnistvo> Vlasnistvo { get; set; }
        public virtual DbSet<Vozilo> Vozilo { get; set; }
        public virtual DbSet<voziloView> voziloView { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dijelovi>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Dijelovi>()
                .HasMany(e => e.Stavka_servisa)
                .WithOptional(e => e.Dijelovi)
                .HasForeignKey(e => e.ID_dio)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Marka>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Marka>()
                .HasMany(e => e.Model)
                .WithRequired(e => e.Marka)
                .HasForeignKey(e => e.ID_marke);

            modelBuilder.Entity<Model>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Model>()
                .HasMany(e => e.Varijanta)
                .WithRequired(e => e.Model)
                .HasForeignKey(e => e.ID_modela);

            modelBuilder.Entity<Servis>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<Servis>()
                .HasMany(e => e.Stavka_servisa)
                .WithRequired(e => e.Servis)
                .HasForeignKey(e => e.ID_servis);

            modelBuilder.Entity<Serviser>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Serviser>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Serviser>()
                .Property(e => e.Kor_ime)
                .IsUnicode(false);

            modelBuilder.Entity<Serviser>()
                .Property(e => e.Lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<Serviser>()
                .HasMany(e => e.Servis)
                .WithRequired(e => e.Serviser)
                .HasForeignKey(e => e.ID_serviser);

            modelBuilder.Entity<Usluge>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Usluge>()
                .HasMany(e => e.Stavka_servisa)
                .WithOptional(e => e.Usluge)
                .HasForeignKey(e => e.ID_usluga)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Varijanta>()
                .Property(e => e.Oznaka_motora)
                .IsUnicode(false);

            modelBuilder.Entity<Vlasnik>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Vlasnik>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Vlasnik>()
                .Property(e => e.Telefon)
                .IsUnicode(false);

            modelBuilder.Entity<Vlasnik>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Vlasnik>()
                .HasMany(e => e.Vlasnistvo)
                .WithRequired(e => e.Vlasnik)
                .HasForeignKey(e => e.ID_vlasnik);

            modelBuilder.Entity<Vozilo>()
                .Property(e => e.VIN)
                .IsUnicode(false);

            modelBuilder.Entity<Vozilo>()
                .Property(e => e.Reg_oznaka)
                .IsUnicode(false);

            modelBuilder.Entity<Vozilo>()
                .HasMany(e => e.Servis)
                .WithRequired(e => e.Vozilo)
                .HasForeignKey(e => e.ID_vozilo);

            modelBuilder.Entity<Vozilo>()
                .HasMany(e => e.Vlasnistvo)
                .WithRequired(e => e.Vozilo)
                .HasForeignKey(e => e.ID_vozilo);

            modelBuilder.Entity<voziloView>()
                .Property(e => e.VIN)
                .IsUnicode(false);

            modelBuilder.Entity<voziloView>()
                .Property(e => e.Vozilo)
                .IsUnicode(false);

            modelBuilder.Entity<voziloView>()
                .Property(e => e.Registarska_oznaka)
                .IsUnicode(false);
        }
    }
}
