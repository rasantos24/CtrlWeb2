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
    
    public partial class icProductosEspMiscelaneo
    {
        public string IdProducto { get; set; }
        public string IdTipoMiscelaneo { get; set; }
        public string IdMiscelaneo { get; set; }
    
        public virtual icMiscelaneo icMiscelaneo { get; set; }
        public virtual icProductos icProductos { get; set; }
        public virtual icTipoMiscelaneo icTipoMiscelaneo { get; set; }
    }
}
