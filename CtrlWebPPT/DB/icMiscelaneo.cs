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
    
    public partial class icMiscelaneo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public icMiscelaneo()
        {
            this.icProductosEspMiscelaneo = new HashSet<icProductosEspMiscelaneo>();
        }
    
        public string IdMiscelaneo { get; set; }
        public string Descripcion { get; set; }
        public string IdTipoMiscelaneo { get; set; }
        public bool lStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icProductosEspMiscelaneo> icProductosEspMiscelaneo { get; set; }
        public virtual icTipoMiscelaneo icTipoMiscelaneo { get; set; }
    }
}
