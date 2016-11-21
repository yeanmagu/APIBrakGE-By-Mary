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
    
    public partial class TipoMovimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoMovimiento()
        {
            this.Documentos = new HashSet<Documentos>();
        }
    
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public string Notas { get; set; }
        public Nullable<int> IdSw { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public Nullable<int> IdUsuario { get; set; }
        public Nullable<bool> ExcentoDeIva { get; set; }
    
        public virtual Bodega Bodega { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos> Documentos { get; set; }
        public virtual Sw Sw { get; set; }
        public virtual Users Users { get; set; }
    }
}
