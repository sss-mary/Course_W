using ClassLibraryForTCPConnectionAPI_C_sharp_;
using DatabaseEntities;

namespace TCPConnectionAPIClientModule_C_sharp_
{
    public interface IDataModifyAccess : IDataViewAccess   
    {
        AnswerFromServer CreateSubcontractor(Subcontractor obj);
        AnswerFromServer ModifySubcontractor(Subcontractor obj);
        AnswerFromServer DeleteSubcontractor(int id);
    }
}
