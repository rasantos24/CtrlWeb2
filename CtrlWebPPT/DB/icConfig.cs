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
    
    public partial class icConfig
    {
        public string IdConfig { get; set; }
        public int ProximoNoRecepcion { get; set; }
        public bool NoRecepcionBloqueado { get; set; }
        public int ProximoNoReqSalida { get; set; }
        public bool NoReqSalidaBloqueado { get; set; }
        public bool ReqSalidaPrintTk { get; set; }
        public int ProximoNoReqTransf { get; set; }
        public bool NoReqTransfBloqueado { get; set; }
        public bool ReqTransPrintTk { get; set; }
        public int ProximoNoAjuste { get; set; }
        public bool NoAjusteBloqueado { get; set; }
        public int ProximoNoInventario { get; set; }
        public bool NoInventarioBloqueado { get; set; }
        public bool AutoIdProducto { get; set; }
        public int ProximoIdProducto { get; set; }
        public bool IdProductoBloqueado { get; set; }
        public bool CalculoPrecioEnRecepcion { get; set; }
        public bool UsarCuentasContables { get; set; }
    }
}