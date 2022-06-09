﻿using DatabaseEntities;
using System;
using System.Collections.Generic;

namespace TCPConnectionAPI_C_sharp_
{
    public interface IClientAbilityProtocol : IDisposable
    {
        List<Subcontractor> FindSubconstructorsWhere(Func<Subcontractor, bool> comparer);
    }
}
