// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="VolumeResource" /> and their operations.
    /// Each <see cref="VolumeResource" /> in the collection will belong to the same instance of <see cref="CapacityPoolResource" />.
    /// To get a <see cref="VolumeCollection" /> instance call the GetVolumes method from an instance of <see cref="CapacityPoolResource" />.
    /// </summary>
    public partial class VolumeCollection : ArmCollection, IEnumerable<VolumeResource>, IAsyncEnumerable<VolumeResource>
    {
        private readonly ClientDiagnostics _volumeClientDiagnostics;
        private readonly VolumesRestOperations _volumeRestClient;

        /// <summary> Initializes a new instance of the <see cref="VolumeCollection"/> class for mocking. </summary>
        protected VolumeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VolumeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VolumeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _volumeClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", VolumeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VolumeResource.ResourceType, out string volumeApiVersion);
            _volumeRestClient = new VolumesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, volumeApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CapacityPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CapacityPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the specified volume within the capacity pool
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}
        /// Operation Id: Volumes_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="data"> Volume object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VolumeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string volumeName, VolumeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _volumeClientDiagnostics.CreateScope("VolumeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _volumeRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<VolumeResource>(new VolumeOperationSource(Client), _volumeClientDiagnostics, Pipeline, _volumeRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update the specified volume within the capacity pool
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}
        /// Operation Id: Volumes_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="data"> Volume object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VolumeResource> CreateOrUpdate(WaitUntil waitUntil, string volumeName, VolumeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _volumeClientDiagnostics.CreateScope("VolumeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _volumeRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, data, cancellationToken);
                var operation = new NetAppArmOperation<VolumeResource>(new VolumeOperationSource(Client), _volumeClientDiagnostics, Pipeline, _volumeRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of the specified volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}
        /// Operation Id: Volumes_Get
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual async Task<Response<VolumeResource>> GetAsync(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _volumeClientDiagnostics.CreateScope("VolumeCollection.Get");
            scope.Start();
            try
            {
                var response = await _volumeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of the specified volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}
        /// Operation Id: Volumes_Get
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual Response<VolumeResource> Get(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _volumeClientDiagnostics.CreateScope("VolumeCollection.Get");
            scope.Start();
            try
            {
                var response = _volumeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VolumeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all volumes within the capacity pool
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes
        /// Operation Id: Volumes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VolumeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VolumeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VolumeResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _volumeClientDiagnostics.CreateScope("VolumeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _volumeRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VolumeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VolumeResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _volumeClientDiagnostics.CreateScope("VolumeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _volumeRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VolumeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List all volumes within the capacity pool
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes
        /// Operation Id: Volumes_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VolumeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VolumeResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VolumeResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _volumeClientDiagnostics.CreateScope("VolumeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _volumeRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VolumeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VolumeResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _volumeClientDiagnostics.CreateScope("VolumeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _volumeRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VolumeResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}
        /// Operation Id: Volumes_Get
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _volumeClientDiagnostics.CreateScope("VolumeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _volumeRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}
        /// Operation Id: Volumes_Get
        /// </summary>
        /// <param name="volumeName"> The name of the volume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="volumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="volumeName"/> is null. </exception>
        public virtual Response<bool> Exists(string volumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(volumeName, nameof(volumeName));

            using var scope = _volumeClientDiagnostics.CreateScope("VolumeCollection.Exists");
            scope.Start();
            try
            {
                var response = _volumeRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, volumeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VolumeResource> IEnumerable<VolumeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VolumeResource> IAsyncEnumerable<VolumeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
