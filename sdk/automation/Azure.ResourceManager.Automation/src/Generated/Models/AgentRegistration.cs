// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the agent registration information type. </summary>
    public partial class AgentRegistration
    {
        /// <summary> Initializes a new instance of AgentRegistration. </summary>
        internal AgentRegistration()
        {
        }

        /// <summary> Initializes a new instance of AgentRegistration. </summary>
        /// <param name="dscMetaConfiguration"> Gets or sets the dsc meta configuration. </param>
        /// <param name="endpoint"> Gets or sets the dsc server endpoint. </param>
        /// <param name="keys"> Gets or sets the agent registration keys. </param>
        /// <param name="id"> Gets or sets the id. </param>
        internal AgentRegistration(string dscMetaConfiguration, string endpoint, AgentRegistrationKeys keys, string id)
        {
            DscMetaConfiguration = dscMetaConfiguration;
            Endpoint = endpoint;
            Keys = keys;
            Id = id;
        }

        /// <summary> Gets or sets the dsc meta configuration. </summary>
        public string DscMetaConfiguration { get; }
        /// <summary> Gets or sets the dsc server endpoint. </summary>
        public string Endpoint { get; }
        /// <summary> Gets or sets the agent registration keys. </summary>
        public AgentRegistrationKeys Keys { get; }
        /// <summary> Gets or sets the id. </summary>
        public string Id { get; }
    }
}
