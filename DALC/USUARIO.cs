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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.INGRESO = new HashSet<INGRESO>();
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public decimal ID { get; set; }
        public string RUN { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public string CORREO { get; set; }
        public string PASSWORD { get; set; }
        public decimal TELEFONO { get; set; }
        public decimal ROL_ID { get; set; }
        public System.DateTime CREATED_AT { get; set; }
        public System.DateTime UPDATE_AT { get; set; }
        public decimal DIRECCION_ID { get; set; }
    
        public virtual DIRECCION DIRECCION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESO> INGRESO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVA> RESERVA { get; set; }
        public virtual ROL ROL { get; set; }
    }
}
