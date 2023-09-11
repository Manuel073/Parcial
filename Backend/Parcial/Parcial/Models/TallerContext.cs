using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Parcial.Models;

public partial class TallerContext : DbContext
{
    public TallerContext()
    {
    }

    public TallerContext(DbContextOptions<TallerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Mecanico> Mecanicos { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=MANUEL\\SQLEXPRESS; Database=Taller; Trusted_Connection=True;Encrypt=False;TrustServerCertificate=Yes ");
    }
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdMecanico)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NombreClien)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_clien");
        });

        modelBuilder.Entity<Mecanico>(entity =>
        {
            entity.HasKey(e => e.IdMecanico);

            entity.ToTable("Mecanico");

            entity.Property(e => e.IdMecanico).HasColumnName("id_mecanico");
            entity.Property(e => e.NombreMecan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_mecan");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.HasKey(e => e.IdVehiculos);

            entity.ToTable("Vehiculo");

            entity.Property(e => e.IdVehiculos).HasColumnName("id_vehiculos");
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("color");
            entity.Property(e => e.Matricula)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("matricula");
            entity.Property(e => e.Modelo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("modelo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
