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
    
    public partial class arClientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public arClientes()
        {
            this.arFacturas = new HashSet<arFacturas>();
            this.arClientesContactos = new HashSet<arClientesContactos>();
            this.arClientesDocumentos = new HashSet<arClientesDocumentos>();
        }
    
        public string IdCliente { get; set; }
        public string Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string IdTipoCliente { get; set; }
        public string IdClaseCliente { get; set; }
        public string IdTerminoCredito { get; set; }
        public string IdCuentaCxC { get; set; }
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
        public string NumeroID { get; set; }
        public string Pasaporte { get; set; }
        public string Referencia { get; set; }
        public string Notas { get; set; }
        public string NotasAlertas { get; set; }
        public Nullable<System.DateTime> FechaCreado { get; set; }
        public bool Bloqueado { get; set; }
        public bool Activo { get; set; }
        public string ApellidoCasada { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string TipoSangre { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string IdPaisNacimiento { get; set; }
        public string IdPaisNacionalidad { get; set; }
        public Nullable<int> AniosEnElPais { get; set; }
        public string NivelEstudios { get; set; }
        public string Profesion { get; set; }
        public string Ocupacion { get; set; }
        public Nullable<int> NoHijos { get; set; }
        public Nullable<int> NoDependientes { get; set; }
        public string EmpresaLabora { get; set; }
        public Nullable<System.DateTime> FechaIngresoLaboral { get; set; }
        public string PuestoLabora { get; set; }
        public string IdPaisTrabajo { get; set; }
        public string IdEstadoTrabajo { get; set; }
        public string IdCiudadTrabajo { get; set; }
        public string Direccion1Trabajo { get; set; }
        public string Direccion2Trabajo { get; set; }
        public string Telefono1Trabajo { get; set; }
        public string Telefono2Trabajo { get; set; }
        public string Fax1Trabajo { get; set; }
        public string ContactoTrabajo { get; set; }
        public Nullable<decimal> IngSalarioMes { get; set; }
        public Nullable<decimal> IngVariablesMes { get; set; }
        public Nullable<decimal> IngOtros { get; set; }
        public Nullable<decimal> IngTotal { get; set; }
        public Nullable<decimal> GastoTotalMes { get; set; }
        public Nullable<decimal> PatrimonioNeto { get; set; }
        public Nullable<decimal> TotalActivo { get; set; }
        public Nullable<decimal> TotalPasivo { get; set; }
        public string OtrosBienes { get; set; }
        public string NombreConyuge { get; set; }
        public string ApellidoConyuge { get; set; }
        public string NumeroIDConyuge { get; set; }
        public string OcupacionConyuge { get; set; }
        public Nullable<decimal> SueldoConyuge { get; set; }
        public string EmpresaConyuge { get; set; }
        public string TelefonoConyuge { get; set; }
        public Nullable<System.DateTime> pjFechaConstitucion { get; set; }
        public Nullable<System.DateTime> pjFechaInicioLabores { get; set; }
        public Nullable<bool> pjEmpresaPropia { get; set; }
        public string pjActividadEconomica { get; set; }
        public string rlRepresentateLegal { get; set; }
        public string rlApellidoCasada { get; set; }
        public string rlEstadoCivil { get; set; }
        public string rlCargo { get; set; }
        public string rlNumeroRTN { get; set; }
        public string rlNumeroID { get; set; }
        public string rlCredencial { get; set; }
        public Nullable<System.DateTime> rlFechaNacimiento { get; set; }
        public string rlIdPaisNacionalidad { get; set; }
        public string rlProfesion { get; set; }
        public string rlConsVecindad { get; set; }
        public string rlIdPais { get; set; }
        public string rlIdEstado { get; set; }
        public string rlIdCiudad { get; set; }
        public string rlDireccion1 { get; set; }
        public string rlDireccion2 { get; set; }
        public string rlTelefono1 { get; set; }
        public string rlTelefono2 { get; set; }
        public string rlEmail { get; set; }
        public bool PersonaJuridica { get; set; }
    
        public virtual glCuentas glCuentas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arFacturas> arFacturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arClientesContactos> arClientesContactos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arClientesDocumentos> arClientesDocumentos { get; set; }
        public virtual arClientesTipo arClientesTipo { get; set; }
        public virtual arTerminoCredito arTerminoCredito { get; set; }
    }
}
