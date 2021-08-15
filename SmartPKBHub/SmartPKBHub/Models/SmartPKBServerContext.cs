using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SmartPKBHub.Models
{
    public partial class SmartPKBServerContext : DbContext
    {
        public SmartPKBServerContext()
        {
        }

        public SmartPKBServerContext(DbContextOptions<SmartPKBServerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AirConditioning> AirConditionings { get; set; }
        public virtual DbSet<Heating> Heatings { get; set; }
        public virtual DbSet<Lightning> Lightnings { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-CGRVOCM\\SQLEXPRESS; Database=SmartPKBServer; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<AirConditioning>(entity =>
            {
                entity.ToTable("AirConditioning");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nroom).HasColumnName("NRoom");
            });

            modelBuilder.Entity<Heating>(entity =>
            {
                entity.ToTable("Heating");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nroom).HasColumnName("NRoom");
            });

            modelBuilder.Entity<Lightning>(entity =>
            {
                entity.ToTable("Lightning");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nroom).HasColumnName("NRoom");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Nlux).HasColumnName("NLux");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Username);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.Salt).HasMaxLength(250);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
