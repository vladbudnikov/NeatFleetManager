﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeatFleetManagement.Data
{
    public interface IDbFactory : IDisposable
    {
        BaseDbContext Init();
    }
}
