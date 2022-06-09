using DatabaseEntities;
using System;
using System.Collections.Generic;

namespace TCPConnectionAPI_C_sharp_
{
    public class ClientAbilityProtocol : IClientAbilityProtocol
    {
        IDataViewPermision DBconnection;

        public ClientAbilityProtocol()
        {
            DBconnection = new DatabaseContext();
        }

        public void Dispose()
        {
            DBconnection.Dispose();
        }

        public List<Subcontractor> FindSubconstructorsWhere(Func<Subcontractor, bool> comparer)
        {
            return DBconnection.FindSubcontractorsWhere(comparer);
        }
    }
}
