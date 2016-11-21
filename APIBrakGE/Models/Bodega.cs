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
    
    public partial class Bodega
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bodega()
        {
            this.TipoMovimiento = new HashSet<TipoMovimiento>();
        }
    
        public int ID { get; set; }
        public int IDEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Publicidad { get; set; }
        public int IdMunicipio { get; set; }
        public string Notas { get; set; }
        public int IDUsuario { get; set; }
        public System.DateTime FechaModificacion { get; set; }
        public Nullable<bool> Estado { get; set; }
        public string Responsable { get; set; }
    
        public virtual Empresa Empresa { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoMovimiento> TipoMovimiento { get; set; }
    }
}
