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
    
    public partial class CMP_INSTITUCIONEDU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CMP_INSTITUCIONEDU()
        {
            this.CER_POSTGRADO = new HashSet<CER_POSTGRADO>();
            this.CMP_MEDICO = new HashSet<CMP_MEDICO>();
        }
    
        public int ninstitucionedu_id { get; set; }
        public string cinstitucionedu_nombre { get; set; }
        public string cinstitucionedu_tipo { get; set; }
        public string cinstitucionedu_estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CER_POSTGRADO> CER_POSTGRADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMP_MEDICO> CMP_MEDICO { get; set; }
    }
}
