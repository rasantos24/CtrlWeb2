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
    
    public partial class icAlmacenes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public icAlmacenes()
        {
            this.arFacturas = new HashSet<arFacturas>();
            this.icAjustes = new HashSet<icAjustes>();
            this.icBines = new HashSet<icBines>();
            this.icInventarioFisico = new HashSet<icInventarioFisico>();
            this.icProductosInventario = new HashSet<icProductosInventario>();
            this.icRecepciones = new HashSet<icRecepciones>();
            this.icRequisicionesSalida = new HashSet<icRequisicionesSalida>();
            this.icRequisicionesTransf = new HashSet<icRequisicionesTransf>();
            this.icRequisicionesTransf1 = new HashSet<icRequisicionesTransf>();
            this.posTurnos = new HashSet<posTurnos>();
        }
    
        public string IdAlmacen { get; set; }
        public string Descripcion { get; set; }
        public string Telefono { get; set; }
        public string IdCuenta { get; set; }
        public bool ControlaLote { get; set; }
        public bool Facturar { get; set; }
        public bool FacturarNegativo { get; set; }
        public bool lStatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arFacturas> arFacturas { get; set; }
        public virtual glCuentas glCuentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icAjustes> icAjustes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icBines> icBines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icInventarioFisico> icInventarioFisico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icProductosInventario> icProductosInventario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icRecepciones> icRecepciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icRequisicionesSalida> icRequisicionesSalida { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icRequisicionesTransf> icRequisicionesTransf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icRequisicionesTransf> icRequisicionesTransf1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<posTurnos> posTurnos { get; set; }
    }
}
