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
    
    public partial class icAjusteClase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public icAjusteClase()
        {
            this.icAjustes = new HashSet<icAjustes>();
        }
    
        public string IdClaseAjuste { get; set; }
        public string Descripcion { get; set; }
        public string IdCuenta { get; set; }
        public bool lStatus { get; set; }
    
        public virtual glCuentas glCuentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icAjustes> icAjustes { get; set; }
    }
}
