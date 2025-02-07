// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class RegionConfigurationRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ScheduleAvailabilityRequest))
            {
                writer.WritePropertyName("scheduleAvailabilityRequest");
                writer.WriteObjectValue(ScheduleAvailabilityRequest);
            }
            if (Optional.IsDefined(TransportAvailabilityRequest))
            {
                writer.WritePropertyName("transportAvailabilityRequest");
                writer.WriteObjectValue(TransportAvailabilityRequest);
            }
            if (Optional.IsDefined(DatacenterAddressRequest))
            {
                writer.WritePropertyName("datacenterAddressRequest");
                writer.WriteObjectValue(DatacenterAddressRequest);
            }
            writer.WriteEndObject();
        }
    }
}
