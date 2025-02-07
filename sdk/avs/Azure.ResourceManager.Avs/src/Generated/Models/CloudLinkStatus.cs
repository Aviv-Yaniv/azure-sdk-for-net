// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The state of the cloud link. </summary>
    public readonly partial struct CloudLinkStatus : IEquatable<CloudLinkStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CloudLinkStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CloudLinkStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ActiveValue = "Active";
        private const string BuildingValue = "Building";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Active. </summary>
        public static CloudLinkStatus Active { get; } = new CloudLinkStatus(ActiveValue);
        /// <summary> Building. </summary>
        public static CloudLinkStatus Building { get; } = new CloudLinkStatus(BuildingValue);
        /// <summary> Deleting. </summary>
        public static CloudLinkStatus Deleting { get; } = new CloudLinkStatus(DeletingValue);
        /// <summary> Failed. </summary>
        public static CloudLinkStatus Failed { get; } = new CloudLinkStatus(FailedValue);
        /// <summary> Disconnected. </summary>
        public static CloudLinkStatus Disconnected { get; } = new CloudLinkStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="CloudLinkStatus"/> values are the same. </summary>
        public static bool operator ==(CloudLinkStatus left, CloudLinkStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudLinkStatus"/> values are not the same. </summary>
        public static bool operator !=(CloudLinkStatus left, CloudLinkStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CloudLinkStatus"/>. </summary>
        public static implicit operator CloudLinkStatus(string value) => new CloudLinkStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudLinkStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudLinkStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
