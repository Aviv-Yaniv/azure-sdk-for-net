// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class UploadCertificateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType");
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            writer.WritePropertyName("certificate");
            writer.WriteStringValue(Certificate);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
