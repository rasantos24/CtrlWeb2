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
    
    public partial class gcPrestamosAmorMovDet
    {
        public int NuId { get; set; }
        public int NoPrestamo { get; set; }
        public int NoCuota { get; set; }
        public int NoRecibo { get; set; }
        public System.DateTime FechaPago { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal SaldoPrestamoAnt { get; set; }
        public decimal SaldoPrestamoAct { get; set; }
        public decimal cCapitalPagado { get; set; }
        public decimal cCapitalSaldo { get; set; }
        public decimal cInteresPagado { get; set; }
        public decimal cInteresSaldo { get; set; }
        public decimal cMoraPagado { get; set; }
        public decimal cMoraSaldo { get; set; }
    
        public virtual gcPrestamos gcPrestamos { get; set; }
    }
}
