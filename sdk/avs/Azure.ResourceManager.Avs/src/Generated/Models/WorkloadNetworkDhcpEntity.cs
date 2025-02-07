// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary>
    /// Base class for WorkloadNetworkDhcpServer and WorkloadNetworkDhcpRelay to inherit from
    /// Please note <see cref="WorkloadNetworkDhcpEntity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WorkloadNetworkDhcpRelay"/> and <see cref="WorkloadNetworkDhcpServer"/>.
    /// </summary>
    public partial class WorkloadNetworkDhcpEntity
    {
        /// <summary> Initializes a new instance of WorkloadNetworkDhcpEntity. </summary>
        public WorkloadNetworkDhcpEntity()
        {
            Segments = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of WorkloadNetworkDhcpEntity. </summary>
        /// <param name="dhcpType"> Type of DHCP: SERVER or RELAY. </param>
        /// <param name="displayName"> Display name of the DHCP entity. </param>
        /// <param name="segments"> NSX Segments consuming DHCP. </param>
        /// <param name="provisioningState"> The provisioning state. </param>
        /// <param name="revision"> NSX revision number. </param>
        internal WorkloadNetworkDhcpEntity(DhcpTypeEnum dhcpType, string displayName, IReadOnlyList<string> segments, WorkloadNetworkDhcpProvisioningState? provisioningState, long? revision)
        {
            DhcpType = dhcpType;
            DisplayName = displayName;
            Segments = segments;
            ProvisioningState = provisioningState;
            Revision = revision;
        }

        /// <summary> Type of DHCP: SERVER or RELAY. </summary>
        internal DhcpTypeEnum DhcpType { get; set; }
        /// <summary> Display name of the DHCP entity. </summary>
        public string DisplayName { get; set; }
        /// <summary> NSX Segments consuming DHCP. </summary>
        public IReadOnlyList<string> Segments { get; }
        /// <summary> The provisioning state. </summary>
        public WorkloadNetworkDhcpProvisioningState? ProvisioningState { get; }
        /// <summary> NSX revision number. </summary>
        public long? Revision { get; set; }
    }
}
