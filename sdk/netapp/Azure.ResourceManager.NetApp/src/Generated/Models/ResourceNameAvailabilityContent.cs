// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Resource name availability request content. </summary>
    public partial class ResourceNameAvailabilityContent
    {
        /// <summary> Initializes a new instance of ResourceNameAvailabilityContent. </summary>
        /// <param name="name"> Resource name to verify. </param>
        /// <param name="resourceType"> Resource type used for verification. </param>
        /// <param name="resourceGroup"> Resource group name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="resourceGroup"/> is null. </exception>
        public ResourceNameAvailabilityContent(string name, CheckNameResourceType resourceType, string resourceGroup)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (resourceGroup == null)
            {
                throw new ArgumentNullException(nameof(resourceGroup));
            }

            Name = name;
            ResourceType = resourceType;
            ResourceGroup = resourceGroup;
        }

        /// <summary> Resource name to verify. </summary>
        public string Name { get; }
        /// <summary> Resource type used for verification. </summary>
        public CheckNameResourceType ResourceType { get; }
        /// <summary> Resource group name. </summary>
        public string ResourceGroup { get; }
    }
}
