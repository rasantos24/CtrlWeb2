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
    
    public partial class posOrdenesDetalle
    {
        public int NuId { get; set; }
        public Nullable<int> NoOrden { get; set; }
        public string TipoCodigo { get; set; }
        public string IdCodigo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Notas { get; set; }
    
        public virtual posOrdenes posOrdenes { get; set; }
    }
}
