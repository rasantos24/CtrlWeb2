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
    
    public partial class apProveedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public apProveedores()
        {
            this.apProveedoresContactos = new HashSet<apProveedoresContactos>();
            this.icRecepciones = new HashSet<icRecepciones>();
        }
    
        public string IdProveedor { get; set; }
        public string Proveedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string IdTipoProveedor { get; set; }
        public string IdMoneda { get; set; }
        public string IdFormaPago { get; set; }
        public string IdCuentaCxP { get; set; }
        public string IdPais { get; set; }
        public string IdEstado { get; set; }
        public string IdCiudad { get; set; }
        public string Direccion1 { get; set; }
        public string Direccion2 { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Fax1 { get; set; }
        public string ZipCode { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public Nullable<decimal> LimiteCredito { get; set; }
        public string NumeroRTN { get; set; }
        public string Notas { get; set; }
        public Nullable<System.DateTime> FechaCreado { get; set; }
        public bool Activo { get; set; }
    
        public virtual apFormaPago apFormaPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<apProveedoresContactos> apProveedoresContactos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<icRecepciones> icRecepciones { get; set; }
        public virtual apProveedoresTipo apProveedoresTipo { get; set; }
        public virtual bnMonedas bnMonedas { get; set; }
        public virtual glCuentas glCuentas { get; set; }
    }
}
