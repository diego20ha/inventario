﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventario
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class inventarioEntities : DbContext
    {
        public inventarioEntities()
            : base("name=inventarioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<cliente> clientes { get; set; }
        public DbSet<entradaTarima> entradaTarimas { get; set; }
        public DbSet<inventario> inventarios { get; set; }
        public DbSet<ordenOrigen> ordenOrigens { get; set; }
        public DbSet<ordenResultado> ordenResultadoes { get; set; }
        public DbSet<ordenTrabajo> ordenTrabajoes { get; set; }
        public DbSet<proceso> procesoes { get; set; }
        public DbSet<reciboEntrada> reciboEntradas { get; set; }
        public DbSet<reciboEntradaSaco> reciboEntradaSacos { get; set; }
        public DbSet<reciboSalida> reciboSalidas { get; set; }
        public DbSet<reciboSalidaOrigen> reciboSalidaOrigens { get; set; }
        public DbSet<reciboSalidaSaco> reciboSalidaSacos { get; set; }
        public DbSet<rol> rols { get; set; }
        public DbSet<salidaTarima> salidaTarimas { get; set; }
        public DbSet<usuario> usuarios { get; set; }
    
        public virtual ObjectResult<Nullable<int>> getLastReciboEntradaID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getLastReciboEntradaID");
        }
    
        public virtual ObjectResult<Nullable<int>> getLastReciboSalidaID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("getLastReciboSalidaID");
        }
    }
}
