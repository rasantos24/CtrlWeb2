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
    
    public partial class icRequisicionesTransf
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public icRequisicionesTransf()
        {
            this.icRequisicionesTransfDetalle = new HashSet<icRequisicionesTransfDetalle>();
        }
    
        public int NoReqTransf { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string IdAlmacenOrigen { get; set; }
        public string IdAlmacenDestino { get; set; }
        public string IdClaseRequisicion { get; set; }
        public string Referencia { get; set; }
        public string Notas { get; set; }
        public string IdUsuarioCreado { get; set; }
        public string IdUsuarioProcesado { get; set; }
        public string IdUsuarioRecibido { get; set; }
        public System.DateTime FechaCreado { get; set; }
        public string cStatus { get; set; }
    
        public virtual icAlmacenes icAlmacenes { get; set; }
        public virtual icAlmacenes icAlmacenes1 { get; set; }
        public virtual icRequisicionClase icRequisicionClase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icRequisicionesTransfDetalle> icRequisicionesTransfDetalle { get; set; }
    }
}
