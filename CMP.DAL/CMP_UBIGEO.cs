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
    
    public partial class CMP_UBIGEO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CMP_UBIGEO()
        {
            this.CMP_MEDICO = new HashSet<CMP_MEDICO>();
        }
    
        public string CUBIGEO_COD { get; set; }
        public string VUBIGEO_DEPARTAMENTO { get; set; }
        public string VUBIGEO_PROVINCIA { get; set; }
        public string VUBIGEO_DISTRITO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CMP_MEDICO> CMP_MEDICO { get; set; }
    }
}
