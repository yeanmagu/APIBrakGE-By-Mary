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
    
    public partial class Nomina
    {
        public int ID { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
        public Nullable<System.DateTime> Fecha1 { get; set; }
        public Nullable<System.DateTime> Fecha2 { get; set; }
        public System.DateTime FechaSistema { get; set; }
        public int IdUsuario { get; set; }
        public Nullable<decimal> SueldoNeto { get; set; }
        public string Detalle { get; set; }
    
        public virtual Personas Personas { get; set; }
        public virtual Users Users { get; set; }
    }
}
