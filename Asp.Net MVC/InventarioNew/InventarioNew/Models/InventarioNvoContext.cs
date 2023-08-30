using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace InventarioNew.Models;

public partial class InventarioNvoContext : DbContext
{
    public InventarioNvoContext()
    {
    }

    public InventarioNvoContext(DbContextOptions<InventarioNvoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Captura> Capturas { get; set; }

    public virtual DbSet<Comuna> Comunas { get; set; }

    public virtual DbSet<Direccion> Direccions { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<EmpresaGiro> EmpresaGiros { get; set; }

    public virtual DbSet<Giro> Giros { get; set; }

    public virtual DbSet<Kardex> Kardices { get; set; }

    public virtual DbSet<Locale> Locales { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<TipoUbicacion> TipoUbicacions { get; set; }

    public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }

    public virtual DbSet<Ubicacion> Ubicacions { get; set; }

    public virtual DbSet<UserTipoUsuario> UserTipoUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-0ENCUC7\\SQLEXPRESS;Initial Catalog=InventarioNvo;Persist Security Info=False;User ID=sa;Password=10jul1982;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Captura>(entity =>
        {
            entity.HasKey(e => e.IdCaptura);

            entity.ToTable("Captura");

            entity.Property(e => e.IdCaptura).HasColumnName("idCaptura");
            entity.Property(e => e.CantidadCaptura)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidadCaptura");
            entity.Property(e => e.FechaCaptura)
                .HasColumnType("datetime")
                .HasColumnName("fechaCaptura");
            entity.Property(e => e.Idlocal).HasColumnName("idlocal");

            entity.HasOne(d => d.IdlocalNavigation).WithMany(p => p.Capturas)
                .HasForeignKey(d => d.Idlocal)
                .HasConstraintName("Locales_Captura");
        });

        modelBuilder.Entity<Comuna>(entity =>
        {
            entity.HasKey(e => e.IdComuna);

            entity.ToTable("Comuna");

            entity.Property(e => e.IdComuna).HasColumnName("idComuna");
            entity.Property(e => e.Comuna1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Comuna");
            entity.Property(e => e.IdRegion).HasColumnName("idRegion");

            entity.HasOne(d => d.IdRegionNavigation).WithMany(p => p.Comunas)
                .HasForeignKey(d => d.IdRegion)
                .HasConstraintName("Region_Comuna");
        });

        modelBuilder.Entity<Direccion>(entity =>
        {
            entity.HasKey(e => e.IdDireccion);

            entity.ToTable("Direccion");

            entity.Property(e => e.IdDireccion).HasColumnName("idDireccion");
            entity.Property(e => e.Direccion1)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.IdComuna).HasColumnName("idComuna");

            entity.HasOne(d => d.IdComunaNavigation).WithMany(p => p.Direccions)
                .HasForeignKey(d => d.IdComuna)
                .HasConstraintName("Comuna_Direccion");

            entity.HasMany(d => d.Idlocals).WithMany(p => p.IdDireccions)
                .UsingEntity<Dictionary<string, object>>(
                    "DireccionLocale",
                    r => r.HasOne<Locale>().WithMany()
                        .HasForeignKey("Idlocal")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Locales_Direccion"),
                    l => l.HasOne<Direccion>().WithMany()
                        .HasForeignKey("IdDireccion")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Direccion_DireccionLocales"),
                    j =>
                    {
                        j.HasKey("IdDireccion", "Idlocal");
                        j.ToTable("Direccion_Locales");
                    });
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.IdEmpresa);

            entity.ToTable("Empresa");

            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.NombreEmpresa)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nombreEmpresa");
            entity.Property(e => e.RutEmpresa)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("rutEmpresa");

            entity.HasMany(d => d.Idlocals).WithMany(p => p.IdEmpresas)
                .UsingEntity<Dictionary<string, object>>(
                    "EmpresaLocal",
                    r => r.HasOne<Locale>().WithMany()
                        .HasForeignKey("Idlocal")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("EmpresaLocales_Locales"),
                    l => l.HasOne<Empresa>().WithMany()
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("Empresa_EmpresaLocales"),
                    j =>
                    {
                        j.HasKey("IdEmpresa", "Idlocal");
                        j.ToTable("Empresa_Local");
                    });
        });

        modelBuilder.Entity<EmpresaGiro>(entity =>
        {
            entity.HasKey(e => new { e.IdEmpresa, e.IdGiro });

            entity.ToTable("Empresa_Giro");

            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IdGiro).HasColumnName("idGiro");

            entity.HasOne(d => d.IdGiroNavigation).WithMany(p => p.EmpresaGiros)
                .HasForeignKey(d => d.IdGiro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Giro_Empresa");
        });

        modelBuilder.Entity<Giro>(entity =>
        {
            entity.HasKey(e => e.IdGiro);

            entity.ToTable("Giro");

            entity.Property(e => e.IdGiro).HasColumnName("idGiro");
            entity.Property(e => e.GiroEmpresa)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("giroEmpresa");
        });

