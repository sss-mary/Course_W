using System;
using DatabaseEntities;
namespace TCPConnectionAPI_C_sharp_
{
    public interface IDataModifyPermission : IDataViewPermision
    {
        int CreateSubcontractor(Subcontractor obj);
        bool DeleteSubcontractorsWhere(Func<Subcontractor, bool> comparer);
        bool UpdateSubcontractor(Subcontractor newVersion);
    }
}
