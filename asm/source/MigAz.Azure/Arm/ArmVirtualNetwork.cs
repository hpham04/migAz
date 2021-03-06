﻿using MigAz.Azure.Interface;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigAz.Azure.Arm
{
    public class ArmVirtualNetwork : VirtualNetwork, IVirtualNetwork
    {
        private JToken _VirtualNetwork;
        private List<ISubnet> _Subnets = new List<ISubnet>();

        private ArmVirtualNetwork() : base(Guid.Empty) { }

        public ArmVirtualNetwork(JToken virtualNetwork) : base(Guid.Empty)
        {
            _VirtualNetwork = virtualNetwork;

            var subnets = from vnet in _VirtualNetwork["properties"]["subnets"]
                          select vnet;

            foreach (var subnet in subnets)
            {
                ArmSubnet armSubnet = new ArmSubnet(this, subnet);
                _Subnets.Add(armSubnet);
            }
        }

        public string Name
        {
            get { return (string) _VirtualNetwork["name"]; }
        }

        public string Id
        {
            get { return (string)_VirtualNetwork["id"]; }
        }

        public string TargetId
        {
            get { return this.Id; }
        }
        
        public override string ToString()
        {
            return this.Name;
        }

        public List<ISubnet> Subnets
        {
            get { return _Subnets; }
        }

        public bool HasNonGatewaySubnet
        {
            get
            {
                if ((this.Subnets.Count() == 0) ||
                    ((this.Subnets.Count() == 1) && (this.Subnets[0].Name == ArmConst.GatewaySubnetName)))
                    return false;

                return true;
            }
        }

    }
}
