//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMP.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CMP_MEDICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CMP_MEDICO()
        {
            this.CER_PASANTIA = new HashSet<CER_PASANTIA>();
            this.CER_POSTGRADO = new HashSet<CER_POSTGRADO>();
            this.CMP_MEDICOESP = new HashSet<CMP_MEDICOESP>();
        }
    
        public int cmedico_id { get; set; }
        public string cmedico_nrodoc { get; set; }
        public string cmedico_ncolegiatura { get; set; }
        public string vmedico_a_paterno { get; set; }
        public string vmedico_a_materno { get; set; }
        public string vmedico_nombres { get; set; }
        public string cmedico_estado { get; set; }
        public string vmedico_titulo { get; set; }
        public string vmedico_titulo_nro { get; set; }
        public string vmedico_correo { get; set; }
        public string vmedico_telefono { get; set; }
        public string vmedico_direccion { get; set; }
        public Nullable<int> ncregional_id { get; set; }
        public string cmedico_sexo { get; set; }
        public string cmedico_tipodoc { get; set; }
        public string vmedico_celular { get; set; }
        public Nullable<System.DateTime> dmedico_colegiatura { get; set; }
        public Nullable<int> ninstitucionedu_id { get; set; }
        public Nullable<System.DateTime> dmedico_nacimiento { get; set; }
        public string cmedico_recertificado { get; set; }
        public string cubigeo_cod { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CER_PASANTIA> CER_PASANTIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CER_POSTGRADO> CER_POSTGRADO { get; set; }
        public virtual CMP_CREGIONAL CMP_CREGIONAL { get; set; }
        public virtual CMP_INSTITUCIONEDU CMP_INSTITUCIONEDU { get; set; }
        public virtual CMP_UBIGEO CMP_UBIGEO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMP_MEDICOESP> CMP_MEDICOESP { get; set; }
    }
}
