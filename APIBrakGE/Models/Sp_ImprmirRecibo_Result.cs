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
    
    public partial class Sp_ImprmirRecibo_Result
    {
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdAcuerdo { get; set; }
        public int IdFactura { get; set; }
        public string ModoPago { get; set; }
        public int NroCuota { get; set; }
        public string Usuario { get; set; }
        public decimal ValorDevuelto { get; set; }
        public decimal ValorRecibido { get; set; }
        public decimal ValorTotal { get; set; }
        public string Notas { get; set; }
        public string Cliente { get; set; }
        public string NroDocumento { get; set; }
        public decimal Total { get; set; }
        public Nullable<decimal> SaldoPendiente { get; set; }
    }
}