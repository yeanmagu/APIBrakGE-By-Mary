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
    
    public partial class MaterialesActaDetalle
    {
        public int ID { get; set; }
        public Nullable<int> IdDetalleActa { get; set; }
        public Nullable<int> IdMaterial { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<bool> Cumple { get; set; }
        public string Observaciones { get; set; }
        public Nullable<System.DateTime> FechaSistemas { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual DetalleActa DetalleActa { get; set; }
        public virtual Materiales Materiales { get; set; }
        public virtual Materiales Materiales1 { get; set; }
    }
}
