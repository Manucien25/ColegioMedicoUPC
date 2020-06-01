using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP.DAL
{
    public class CRegionalProvider
    {

        public static List<usp_List_CRegional_Result> getAllCRegional()
        {
            List<usp_List_CRegional_Result> lista = null;
            using (ColegioMPEntities db = new ColegioMPEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                lista = db.usp_List_CRegional().ToList();
            }
            return lista;
        }

        public static List<usp_Medicos_by_CRegionalID_Result> medicosByCRegional(int id)
        {
            List<usp_Medicos_by_CRegionalID_Result> lista = null;
            using (ColegioMPEntities db = new ColegioMPEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                lista = db.usp_Medicos_by_CRegionalID(id).ToList();
            }
            return lista;
        }

    }
}
