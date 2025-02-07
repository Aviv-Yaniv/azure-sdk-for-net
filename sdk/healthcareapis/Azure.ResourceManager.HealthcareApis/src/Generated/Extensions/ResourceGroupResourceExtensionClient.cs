// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    internal partial class ResourceGroupResourceExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ServicesDescriptionResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ServicesDescriptionResources and their operations over a ServicesDescriptionResource. </returns>
        public virtual ServicesDescriptionCollection GetServicesDescriptions()
        {
            return GetCachedClient(Client => new ServicesDescriptionCollection(Client, Id));
        }

        /// <summary> Gets a collection of WorkspaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of WorkspaceResources and their operations over a WorkspaceResource. </returns>
        public virtual WorkspaceCollection GetWorkspaces()
        {
            return GetCachedClient(Client => new WorkspaceCollection(Client, Id));
        }
    }
}
