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
    
    public partial class DetalleActa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetalleActa()
        {
            this.MaterialesActaDetalle = new HashSet<MaterialesActaDetalle>();
        }
    
        public int ID { get; set; }
        public Nullable<int> IdActa { get; set; }
        public Nullable<int> IdTipoMontaje { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<bool> Cumple { get; set; }
        public string Observaciones { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<System.DateTime> FechaSistema { get; set; }
    
        public virtual Actas Actas { get; set; }
        public virtual TipoMOntaje TipoMOntaje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialesActaDetalle> MaterialesActaDetalle { get; set; }
    }
}