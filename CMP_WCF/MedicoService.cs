using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CMP.DAL;

namespace CMP_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MedicoService" in both code and config file together.
    public class MedicoService : IMedicoService
    {
        public List<usp_Especialidad_By_MedicoID_Result> especialidadesMedico(int id)
        {
            return MedicoProvider.especialidadesMedico(id);
        }

        public List<usp_List_Medicos_Result> getAllMedicos()
        {
            return MedicoProvider.getAllMedicos();
        }

        public List<usp_List_MedicosInstEdu_Result> getTopInstEduMedicos()
        {
            return MedicoProvider.getTopInstEduMedicos();
        }

        public usp_Medico_By_Id_Result infoMedicoById(int id)
        {
            return MedicoProvider.infoMedicoById(id);
        }

        public usp_Medico_By_NroCol_Result infoMedicoByNroCol(string nroCol)
        {
            return MedicoProvider.infoMedicoByNroCol(nroCol);
        }

        public List<usp_Medico_By_Paterno_Result> medicosByPaterno(string pat)
        {
            return MedicoProvider.medicosByPaterno(pat);
        }

        public List<usp_Pasantia_By_MedicoID_Result> pasantiasMedico(int id)
        {
            return MedicoProvider.pasantiasMedico(id);
        }

        public List<usp_PostGrado_By_MedicoID_Result> postgradosMedico(int id)
        {
            return MedicoProvider.postgradosMedico(id);
        }
    }
}
