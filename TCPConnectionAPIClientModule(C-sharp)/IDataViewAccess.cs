using DatabaseEntities;
using System.Collections.Generic;

namespace TCPConnectionAPIClientModule_C_sharp_
{
    public interface IDataViewAccess
    {
        List<Subcontractor> FindSubcontractorWithName(string name);
        List<Subcontractor> FindSubcontractorWithUNP(int unp);
        List<Subcontractor> FindSubcontractorWithTotalRate(double rate);
        List<Subcontractor> FindSubcontractorWithAmountOfEmployees(int amount);
        List<Subcontractor> GetAllSubcontactors();
    }
}
