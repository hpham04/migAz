﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigAz.Azure.Interface
{
    public interface ISubnet
    {
        string Id { get; }
        string Name { get; }
        string TargetId { get; }
    }
}
