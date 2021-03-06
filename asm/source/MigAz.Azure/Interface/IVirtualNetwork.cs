﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigAz.Azure.Interface
{
    public interface IVirtualNetwork
    {
        string Id { get; }
        List<ISubnet> Subnets { get; }
        string TargetId { get; }
    }
}
