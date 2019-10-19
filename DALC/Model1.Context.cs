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
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
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
    
        public virtual DbSet<AUD_INGRESO> AUD_INGRESO { get; set; }
        public virtual DbSet<BOLETA> BOLETA { get; set; }
        public virtual DbSet<BOLETA_WC> BOLETA_WC { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<ESTADO> ESTADO { get; set; }
        public virtual DbSet<ESTADO_BOLETA> ESTADO_BOLETA { get; set; }
        public virtual DbSet<ESTADO_SOLICITUD> ESTADO_SOLICITUD { get; set; }
        public virtual DbSet<GIRO> GIRO { get; set; }
        public virtual DbSet<INGREDIENTE> INGREDIENTE { get; set; }
        public virtual DbSet<INGRESO> INGRESO { get; set; }
        public virtual DbSet<MENU> MENU { get; set; }
        public virtual DbSet<MESA> MESA { get; set; }
        public virtual DbSet<METRICA> METRICA { get; set; }
        public virtual DbSet<MODO_PAGO> MODO_PAGO { get; set; }
        public virtual DbSet<PEDIDO> PEDIDO { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<PRODUCTO_SOLICITUD> PRODUCTO_SOLICITUD { get; set; }
        public virtual DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual DbSet<RESERVA> RESERVA { get; set; }
        public virtual DbSet<ROL> ROL { get; set; }
        public virtual DbSet<SOLICITUD> SOLICITUD { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
    
        public virtual int PROCEDURE_ELIMINAR_PRODUCTO(string p_ID)
        {
            var p_IDParameter = p_ID != null ?
                new ObjectParameter("P_ID", p_ID) :
                new ObjectParameter("P_ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROCEDURE_ELIMINAR_PRODUCTO", p_IDParameter);
        }
    
        public virtual int PROCEDURE_ENVIAR_SOLICITUD(Nullable<decimal> p_VARIOS_PRODUCTOS, Nullable<decimal> p_ID_PRODUCTO, Nullable<decimal> p_ID_SOLICITUD, string p_ASUNTO, string p_MENSAJE, ObjectParameter p_RETORNO2)
        {
            var p_VARIOS_PRODUCTOSParameter = p_VARIOS_PRODUCTOS.HasValue ?
                new ObjectParameter("P_VARIOS_PRODUCTOS", p_VARIOS_PRODUCTOS) :
                new ObjectParameter("P_VARIOS_PRODUCTOS", typeof(decimal));
    
            var p_ID_PRODUCTOParameter = p_ID_PRODUCTO.HasValue ?
                new ObjectParameter("P_ID_PRODUCTO", p_ID_PRODUCTO) :
                new ObjectParameter("P_ID_PRODUCTO", typeof(decimal));
    
            var p_ID_SOLICITUDParameter = p_ID_SOLICITUD.HasValue ?
                new ObjectParameter("P_ID_SOLICITUD", p_ID_SOLICITUD) :
                new ObjectParameter("P_ID_SOLICITUD", typeof(decimal));
    
            var p_ASUNTOParameter = p_ASUNTO != null ?
                new ObjectParameter("P_ASUNTO", p_ASUNTO) :
                new ObjectParameter("P_ASUNTO", typeof(string));
    
            var p_MENSAJEParameter = p_MENSAJE != null ?
                new ObjectParameter("P_MENSAJE", p_MENSAJE) :
                new ObjectParameter("P_MENSAJE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROCEDURE_ENVIAR_SOLICITUD", p_VARIOS_PRODUCTOSParameter, p_ID_PRODUCTOParameter, p_ID_SOLICITUDParameter, p_ASUNTOParameter, p_MENSAJEParameter, p_RETORNO2);
        }
    
        public virtual int PROCEDURE_INGRESAR_PRODUCTO(Nullable<decimal> p_PESO, string p_MEDIDA, string p_CODIGO, string p_NOMBRE, string p_DESCRIPCION, Nullable<decimal> p_ID_PROVEEDOR, Nullable<decimal> p_ID_USUARIO)
        {
            var p_PESOParameter = p_PESO.HasValue ?
                new ObjectParameter("P_PESO", p_PESO) :
                new ObjectParameter("P_PESO", typeof(decimal));
    
            var p_MEDIDAParameter = p_MEDIDA != null ?
                new ObjectParameter("P_MEDIDA", p_MEDIDA) :
                new ObjectParameter("P_MEDIDA", typeof(string));
    
            var p_CODIGOParameter = p_CODIGO != null ?
                new ObjectParameter("P_CODIGO", p_CODIGO) :
                new ObjectParameter("P_CODIGO", typeof(string));
    
            var p_NOMBREParameter = p_NOMBRE != null ?
                new ObjectParameter("P_NOMBRE", p_NOMBRE) :
                new ObjectParameter("P_NOMBRE", typeof(string));
    
            var p_DESCRIPCIONParameter = p_DESCRIPCION != null ?
                new ObjectParameter("P_DESCRIPCION", p_DESCRIPCION) :
                new ObjectParameter("P_DESCRIPCION", typeof(string));
    
            var p_ID_PROVEEDORParameter = p_ID_PROVEEDOR.HasValue ?
                new ObjectParameter("P_ID_PROVEEDOR", p_ID_PROVEEDOR) :
                new ObjectParameter("P_ID_PROVEEDOR", typeof(decimal));
    
            var p_ID_USUARIOParameter = p_ID_USUARIO.HasValue ?
                new ObjectParameter("P_ID_USUARIO", p_ID_USUARIO) :
                new ObjectParameter("P_ID_USUARIO", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROCEDURE_INGRESAR_PRODUCTO", p_PESOParameter, p_MEDIDAParameter, p_CODIGOParameter, p_NOMBREParameter, p_DESCRIPCIONParameter, p_ID_PROVEEDORParameter, p_ID_USUARIOParameter);
        }
    
        public virtual int SP_BOLETA(Nullable<decimal> iDE)
        {
            var iDEParameter = iDE.HasValue ?
                new ObjectParameter("IDE", iDE) :
                new ObjectParameter("IDE", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_BOLETA", iDEParameter);
        }
    
        public virtual int SP_DCTO_STOCK(Nullable<decimal> pEDIDO_ID_P)
        {
            var pEDIDO_ID_PParameter = pEDIDO_ID_P.HasValue ?
                new ObjectParameter("PEDIDO_ID_P", pEDIDO_ID_P) :
                new ObjectParameter("PEDIDO_ID_P", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DCTO_STOCK", pEDIDO_ID_PParameter);
        }
    }
}
