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
    
    public partial class gcPrestamosTipoReq
    {
        public int NuId { get; set; }
        public string IdTipoPrestamo { get; set; }
        public string IdRequisito { get; set; }
    
        public virtual gcPrestamosTipo gcPrestamosTipo { get; set; }
    }
}
