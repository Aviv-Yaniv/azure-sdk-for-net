// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.JobRouter
{
    /// <summary> An attachment which attaches WorkerSelectors to workers. </summary>
    public partial class WorkerSelectorAttachment
    {

        /// <summary> Initializes a new instance of WorkerSelectorAttachment. </summary>
        /// <param name="kind"> The type discriminator describing the type of label selector attachment. </param>
        internal WorkerSelectorAttachment(string kind)
        {
            Kind = kind;
        }
    }
}
