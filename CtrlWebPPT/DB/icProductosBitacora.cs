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
    
    public partial class icProductosBitacora
    {
        public int NuId { get; set; }
        public string IdProducto { get; set; }
        public string IdAlmacen { get; set; }
        public string IdBin { get; set; }
        public string TipoTrsn { get; set; }
        public string NumeroTrsn { get; set; }
        public System.DateTime FechaTrsn { get; set; }
        public Nullable<decimal> InvPrevio { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> InvFinal { get; set; }
        public Nullable<decimal> Costo { get; set; }
        public Nullable<decimal> Total { get; set; }
        public string Notas { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime FechaCreado { get; set; }
    }
}
