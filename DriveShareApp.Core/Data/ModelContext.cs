using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DriveShareApp.Core.Data
{
    public partial class ModelContext : DbContext
    {
        public ModelContext()
        {
        }

        public ModelContext(DbContextOptions<ModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cargp> Cargps { get; set; }
        public virtual DbSet<Carownergp> Carownergps { get; set; }
        public virtual DbSet<Logingp> Logingps { get; set; }
        public virtual DbSet<Passengergp> Passengergps { get; set; }
        public virtual DbSet<Rategp> Rategps { get; set; }
        public virtual DbSet<Tripgp> Tripgps { get; set; }
        public virtual DbSet<Trippassengergp> Trippassengergps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseOracle("USER ID=TAH13_User145;PASSWORD=ASDFasdf12345@;DATA SOURCE=94.56.229.181:3488/traindb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TAH13_USER145")
                .HasAnnotation("Relational:Collation", "USING_NLS_COMP");

            modelBuilder.Entity<Cargp>(entity =>
            {
                entity.HasKey(e => e.Carid)
                    .HasName("SYS_C00371243");

                entity.ToTable("CARGP");

                entity.HasIndex(e => e.Carnumber, "SYS_C00371244")
                    .IsUnique();

                entity.Property(e => e.Carid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CARID");

                entity.Property(e => e.Carmmodel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CARMMODEL");

                entity.Property(e => e.Carmodel)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CARMODEL");

                entity.Property(e => e.Carnumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CARNUMBER");

                entity.Property(e => e.Cartype)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CARTYPE");

                entity.Property(e => e.Imageliecnse)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGELIECNSE");
            });

            modelBuilder.Entity<Carownergp>(entity =>
            {
                entity.HasKey(e => e.Carownerid)
                    .HasName("SYS_C00371250");

                entity.ToTable("CAROWNERGP");

                entity.Property(e => e.Carownerid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CAROWNERID");

                entity.Property(e => e.Carid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CARID");

                entity.Property(e => e.Drivelicense)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DRIVELICENSE");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.Carownergps)
                    .HasForeignKey(d => d.Carid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("CAROWNERGP_CARID_FK");
            });

            modelBuilder.Entity<Logingp>(entity =>
            {
                entity.HasKey(e => e.Loginid)
                    .HasName("SYS_C00371246");

                entity.ToTable("LOGINGP");

                entity.HasIndex(e => e.Email, "SYS_C00371247")
                    .IsUnique();

                entity.Property(e => e.Loginid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LOGINID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Passengerid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PASSENGERID");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PASSWORD");

                entity.HasOne(d => d.Passenger)
                    .WithMany(p => p.Logingps)
                    .HasForeignKey(d => d.Passengerid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("LOGINGP_PASSENGERID_FK");
            });

            modelBuilder.Entity<Passengergp>(entity =>
            {
                entity.HasKey(e => e.Passengerid)
                    .HasName("SYS_C00371239");

                entity.ToTable("PASSENGERGP");

                entity.HasIndex(e => e.Phonenumber, "SYS_C00371240")
                    .IsUnique();

                entity.HasIndex(e => e.Username, "SYS_C00371241")
                    .IsUnique();

                entity.Property(e => e.Passengerid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PASSENGERID");

                entity.Property(e => e.Carownerid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CAROWNERID");

                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FNAME");

                entity.Property(e => e.Imagefile)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("IMAGEFILE");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LNAME");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("PHONENUMBER");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USERNAME");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("GENDER");

                entity.HasOne(d => d.Carowner)
                    .WithMany(p => p.Passengergps)
                    .HasForeignKey(d => d.Carownerid)
                    .HasConstraintName("FK_CAROWNERID");
            });

            modelBuilder.Entity<Rategp>(entity =>
            {
                entity.HasKey(e => e.Rateid)
                    .HasName("SYS_C00371254");

                entity.ToTable("RATEGP");

                entity.Property(e => e.Rateid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RATEID");

                entity.Property(e => e.Ratedesc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RATEDESC");

                entity.Property(e => e.Ratenumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("RATENUMBER");
            });

            modelBuilder.Entity<Tripgp>(entity =>
            {
                entity.HasKey(e => e.Tripid)
                    .HasName("SYS_C00371300");

                entity.ToTable("TRIPGP");

                entity.Property(e => e.Tripid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TRIPID");

                entity.Property(e => e.Carownerid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("CAROWNERID");

                entity.Property(e => e.Descreption)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCREPTION");

                entity.Property(e => e.Endpoint)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ENDPOINT");

                entity.Property(e => e.Isactive)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("ISACTIVE");

                entity.Property(e => e.Rideprice)
                    .HasColumnType("FLOAT")
                    .HasColumnName("RIDEPRICE");

                entity.Property(e => e.Seatnumber)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("SEATNUMBER");

                entity.Property(e => e.Sp1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SP1");

                entity.Property(e => e.Sp2)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SP2");

                entity.Property(e => e.Sp3)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SP3");

                entity.Property(e => e.Sp4)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SP4");

                entity.Property(e => e.Startpoint)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STARTPOINT");

                entity.Property(e => e.Triptime)
                    .HasColumnType("DATE")
                    .HasColumnName("TRIPTIME");

                entity.HasOne(d => d.Carowner)
                    .WithMany(p => p.Tripgps)
                    .HasForeignKey(d => d.Carownerid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("CAROWNERGP_CAROWNERID_FK");
            });

            modelBuilder.Entity<Trippassengergp>(entity =>
            {
                entity.HasKey(e => e.Tpid)
                    .HasName("SYS_C00371256");

                entity.ToTable("TRIPPASSENGERGP");

                entity.Property(e => e.Tpid)
                    .HasColumnType("NUMBER(38)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TPID");

                entity.Property(e => e.IsStarted)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("IS_STARTED");

                entity.Property(e => e.Passengerid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("PASSENGERID");

                entity.Property(e => e.Rateid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("RATEID");

                entity.Property(e => e.Request)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("REQUEST");

                entity.Property(e => e.Tripid)
                    .HasColumnType("NUMBER(38)")
                    .HasColumnName("TRIPID");

                entity.HasOne(d => d.Passenger)
                    .WithMany(p => p.Trippassengergps)
                    .HasForeignKey(d => d.Passengerid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("TRIPPASSENGERGPGP_PASSENGERID_FK");

                entity.HasOne(d => d.Rate)
                    .WithMany(p => p.Trippassengergps)
                    .HasForeignKey(d => d.Rateid)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("TRIPPASSENGERGPGP_RATEID_FK");

                entity.HasOne(d => d.Trip)
                    .WithMany(p => p.Trippassengergps)
                    .HasForeignKey(d => d.Tripid)
                    .HasConstraintName("TRIPGP_TRIPID_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
