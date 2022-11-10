using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MvcNotasEstudiante.Models
{
    public partial class MvcNotasEstudianteContext : DbContext
    {
        public MvcNotasEstudianteContext()
        {
        }

        public MvcNotasEstudianteContext(DbContextOptions<MvcNotasEstudianteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Nota> Notas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=SHADOWGGPT\\GERALD; Database=MvcNotasEstudiante; integrated security =true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nota>(entity =>
            {
                entity.Property(e => e.ApellidosYNombres)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Apellidos y Nombres");

                entity.Property(e => e.Carnet)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IP).HasColumnName("I P");

                entity.Property(e => e.IiP).HasColumnName("II P");

                entity.Property(e => e.NF).HasColumnName("N.F");

                entity.Property(e => e.No)
                    .HasColumnName("No.")
                    .HasComputedColumnSql("([Id])", false);

                entity.Property(e => e.Proy).HasColumnName("PROY");

                entity.Property(e => e.Sist).HasColumnName("SIST");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
