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
    
    public partial class apProveedoresContactos
    {
        public int IdContacto { get; set; }
        public string IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono1 { get; set; }
        public string Telefono2 { get; set; }
        public string Email { get; set; }
        public string Notas { get; set; }
    
        public virtual apProveedores apProveedores { get; set; }
    }
}