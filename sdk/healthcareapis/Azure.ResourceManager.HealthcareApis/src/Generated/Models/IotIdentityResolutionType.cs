// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The type of IoT identity resolution to use with the destination. </summary>
    public readonly partial struct IotIdentityResolutionType : IEquatable<IotIdentityResolutionType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IotIdentityResolutionType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IotIdentityResolutionType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreateValue = "Create";
        private const string LookupValue = "Lookup";

        /// <summary> Create. </summary>
        public static IotIdentityResolutionType Create { get; } = new IotIdentityResolutionType(CreateValue);
        /// <summary> Lookup. </summary>
        public static IotIdentityResolutionType Lookup { get; } = new IotIdentityResolutionType(LookupValue);
        /// <summary> Determines if two <see cref="IotIdentityResolutionType"/> values are the same. </summary>
        public static bool operator ==(IotIdentityResolutionType left, IotIdentityResolutionType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IotIdentityResolutionType"/> values are not the same. </summary>
        public static bool operator !=(IotIdentityResolutionType left, IotIdentityResolutionType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IotIdentityResolutionType"/>. </summary>
        public static implicit operator IotIdentityResolutionType(string value) => new IotIdentityResolutionType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IotIdentityResolutionType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IotIdentityResolutionType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