        modelBuilder.Entity<Kardex>(entity =>
        {
            entity.HasKey(e => e.IdKardex);

            entity.ToTable("Kardex");

            entity.Property(e => e.IdKardex).HasColumnName("idKardex");
            entity.Property(e => e.CantidadKardex)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("cantidadKardex");
            entity.Property(e => e.FechaKardex)
                .HasColumnType("datetime")
                .HasColumnName("fechaKardex");
            entity.Property(e => e.Idlocal).HasColumnName("idlocal");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("sku");

            entity.HasOne(d => d.IdlocalNavigation).WithMany(p => p.Kardices)
                .HasForeignKey(d => d.Idlocal)
                .HasConstraintName("Locales_Kardex");
        });

        modelBuilder.Entity<Locale>(entity =>
        {
            entity.HasKey(e => e.Idlocal);

            entity.Property(e => e.Idlocal).HasColumnName("idlocal");
            entity.Property(e => e.NombreLocal)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProductos);

            entity.Property(e => e.IdProductos).HasColumnName("idProductos");
            entity.Property(e => e.Clase)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("clase");
            entity.Property(e => e.DescripcionClase)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcionClase");
            entity.Property(e => e.DescripcionProductos)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("descripcionProductos");
            entity.Property(e => e.DescripcionSubClase)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcionSubClase");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
            entity.Property(e => e.IsEstado).HasColumnName("isEstado");
            entity.Property(e => e.Moneda)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("moneda");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.SubClase)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("subClase");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("Empresa_Productos");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.IdRegion);

            entity.ToTable("Region");

            entity.Property(e => e.IdRegion).HasColumnName("idRegion");
            entity.Property(e => e.Region1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Region");
        });

        modelBuilder.Entity<TipoUbicacion>(entity =>
        {
            entity.HasKey(e => e.IdTubicacion);

            entity.ToTable("TipoUbicacion");

            entity.Property(e => e.IdTubicacion).HasColumnName("idTUbicacion");
            entity.Property(e => e.Idlocal).HasColumnName("idlocal");
            entity.Property(e => e.TipoUbicacion1)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TipoUbicacion");

            entity.HasOne(d => d.IdlocalNavigation).WithMany(p => p.TipoUbicacions)
                .HasForeignKey(d => d.Idlocal)
                .HasConstraintName("Locales_TipoUbicacion");
        });

        modelBuilder.Entity<TipoUsuario>(entity =>
        {
            entity.HasKey(e => e.IdTipoUsuario);

            entity.ToTable("TipoUsuario");

            entity.Property(e => e.IdTipoUsuario)
                .ValueGeneratedNever()
                .HasColumnName("idTipoUsuario");
            entity.Property(e => e.DescripcionTipoUsuario)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("descripcionTipoUsuario");
            entity.Property(e => e.Link)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("link");
        });

        modelBuilder.Entity<Ubicacion>(entity =>
        {
            entity.HasKey(e => e.IdUbicacion);

            entity.ToTable("Ubicacion");

            entity.Property(e => e.IdUbicacion).HasColumnName("idUbicacion");
            entity.Property(e => e.Area)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("area");
            entity.Property(e => e.DescripcionUbicacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("descripcionUbicacion");
            entity.Property(e => e.Dpto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dpto");
            entity.Property(e => e.Idlocal).HasColumnName("idlocal");
            entity.Property(e => e.Lineal)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lineal");
            entity.Property(e => e.Metro)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("metro");
            entity.Property(e => e.Pasillo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("pasillo");
            entity.Property(e => e.RangoAlto).HasColumnName("rangoAlto");
            entity.Property(e => e.RangoBajo).HasColumnName("rangoBajo");

            entity.HasOne(d => d.IdlocalNavigation).WithMany(p => p.Ubicacions)
                .HasForeignKey(d => d.Idlocal)
                .HasConstraintName("Locales_Ubicacion");
        });

        modelBuilder.Entity<UserTipoUsuario>(entity =>
        {
            entity.HasKey(e => new { e.IdUser, e.IdTipoUsuario });

            entity.ToTable("User_TipoUsuario");

            entity.HasIndex(e => e.IdEmpresa, "IX_Relationship3");

            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");
            entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.UserTipoUsuarios)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("Empresa_UserTipoUsuario");

            entity.HasOne(d => d.IdTipoUsuarioNavigation).WithMany(p => p.UserTipoUsuarios)
                .HasForeignKey(d => d.IdTipoUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("TypeUser_UserTypeUser");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserTipoUsuarios)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("User_UserTypeUser");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUser);

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUser).HasColumnName("idUser");
            entity.Property(e => e.FechaCreation)
                .HasColumnType("datetime")
                .HasColumnName("fechaCreation");
            entity.Property(e => e.FechaDelete)
                .HasColumnType("datetime")
                .HasColumnName("fechaDelete");
            entity.Property(e => e.FechaUpdate)
                .HasColumnType("datetime")
                .HasColumnName("fechaUpdate");
            entity.Property(e => e.IsEstado).HasColumnName("isEstado");
            entity.Property(e => e.Password)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.User)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
