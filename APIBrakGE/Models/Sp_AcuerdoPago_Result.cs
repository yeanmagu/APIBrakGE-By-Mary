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
    
    public partial class Sp_AcuerdoPago_Result
    {
        public int NroFactura { get; set; }
        public string Cliente { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public int NroAcuerdo { get; set; }
        public Nullable<System.DateTime> FechaAcuerdo { get; set; }
        public Nullable<int> DiasPago { get; set; }
        public string ModoPago { get; set; }
        public Nullable<int> NroCuotas { get; set; }
        public Nullable<bool> Estado { get; set; }
        public string Usuario { get; set; }
        public int NroCuota { get; set; }
        public string Fecha { get; set; }
        public decimal SaldoCapital { get; set; }
        public Nullable<decimal> ValorAPagar { get; set; }
        public decimal SaldoPendiente { get; set; }
    }
}
