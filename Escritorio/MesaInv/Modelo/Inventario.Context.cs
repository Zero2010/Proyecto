﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InvProEntities : DbContext
    {
        public InvProEntities()
            : base("name=InvProEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AvanceCaptura> AvanceCaptura { get; set; }
        public DbSet<AvanceUbicacion> AvanceUbicacion { get; set; }
        public DbSet<CapturaDatos> CapturaDatos { get; set; }
        public DbSet<EstadoUbicacion> EstadoUbicacion { get; set; }
        public DbSet<Kardex> Kardex { get; set; }
        public DbSet<MaestraProductos> MaestraProductos { get; set; }
        public DbSet<MCaptura_x_CDatos> MCaptura_x_CDatos { get; set; }
        public DbSet<ModificacionCaptura> ModificacionCaptura { get; set; }
        public DbSet<TipoUbicacion> TipoUbicacion { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Ubicacion> Ubicacion { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
