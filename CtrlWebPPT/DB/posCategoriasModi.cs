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
    
    public partial class posCategoriasModi
    {
        public int NuId { get; set; }
        public string IdCategoria { get; set; }
        public string LabelBoton { get; set; }
        public Nullable<decimal> FontSize { get; set; }
        public Nullable<int> NoBoton { get; set; }
    
        public virtual posCategorias posCategorias { get; set; }
    }
}
