// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class VolumePropertiesDataProtection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Backup))
            {
                writer.WritePropertyName("backup");
                writer.WriteObjectValue(Backup);
            }
            if (Optional.IsDefined(Replication))
            {
                writer.WritePropertyName("replication");
                writer.WriteObjectValue(Replication);
            }
            if (Optional.IsDefined(Snapshot))
            {
                writer.WritePropertyName("snapshot");
                writer.WriteObjectValue(Snapshot);
            }
            writer.WriteEndObject();
        }

        internal static VolumePropertiesDataProtection DeserializeVolumePropertiesDataProtection(JsonElement element)
        {
            Optional<VolumeBackupProperties> backup = default;
            Optional<ReplicationObject> replication = default;
            Optional<VolumeSnapshotProperties> snapshot = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backup"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    backup = VolumeBackupProperties.DeserializeVolumeBackupProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("replication"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    replication = ReplicationObject.DeserializeReplicationObject(property.Value);
                    continue;
                }
                if (property.NameEquals("snapshot"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    snapshot = VolumeSnapshotProperties.DeserializeVolumeSnapshotProperties(property.Value);
                    continue;
                }
            }
            return new VolumePropertiesDataProtection(backup.Value, replication.Value, snapshot.Value);
        }
    }
}
