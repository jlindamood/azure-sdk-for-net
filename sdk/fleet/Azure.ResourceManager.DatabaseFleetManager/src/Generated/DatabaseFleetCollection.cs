// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DatabaseFleetManager
{
    /// <summary>
    /// A class representing a collection of <see cref="DatabaseFleetResource" /> and their operations.
    /// Each <see cref="DatabaseFleetResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DatabaseFleetCollection" /> instance call the GetDatabaseFleets method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DatabaseFleetCollection : ArmCollection, IEnumerable<DatabaseFleetResource>, IAsyncEnumerable<DatabaseFleetResource>
    {
        private readonly ClientDiagnostics _databaseFleetFleetsClientDiagnostics;
        private readonly FleetsRestOperations _databaseFleetFleetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DatabaseFleetCollection"/> class for mocking. </summary>
        protected DatabaseFleetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseFleetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DatabaseFleetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseFleetFleetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DatabaseFleetManager", DatabaseFleetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DatabaseFleetResource.ResourceType, out string databaseFleetFleetsApiVersion);
            _databaseFleetFleetsRestClient = new FleetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, databaseFleetFleetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a Fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DatabaseFleetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fleetName, DatabaseFleetData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseFleetFleetsClientDiagnostics.CreateScope("DatabaseFleetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseFleetFleetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, fleetName, data, ifMatch, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DatabaseFleetManagerArmOperation<DatabaseFleetResource>(new DatabaseFleetOperationSource(Client), _databaseFleetFleetsClientDiagnostics, Pipeline, _databaseFleetFleetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, fleetName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a Fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="ifMatch"> The request should only proceed if an entity matches this string. </param>
        /// <param name="ifNoneMatch"> The request should only proceed if no entity matches this string. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DatabaseFleetResource> CreateOrUpdate(WaitUntil waitUntil, string fleetName, DatabaseFleetData data, string ifMatch = null, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseFleetFleetsClientDiagnostics.CreateScope("DatabaseFleetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseFleetFleetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, fleetName, data, ifMatch, ifNoneMatch, cancellationToken);
                var operation = new DatabaseFleetManagerArmOperation<DatabaseFleetResource>(new DatabaseFleetOperationSource(Client), _databaseFleetFleetsClientDiagnostics, Pipeline, _databaseFleetFleetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, fleetName, data, ifMatch, ifNoneMatch).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets a Fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual async Task<Response<DatabaseFleetResource>> GetAsync(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _databaseFleetFleetsClientDiagnostics.CreateScope("DatabaseFleetCollection.Get");
            scope.Start();
            try
            {
                var response = await _databaseFleetFleetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseFleetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a Fleet.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual Response<DatabaseFleetResource> Get(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _databaseFleetFleetsClientDiagnostics.CreateScope("DatabaseFleetCollection.Get");
            scope.Start();
            try
            {
                var response = _databaseFleetFleetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseFleetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists fleets in the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatabaseFleetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatabaseFleetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _databaseFleetFleetsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _databaseFleetFleetsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DatabaseFleetResource(Client, DatabaseFleetData.DeserializeDatabaseFleetData(e)), _databaseFleetFleetsClientDiagnostics, Pipeline, "DatabaseFleetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists fleets in the specified subscription and resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatabaseFleetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatabaseFleetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _databaseFleetFleetsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _databaseFleetFleetsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DatabaseFleetResource(Client, DatabaseFleetData.DeserializeDatabaseFleetData(e)), _databaseFleetFleetsClientDiagnostics, Pipeline, "DatabaseFleetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _databaseFleetFleetsClientDiagnostics.CreateScope("DatabaseFleetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _databaseFleetFleetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual Response<bool> Exists(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _databaseFleetFleetsClientDiagnostics.CreateScope("DatabaseFleetCollection.Exists");
            scope.Start();
            try
            {
                var response = _databaseFleetFleetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual async Task<NullableResponse<DatabaseFleetResource>> GetIfExistsAsync(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _databaseFleetFleetsClientDiagnostics.CreateScope("DatabaseFleetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _databaseFleetFleetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DatabaseFleetResource>(response.GetRawResponse());
                return Response.FromValue(new DatabaseFleetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Fleets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="fleetName"> The name of the Fleet resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fleetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fleetName"/> is null. </exception>
        public virtual NullableResponse<DatabaseFleetResource> GetIfExists(string fleetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fleetName, nameof(fleetName));

            using var scope = _databaseFleetFleetsClientDiagnostics.CreateScope("DatabaseFleetCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _databaseFleetFleetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fleetName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DatabaseFleetResource>(response.GetRawResponse());
                return Response.FromValue(new DatabaseFleetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DatabaseFleetResource> IEnumerable<DatabaseFleetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DatabaseFleetResource> IAsyncEnumerable<DatabaseFleetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
