// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> The PostgreSqlServerPrivateLinkServiceConnectionStateProperty. </summary>
    public partial class PostgreSqlServerPrivateLinkServiceConnectionStateProperty
    {
        /// <summary> Initializes a new instance of PostgreSqlServerPrivateLinkServiceConnectionStateProperty. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="description"/> is null. </exception>
        internal PostgreSqlServerPrivateLinkServiceConnectionStateProperty(PostgreSqlPrivateLinkServiceConnectionStateStatus status, string description)
        {
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }

            Status = status;
            Description = description;
        }

        /// <summary> Initializes a new instance of PostgreSqlServerPrivateLinkServiceConnectionStateProperty. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> The actions required for private link service connection. </param>
        internal PostgreSqlServerPrivateLinkServiceConnectionStateProperty(PostgreSqlPrivateLinkServiceConnectionStateStatus status, string description, PostgreSqlPrivateLinkServiceConnectionStateRequiredAction? actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The private link service connection status. </summary>
        public PostgreSqlPrivateLinkServiceConnectionStateStatus Status { get; }
        /// <summary> The private link service connection description. </summary>
        public string Description { get; }
        /// <summary> The actions required for private link service connection. </summary>
        public PostgreSqlPrivateLinkServiceConnectionStateRequiredAction? ActionsRequired { get; }
    }
}
