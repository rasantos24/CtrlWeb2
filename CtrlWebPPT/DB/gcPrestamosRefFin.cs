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
    
    public partial class gcPrestamosRefFin
    {
        public int NuId { get; set; }
        public Nullable<int> NoPrestamo { get; set; }
        public string Nombre { get; set; }
        public string CuentaCorriente { get; set; }
        public string CuentaAhorro { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Nullable<decimal> MontoCredito { get; set; }
        public string Notas { get; set; }
    
        public virtual gcPrestamos gcPrestamos { get; set; }
    }
}
