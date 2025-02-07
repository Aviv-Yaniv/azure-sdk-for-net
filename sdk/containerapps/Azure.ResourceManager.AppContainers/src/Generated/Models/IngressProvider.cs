// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container App Ingress configuration. </summary>
    public partial class IngressProvider
    {
        /// <summary> Initializes a new instance of IngressProvider. </summary>
        public IngressProvider()
        {
            Traffic = new ChangeTrackingList<TrafficWeight>();
            CustomDomains = new ChangeTrackingList<CustomDomain>();
        }

        /// <summary> Initializes a new instance of IngressProvider. </summary>
        /// <param name="fqdn"> Hostname. </param>
        /// <param name="external"> Bool indicating if app exposes an external http endpoint. </param>
        /// <param name="targetPort"> Target Port in containers for traffic from ingress. </param>
        /// <param name="transport"> Ingress transport protocol. </param>
        /// <param name="traffic"> Traffic weights for app&apos;s revisions. </param>
        /// <param name="customDomains"> custom domain bindings for Container Apps&apos; hostnames. </param>
        /// <param name="allowInsecure"> Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically redirected to HTTPS connections. </param>
        internal IngressProvider(string fqdn, bool? external, int? targetPort, IngressTransportMethod? transport, IList<TrafficWeight> traffic, IList<CustomDomain> customDomains, bool? allowInsecure)
        {
            Fqdn = fqdn;
            External = external;
            TargetPort = targetPort;
            Transport = transport;
            Traffic = traffic;
            CustomDomains = customDomains;
            AllowInsecure = allowInsecure;
        }

        /// <summary> Hostname. </summary>
        public string Fqdn { get; }
        /// <summary> Bool indicating if app exposes an external http endpoint. </summary>
        public bool? External { get; set; }
        /// <summary> Target Port in containers for traffic from ingress. </summary>
        public int? TargetPort { get; set; }
        /// <summary> Ingress transport protocol. </summary>
        public IngressTransportMethod? Transport { get; set; }
        /// <summary> Traffic weights for app&apos;s revisions. </summary>
        public IList<TrafficWeight> Traffic { get; }
        /// <summary> custom domain bindings for Container Apps&apos; hostnames. </summary>
        public IList<CustomDomain> CustomDomains { get; }
        /// <summary> Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically redirected to HTTPS connections. </summary>
        public bool? AllowInsecure { get; set; }
    }
}
