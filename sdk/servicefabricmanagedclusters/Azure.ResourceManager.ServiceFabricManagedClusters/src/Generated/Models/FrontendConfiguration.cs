// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes the frontend configurations for the node type. </summary>
    public partial class FrontendConfiguration
    {
        /// <summary> Initializes a new instance of FrontendConfiguration. </summary>
        public FrontendConfiguration()
        {
        }

        /// <summary> Initializes a new instance of FrontendConfiguration. </summary>
        /// <param name="ipAddressType"> The IP address type of this frontend configuration. If omitted the default value is IPv4. </param>
        /// <param name="loadBalancerBackendAddressPoolId"> The resource Id of the Load Balancer backend address pool that the VM instances of the node type are associated with. The format of the resource Id is &apos;/subscriptions/&lt;subscriptionId&gt;/resourceGroups/&lt;resourceGroupName&gt;/providers/Microsoft.Network/loadBalancers/&lt;loadBalancerName&gt;/backendAddressPools/&lt;backendAddressPoolName&gt;&apos;. </param>
        /// <param name="loadBalancerInboundNatPoolId"> The resource Id of the Load Balancer inbound NAT pool that the VM instances of the node type are associated with. The format of the resource Id is &apos;/subscriptions/&lt;subscriptionId&gt;/resourceGroups/&lt;resourceGroupName&gt;/providers/Microsoft.Network/loadBalancers/&lt;loadBalancerName&gt;/inboundNatPools/&lt;inboundNatPoolName&gt;&apos;. </param>
        internal FrontendConfiguration(IPAddressType? ipAddressType, string loadBalancerBackendAddressPoolId, string loadBalancerInboundNatPoolId)
        {
            IPAddressType = ipAddressType;
            LoadBalancerBackendAddressPoolId = loadBalancerBackendAddressPoolId;
            LoadBalancerInboundNatPoolId = loadBalancerInboundNatPoolId;
        }

        /// <summary> The IP address type of this frontend configuration. If omitted the default value is IPv4. </summary>
        public IPAddressType? IPAddressType { get; set; }
        /// <summary> The resource Id of the Load Balancer backend address pool that the VM instances of the node type are associated with. The format of the resource Id is &apos;/subscriptions/&lt;subscriptionId&gt;/resourceGroups/&lt;resourceGroupName&gt;/providers/Microsoft.Network/loadBalancers/&lt;loadBalancerName&gt;/backendAddressPools/&lt;backendAddressPoolName&gt;&apos;. </summary>
        public string LoadBalancerBackendAddressPoolId { get; set; }
        /// <summary> The resource Id of the Load Balancer inbound NAT pool that the VM instances of the node type are associated with. The format of the resource Id is &apos;/subscriptions/&lt;subscriptionId&gt;/resourceGroups/&lt;resourceGroupName&gt;/providers/Microsoft.Network/loadBalancers/&lt;loadBalancerName&gt;/inboundNatPools/&lt;inboundNatPoolName&gt;&apos;. </summary>
        public string LoadBalancerInboundNatPoolId { get; set; }
    }
}
