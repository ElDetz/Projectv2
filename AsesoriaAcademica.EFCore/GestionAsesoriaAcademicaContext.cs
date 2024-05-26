using System;
using System.Collections.Generic;
using AsesoriaAcademica.Entities.POCOS;
using Microsoft.EntityFrameworkCore;

namespace AsesoriaAcademica.EFCore;

public partial class GestionAsesoriaAcademicaContext : DbContext
{
    public GestionAsesoriaAcademicaContext()
    {
    }

    public GestionAsesoriaAcademicaContext(DbContextOptions<GestionAsesoriaAcademicaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asesore> Asesores { get; set; }

    public virtual DbSet<Cita> Citas { get; set; }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("server=DESKTOP-BTD8DEL;database=GestionAsesoriaAcademica;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asesore>(entity =>
        {
            entity.HasKey(e => e.AsesorId).HasName("PK__Asesores__B4F3918C180BE756");

            entity.HasIndex(e => e.Email, "UQ__Asesores__A9D1053474190129").IsUnique();

            entity.Property(e => e.AsesorId).HasColumnName("AsesorID");
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Departamento).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        modelBuilder.Entity<Cita>(entity =>
        {
            entity.HasKey(e => e.CitaId).HasName("PK__Citas__F0E2D9F25AE5FA1A");

            entity.Property(e => e.CitaId).HasColumnName("CitaID");
            entity.Property(e => e.AsesorId).HasColumnName("AsesorID");
            entity.Property(e => e.EstudianteId).HasColumnName("EstudianteID");
            entity.Property(e => e.FechaHora).HasColumnType("datetime");
            entity.Property(e => e.Motivo).HasMaxLength(255);

            entity.HasOne(d => d.Asesor).WithMany(p => p.Cita)
                .HasForeignKey(d => d.AsesorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Citas_Asesores");

            entity.HasOne(d => d.Estudiante).WithMany(p => p.Cita)
                .HasForeignKey(d => d.EstudianteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Citas_Estudiantes");
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.EstudianteId).HasName("PK__Estudian__6F768338D0D9EF03");

            entity.HasIndex(e => e.Email, "UQ__Estudian__A9D105348643CF24").IsUnique();

            entity.Property(e => e.EstudianteId).HasColumnName("EstudianteID");
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(15);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
