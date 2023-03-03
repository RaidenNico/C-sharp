using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EvaluacionContinua2.Models;

public partial class BibliotecaBdContext : DbContext
{
    public BibliotecaBdContext()
    {
    }

    public BibliotecaBdContext(DbContextOptions<BibliotecaBdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Editorial> Editorials { get; set; }

    public virtual DbSet<Inventario> Inventarios { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-21EENR1;Initial Catalog=BibliotecaBd;Integrated Security=SSPI; User ID=sa;Password=1234; integrated security=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Editorial>(entity =>
        {
            entity.HasKey(e => e.Ideditorial);

            entity.ToTable("EDITORIAL");

            entity.Property(e => e.Ideditorial).HasColumnName("IDEDITORIAL");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Comentario)
                .HasMaxLength(50)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Editorial1)
                .HasMaxLength(50)
                .HasColumnName("EDITORIAL");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nombrecontacto)
                .HasMaxLength(50)
                .HasColumnName("NOMBRECONTACTO");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<Inventario>(entity =>
        {
            entity.HasKey(e => e.Idinventario);

            entity.ToTable("INVENTARIO");

            entity.Property(e => e.Idinventario).HasColumnName("IDINVENTARIO");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(50)
                .HasColumnName("COMENTARIOS");
            entity.Property(e => e.Existencia)
                .HasMaxLength(50)
                .HasColumnName("EXISTENCIA");
            entity.Property(e => e.Idlibro).HasColumnName("IDLIBRO");
            entity.Property(e => e.Idsucursal).HasColumnName("IDSUCURSAL");

            entity.HasOne(d => d.IdlibroNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.Idlibro)
                .HasConstraintName("FK_INVENTARIO_LIBRO");

            entity.HasOne(d => d.IdsucursalNavigation).WithMany(p => p.Inventarios)
                .HasForeignKey(d => d.Idsucursal)
                .HasConstraintName("FK_INVENTARIO_SUCURSAL");
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.Idlibro);

            entity.ToTable("LIBRO");

            entity.Property(e => e.Idlibro).HasColumnName("IDLIBRO");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Anio)
                .HasMaxLength(50)
                .HasColumnName("ANIO");
            entity.Property(e => e.Autor)
                .HasMaxLength(50)
                .HasColumnName("AUTOR");
            entity.Property(e => e.Comentarios)
                .HasMaxLength(50)
                .HasColumnName("COMENTARIOS");
            entity.Property(e => e.Ideditorial).HasColumnName("IDEDITORIAL");
            entity.Property(e => e.Numpage)
                .HasMaxLength(50)
                .HasColumnName("NUMPAGE");
            entity.Property(e => e.Precio)
                .HasMaxLength(50)
                .HasColumnName("PRECIO");
            entity.Property(e => e.Titulolibro)
                .HasMaxLength(50)
                .HasColumnName("TITULOLIBRO");

            entity.HasOne(d => d.IdeditorialNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.Ideditorial)
                .HasConstraintName("FK_EDITORIAL_LIBRO");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.HasKey(e => e.Idsucursal);

            entity.ToTable("SUCURSAL");

            entity.Property(e => e.Idsucursal).HasColumnName("IDSUCURSAL");
            entity.Property(e => e.Activo).HasColumnName("ACTIVO");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(50)
                .HasColumnName("CIUDAD");
            entity.Property(e => e.Comentario)
                .HasMaxLength(50)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .HasColumnName("DIRECCION");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Nombreencargado)
                .HasMaxLength(50)
                .HasColumnName("NOMBREENCARGADO");
            entity.Property(e => e.Sucursal1)
                .HasMaxLength(50)
                .HasColumnName("SUCURSAL");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .HasColumnName("TELEFONO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
