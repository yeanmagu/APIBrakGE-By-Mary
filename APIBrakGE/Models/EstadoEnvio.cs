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
    
    public partial class EstadoEnvio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstadoEnvio()
        {
            this.ControlEntregasInternas = new HashSet<ControlEntregasInternas>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlEntregasInternas> ControlEntregasInternas { get; set; }
    }
}
