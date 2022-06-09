using DatabaseEntities;
using System;
using System.Collections.Generic;


namespace TCPConnectionAPI_C_sharp_
{
    public class ExpertAbilityProtocol : IExpertAbilityProtocol
    {
        public IExpertMethod expertMethod { get; set; }

        public IDataModifyPermission DBconnection;

        public bool Rate(Subcontractor entity, Expert expert, float rate)
        {
            var ratedObj = expertMethod.Rate(entity, expert, rate) as Subcontractor;
            return DBconnection.UpdateSubcontractor(ratedObj);
        }

        public void Dispose()
        {
            DBconnection.Dispose();
        }

        public List<Subcontractor> FindSubconstructorsWhere(Func<Subcontractor, bool> comparer)
        {
            return DBconnection.FindSubcontractorsWhere(comparer);
        }

        public ExpertAbilityProtocol()
        {
            DBconnection = new DatabaseContext();
        }

    }
}
