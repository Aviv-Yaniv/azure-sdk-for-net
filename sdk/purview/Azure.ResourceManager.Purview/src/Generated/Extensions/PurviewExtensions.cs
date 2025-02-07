// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Purview.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Purview
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Purview. </summary>
    public static partial class PurviewExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary>
        /// Get the default account for the scope.
        /// Request Path: /providers/Microsoft.Purview/getDefaultAccount
        /// Operation Id: DefaultAccounts_Get
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is &quot;Subscription&quot; then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<DefaultAccountPayload>> GetDefaultAccountAsync(this TenantResource tenantResource, Guid scopeTenantId, ScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(tenantResource).GetDefaultAccountAsync(scopeTenantId, scopeType, scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the default account for the scope.
        /// Request Path: /providers/Microsoft.Purview/getDefaultAccount
        /// Operation Id: DefaultAccounts_Get
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is &quot;Subscription&quot; then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<DefaultAccountPayload> GetDefaultAccount(this TenantResource tenantResource, Guid scopeTenantId, ScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).GetDefaultAccount(scopeTenantId, scopeType, scope, cancellationToken);
        }

        /// <summary>
        /// Sets the default account for the scope.
        /// Request Path: /providers/Microsoft.Purview/setDefaultAccount
        /// Operation Id: DefaultAccounts_Set
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="defaultAccountPayload"> The payload containing the default account information and the scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultAccountPayload"/> is null. </exception>
        public static async Task<Response<DefaultAccountPayload>> SetDefaultAccountAsync(this TenantResource tenantResource, DefaultAccountPayload defaultAccountPayload, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(defaultAccountPayload, nameof(defaultAccountPayload));

            return await GetExtensionClient(tenantResource).SetDefaultAccountAsync(defaultAccountPayload, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Sets the default account for the scope.
        /// Request Path: /providers/Microsoft.Purview/setDefaultAccount
        /// Operation Id: DefaultAccounts_Set
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="defaultAccountPayload"> The payload containing the default account information and the scope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="defaultAccountPayload"/> is null. </exception>
        public static Response<DefaultAccountPayload> SetDefaultAccount(this TenantResource tenantResource, DefaultAccountPayload defaultAccountPayload, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(defaultAccountPayload, nameof(defaultAccountPayload));

            return GetExtensionClient(tenantResource).SetDefaultAccount(defaultAccountPayload, cancellationToken);
        }

        /// <summary>
        /// Removes the default account from the scope.
        /// Request Path: /providers/Microsoft.Purview/removeDefaultAccount
        /// Operation Id: DefaultAccounts_Remove
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is &quot;Subscription&quot; then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response> RemoveDefaultAccountAsync(this TenantResource tenantResource, Guid scopeTenantId, ScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(tenantResource).RemoveDefaultAccountAsync(scopeTenantId, scopeType, scope, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Removes the default account from the scope.
        /// Request Path: /providers/Microsoft.Purview/removeDefaultAccount
        /// Operation Id: DefaultAccounts_Remove
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="scopeTenantId"> The tenant ID. </param>
        /// <param name="scopeType"> The scope for the default account. </param>
        /// <param name="scope"> The Id of the scope object, for example if the scope is &quot;Subscription&quot; then it is the ID of that subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response RemoveDefaultAccount(this TenantResource tenantResource, Guid scopeTenantId, ScopeType scopeType, string scope = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).RemoveDefaultAccount(scopeTenantId, scopeType, scope, cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// List accounts in Subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Purview/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<AccountResource> GetAccountsAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAccountsAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// List accounts in Subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Purview/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> The skip token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<AccountResource> GetAccounts(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetAccounts(skipToken, cancellationToken);
        }

        /// <summary>
        /// Checks if account name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Purview/checkNameAvailability
        /// Operation Id: Accounts_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityAccountAsync(this SubscriptionResource subscriptionResource, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNameAvailabilityAccountAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks if account name is available.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Purview/checkNameAvailability
        /// Operation Id: Accounts_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<CheckNameAvailabilityResult> CheckNameAvailabilityAccount(this SubscriptionResource subscriptionResource, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNameAvailabilityAccount(content, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of AccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of AccountResources and their operations over a AccountResource. </returns>
        public static AccountCollection GetAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetAccounts();
        }

        /// <summary>
        /// Get an account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AccountResource>> GetAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Purview/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AccountResource> GetAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetAccounts().Get(accountName, cancellationToken);
        }

        #region AccountResource
        /// <summary>
        /// Gets an object representing an <see cref="AccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AccountResource.CreateResourceIdentifier" /> to create an <see cref="AccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AccountResource" /> object. </returns>
        public static AccountResource GetAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AccountResource.ValidateResourceId(id);
                return new AccountResource(client, id);
            }
            );
        }
        #endregion

        #region PurviewPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="PurviewPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PurviewPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="PurviewPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PurviewPrivateEndpointConnectionResource" /> object. </returns>
        public static PurviewPrivateEndpointConnectionResource GetPurviewPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PurviewPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new PurviewPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region PurviewPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="PurviewPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PurviewPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="PurviewPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PurviewPrivateLinkResource" /> object. </returns>
        public static PurviewPrivateLinkResource GetPurviewPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PurviewPrivateLinkResource.ValidateResourceId(id);
                return new PurviewPrivateLinkResource(client, id);
            }
            );
        }
        #endregion
    }
}
