﻿using MigAz.Azure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigAz.Tests.Fakes
{
    class FakeSettingsProvider : ISettingsProvider
    {
        public FakeSettingsProvider()
        {
            StorageAccountSuffix = "v2";
            NetworkInterfaceCardSuffix = "-nic";
            VirtualNetworkSuffix = "-vnet";
            ResourceGroupSuffix = "-rg";
            VirtualNetworkGatewaySuffix = "-gw";
            PublicIPSuffix = "-pip";
            NetworkSecurityGroupSuffix = "-nsg";
            LoadBalancerSuffix = "-lb";
            VirtualMachineSuffix = "-vm";
        }

        public bool AllowTelemetry { get; set; }

        public bool BuildEmpty { get; set; }

        public string ExecutionId { get; set; }

        public string StorageAccountSuffix { get; set; }

        public string AvailabilitySetSuffix { get; set; }

        public string NetworkInterfaceCardSuffix { get; set; }

        public string VirtualNetworkSuffix { get; set; }

        public string ResourceGroupSuffix { get; set; }

        public string VirtualNetworkGatewaySuffix { get; set; }

        public string PublicIPSuffix { get; set; }

        public string NetworkSecurityGroupSuffix { get; set; }

        public string LoadBalancerSuffix { get; set; }
        
        public string VirtualMachineSuffix { get; set; }
    }
}
