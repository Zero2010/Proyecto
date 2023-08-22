using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Modelo
{
    public partial class InvProContext : DbContext
    {
        public InvProContext()
        {
        }

        public InvProContext(DbContextOptions<InvProContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AvanceCaptura> AvanceCapturas { get; set; }
        public virtual DbSet<AvanceUbicacion> AvanceUbicacions { get; set; }
        public virtual DbSet<CapturaDato> CapturaDatos { get; set; }
        public virtual DbSet<EstadoUbicacion> EstadoUbicacions { get; set; }
        public virtual DbSet<Kardex> Kardices { get; set; }
        public virtual DbSet<MaestraProducto> MaestraProductos { get; set; }
        public virtual DbSet<McapturaXCdato> McapturaXCdatos { get; set; }
        public virtual DbSet<ModificacionCaptura> ModificacionCapturas { get; set; }
        public virtual DbSet<TipoUbicacion> TipoUbicacions { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Ubicacion> Ubicacions { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioXTusuario> UsuarioXTusuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KBD8QDK\\SQLEXPRESS;Initial Catalog=InvPro;Persist Security Info=True;User ID=sa;Password=10jul1982");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvanceCaptura>(entity =>
            {
                entity.HasKey(e => e.IdAcaptura);

                entity.ToTable("AvanceCaptura");

                entity.Property(e => e.IdAcaptura).HasColumnName("IdACaptura");

                entity.Property(e => e.Porcentaje).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.PorcentajeTotal).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AvanceUbicacion>(entity =>
            {
                entity.HasKey(e => e.IdAubicacion);

                entity.ToTable("AvanceUbicacion");

                entity.Property(e => e.IdAubicacion).HasColumnName("IdAUbicacion");

                entity.Property(e => e.DescripcionUbicacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Motivo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CapturaDato>(entity =>
            {
                entity.HasKey(e => e.IdCaptura);

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionCaptura)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ean)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCaptura).HasColumnType("datetime");

                entity.Property(e => e.Local)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LugarCaptura)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.RutOperador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoInventario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Unidad)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoUbicacion>(entity =>
            {
                entity.HasKey(e => e.IdEubicacion);

                entity.ToTable("EstadoUbicacion");

                entity.Property(e => e.IdEubicacion).HasColumnName("IdEUbicacion");

                entity.Property(e => e.DescripcionEstado)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kardex>(entity =>
            {
                entity.HasKey(e => e.IdKardex);

                entity.ToTable("Kardex");

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Clase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionClase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDpto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSubClase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSubDpto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ean)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.Locales)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubClase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubDepartamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tinventario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TInventario");

                entity.Property(e => e.TipoCodBarra)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadMedida)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaestraProducto>(entity =>
            {
                entity.HasKey(e => e.IdMproducto);

                entity.Property(e => e.IdMproducto).HasColumnName("IdMProducto");

                entity.Property(e => e.Cantidad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Clase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionClase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionDpto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSubClase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionSubDpto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ean)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCarga).HasColumnType("datetime");

                entity.Property(e => e.Locales)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Marca)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Moneda)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubClase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubDepartamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tinventario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TInventario");

                entity.Property(e => e.TipoCodBarra)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UnidadMedida)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<McapturaXCdato>(entity =>
            {
                entity.HasKey(e => new { e.IdCaptura, e.IdMcaptura });

                entity.ToTable("MCaptura_x_CDatos");

                entity.HasIndex(e => e.IdUsuario, "IX_Relationship9");

                entity.Property(e => e.IdMcaptura).HasColumnName("IdMCaptura");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdCapturaNavigation)
                    .WithMany(p => p.McapturaXCdatos)
                    .HasForeignKey(d => d.IdCaptura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship7");

                entity.HasOne(d => d.IdMcapturaNavigation)
                    .WithMany(p => p.McapturaXCdatos)
                    .HasForeignKey(d => d.IdMcaptura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship8");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.McapturaXCdatos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("Relationship9");
            });

            modelBuilder.Entity<ModificacionCaptura>(entity =>
            {
                entity.HasKey(e => e.IdMcaptura);

                entity.ToTable("ModificacionCaptura");

                entity.Property(e => e.IdMcaptura).HasColumnName("IdMCaptura");

                entity.Property(e => e.Fecha1).HasColumnType("datetime");

                entity.Property(e => e.Fecha2).HasColumnType("datetime");
            });

            modelBuilder.Entity<TipoUbicacion>(entity =>
            {
                entity.HasKey(e => e.IdTubicacion);

                entity.ToTable("TipoUbicacion");

                entity.Property(e => e.IdTubicacion).HasColumnName("IdTUbicacion");

                entity.Property(e => e.DescripcionUbicacion)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdTusuario);

                entity.ToTable("TipoUsuario");

                entity.Property(e => e.IdTusuario).HasColumnName("IdTUsuario");

                entity.Property(e => e.DescripcionUsuario)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.HasKey(e => e.IdUbicacion);

                entity.ToTable("Ubicacion");

                entity.HasIndex(e => e.IdTubicacion, "IX_Relationship3");

                entity.HasIndex(e => e.IdEubicacion, "IX_Relationship4");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IdEubicacion).HasColumnName("IdEUbicacion");

                entity.Property(e => e.IdTubicacion).HasColumnName("IdTUbicacion");

                entity.Property(e => e.PorcentajeAbierto).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.PorcentajeCerrado).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.PorcentajeNulo).HasColumnType("decimal(3, 2)");

                entity.HasOne(d => d.IdEubicacionNavigation)
                    .WithMany(p => p.Ubicacions)
                    .HasForeignKey(d => d.IdEubicacion)
                    .HasConstraintName("Relationship4");

                entity.HasOne(d => d.IdTubicacionNavigation)
                    .WithMany(p => p.Ubicacions)
                    .HasForeignKey(d => d.IdTubicacion)
                    .HasConstraintName("Relationship3");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Usuario");
            });

            modelBuilder.Entity<UsuarioXTusuario>(entity =>
            {
                entity.HasKey(e => new { e.IdUsuario, e.IdTusuario });

                entity.ToTable("Usuario_x_TUsuario");

                entity.Property(e => e.IdTusuario).HasColumnName("IdTUsuario");

                entity.HasOne(d => d.IdTusuarioNavigation)
                    .WithMany(p => p.UsuarioXTusuarios)
                    .HasForeignKey(d => d.IdTusuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship2");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.UsuarioXTusuarios)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Relationship1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
