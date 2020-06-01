using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CMP.DAL;

namespace CMP_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMedicoService" in both code and config file together.
    [ServiceContract]
    public interface IMedicoService
    {
        [OperationContract]
        List<usp_Especialidad_By_MedicoID_Result> especialidadesMedico(int id);

        [OperationContract]
        List<usp_Pasantia_By_MedicoID_Result> pasantiasMedico(int id);

        [OperationContract]
        List<usp_PostGrado_By_MedicoID_Result> postgradosMedico(int id);

        [OperationContract]
        usp_Medico_By_NroCol_Result infoMedicoByNroCol(string nroCol);

        [OperationContract]
        usp_Medico_By_Id_Result infoMedicoById(int id);

        [OperationContract]
        List<usp_Medico_By_Paterno_Result> medicosByPaterno(String pat);

        [OperationContract]
        List<usp_List_Medicos_Result> getAllMedicos();

        [OperationContract]
        List<usp_List_MedicosInstEdu_Result> getTopInstEduMedicos();
    }
}
