// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Subscription.Models
{
    internal partial class TenantListResult
    {
        internal static TenantListResult DeserializeTenantListResult(JsonElement element)
        {
            Optional<IReadOnlyList<TenantIdDescription>> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TenantIdDescription> array = new List<TenantIdDescription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TenantIdDescription.DeserializeTenantIdDescription(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new TenantListResult(Optional.ToList(value), nextLink);
        }
    }
}
