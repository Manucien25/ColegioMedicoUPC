using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CMP.DAL;

namespace CMP_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CRegionalService" in both code and config file together.
    public class CRegionalService : ICRegionalService
    {
        public List<usp_List_CRegional_Result> getAllCRegional()
        {
            return CRegionalProvider.getAllCRegional();
        }

        public List<usp_Medicos_by_CRegionalID_Result> medicosByCRegional(int id)
        {
            return CRegionalProvider.medicosByCRegional(id);
        }
    }
}
