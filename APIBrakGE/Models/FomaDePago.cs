//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIBrakGE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FomaDePago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FomaDePago()
        {
            this.Documentos = new HashSet<Documentos>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Id_Empresa { get; set; }
        public string Descripcion { get; set; }
        public string Explicacion { get; set; }
        public Nullable<int> DiasCredito { get; set; }
        public Nullable<int> Descuento { get; set; }
        public Nullable<decimal> PorcentajeCredito { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<bool> Credito { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos> Documentos { get; set; }
    }
}
