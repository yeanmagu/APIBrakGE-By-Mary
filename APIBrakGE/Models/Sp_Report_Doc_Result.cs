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
    
    public partial class Sp_Report_Doc_Result
    {
        public Nullable<int> NroId { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string NroDocumento { get; set; }
        public string Codigo { get; set; }
        public string Item { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public decimal Total { get; set; }
        public decimal TotalIva { get; set; }
        public decimal TotalSub { get; set; }
        public decimal Porcentaje { get; set; }
        public string FormaPago { get; set; }
        public string Ciudad { get; set; }
        public string TipoMovimiento { get; set; }
        public string EstadoDocumento { get; set; }
        public Nullable<System.DateTime> FechaSistema { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<decimal> Descuento { get; set; }
    }
}