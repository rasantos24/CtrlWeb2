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
    
    public partial class icAjustesDetalle
    {
        public int NuId { get; set; }
        public int NoAjuste { get; set; }
        public string IdProducto { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> TotalCosto { get; set; }
        public string IdBin { get; set; }
        public Nullable<decimal> ExistenciaAnterior { get; set; }
    
        public virtual icAjustes icAjustes { get; set; }
        public virtual icProductos icProductos { get; set; }
    }
}