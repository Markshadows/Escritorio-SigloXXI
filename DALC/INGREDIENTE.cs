//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class INGREDIENTE
    {
        public decimal ID { get; set; }
        public decimal CANTIDAD { get; set; }
        public string NOMBRE { get; set; }
        public decimal MENU_ID { get; set; }
        public byte PRODUCTO_ID { get; set; }
        public decimal METRICA_ID { get; set; }
    
        public virtual MENU MENU { get; set; }
        public virtual METRICA METRICA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
