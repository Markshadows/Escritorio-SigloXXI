﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALC
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entidades : DbContext
    {
        public Entidades()
            : base("name=Entidades")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BOLETA> BOLETA { get; set; }
        public virtual DbSet<CIUDAD> CIUDAD { get; set; }
        public virtual DbSet<COMUNA> COMUNA { get; set; }
        public virtual DbSet<DETALLE_BOLETA> DETALLE_BOLETA { get; set; }
        public virtual DbSet<DIRECCION> DIRECCION { get; set; }
        public virtual DbSet<ESTADO> ESTADO { get; set; }
        public virtual DbSet<GIRO> GIRO { get; set; }
        public virtual DbSet<INGREDIENTE> INGREDIENTE { get; set; }
        public virtual DbSet<INGRESO> INGRESO { get; set; }
        public virtual DbSet<MENU> MENU { get; set; }
        public virtual DbSet<MESA> MESA { get; set; }
        public virtual DbSet<METRICA> METRICA { get; set; }
        public virtual DbSet<MODO_PAGO> MODO_PAGO { get; set; }
        public virtual DbSet<PAIS> PAIS { get; set; }
        public virtual DbSet<PEDIDO> PEDIDO { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<RESERVA> RESERVA { get; set; }
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    }
}