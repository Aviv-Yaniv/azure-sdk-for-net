// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HealthcareApis
{
    internal class ServicesDescriptionOperationSource : IOperationSource<ServicesDescriptionResource>
    {
        private readonly ArmClient _client;

        internal ServicesDescriptionOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServicesDescriptionResource IOperationSource<ServicesDescriptionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ServicesDescriptionData.DeserializeServicesDescriptionData(document.RootElement);
            return new ServicesDescriptionResource(_client, data);
        }

        async ValueTask<ServicesDescriptionResource> IOperationSource<ServicesDescriptionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ServicesDescriptionData.DeserializeServicesDescriptionData(document.RootElement);
            return new ServicesDescriptionResource(_client, data);
        }
    }
}
