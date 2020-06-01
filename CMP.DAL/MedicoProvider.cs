using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP.DAL
{
    public class MedicoProvider
    {

        public static List<usp_Especialidad_By_MedicoID_Result> especialidadesMedico(int id)
        {
            List<usp_Especialidad_By_MedicoID_Result> lista = null;
            using (ColegioMPEntities db = new ColegioMPEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                lista = db.usp_Especialidad_By_MedicoID(id).ToList();
            }
            return lista;
        }

        public static List<usp_List_Medicos_Result> getAllMedicos()
        {
            List<usp_List_Medicos_Result> lista = null;
            using (ColegioMPEntities db = new ColegioMPEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                lista = db.usp_List_Medicos().ToList();
            }
            return lista;
        }

        public static usp_Medico_By_Id_Result infoMedicoById(int id)
        {
            usp_Medico_By_Id_Result medico = null;
            using (ColegioMPEntities db = new ColegioMPEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                medico = db.usp_Medico_By_Id(id).FirstOrDefault();
            }
            return medico;
        }

        public static usp_Medico_By_NroCol_Result infoMedicoByNroCol(string nroCol)
        {
            usp_Medico_By_NroCol_Result medico = null;
            using (ColegioMPEntities db = new ColegioMPEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                medico = db.usp_Medico_By_NroCol(nroCol).FirstOrDefault();
            }
            return medico;
        }

        public static List<usp_Medico_By_Paterno_Result> medicosByPaterno(string pat)
        {
            List<usp_Medico_By_Paterno_Result> lista = null;
            using (ColegioMPEntities db = new ColegioMPEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                lista = db.usp_Medico_By_Paterno(pat).ToList();
            }
            return lista;
        }

        public static List<usp_Pasantia_By_MedicoID_Result> pasantiasMedico(int id)
        {
            List<usp_Pasantia_By_MedicoID_Result> lista = null;
            using (ColegioMPEntities db = new ColegioMPEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                lista = db.usp_Pasantia_By_MedicoID(id).ToList();
            }
            return lista;
        }

        public static List<usp_PostGrado_By_MedicoID_Result> postgradosMedico(int id)
        {
            List<usp_PostGrado_By_MedicoID_Result> lista = null;
            using (ColegioMPEntities db = new ColegioMPEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                lista = db.usp_PostGrado_By_MedicoID(id).ToList();
            }
            return lista;
        }

        public static List<usp_List_MedicosInstEdu_Result> getTopInstEduMedicos()
        {
            List<usp_List_MedicosInstEdu_Result> lista = null;
            using (ColegioMPEntities db = new ColegioMPEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                lista = db.usp_List_MedicosInstEdu().ToList();
            }
            return lista;
        }
    }
}
