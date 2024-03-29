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
    
    public partial class icDeptos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public icDeptos()
        {
            this.arFacturasDetalle = new HashSet<arFacturasDetalle>();
            this.glCuentas = new HashSet<glCuentas>();
            this.icRequisicionesSalida = new HashSet<icRequisicionesSalida>();
            this.icTipoInventarioCtasCostos = new HashSet<icTipoInventarioCtasCostos>();
            this.icTipoInventarioCtasIngresos = new HashSet<icTipoInventarioCtasIngresos>();
            this.glCuentas1 = new HashSet<glCuentas>();
            this.glCuentas2 = new HashSet<glCuentas>();
        }
    
        public string IdDepto { get; set; }
        public string Descripcion { get; set; }
        public string Telefono { get; set; }
        public bool CentroIngreso { get; set; }
        public Nullable<int> Orden { get; set; }
        public bool lStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arFacturasDetalle> arFacturasDetalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<glCuentas> glCuentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icRequisicionesSalida> icRequisicionesSalida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icTipoInventarioCtasCostos> icTipoInventarioCtasCostos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icTipoInventarioCtasIngresos> icTipoInventarioCtasIngresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<glCuentas> glCuentas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<glCuentas> glCuentas2 { get; set; }
    }
}
