//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CtrlWebPPT.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class gcPrestamosAmorMov
    {
        public int NuId { get; set; }
        public int NoPrestamo { get; set; }
        public int NoCuota { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal Capital { get; set; }
        public decimal Interes { get; set; }
        public decimal TotalCuota { get; set; }
        public decimal AbonoCapital { get; set; }
        public decimal Mora { get; set; }
        public decimal TotalPago { get; set; }
        public decimal Pagado { get; set; }
        public decimal SaldoPorPagar { get; set; }
        public decimal SaldoPrestamo { get; set; }
        public int DiasDeMora { get; set; }
        public bool lStatus { get; set; }
    
        public virtual gcPrestamos gcPrestamos { get; set; }
    }
}
