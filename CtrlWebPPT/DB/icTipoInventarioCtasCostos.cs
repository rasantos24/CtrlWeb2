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
    
    public partial class icTipoInventarioCtasCostos
    {
        public string IdTipoInventario { get; set; }
        public string IdDepto { get; set; }
        public string IdCuenta { get; set; }
    
        public virtual glCuentas glCuentas { get; set; }
        public virtual icDeptos icDeptos { get; set; }
        public virtual icTipoInventario icTipoInventario { get; set; }
    }
}
