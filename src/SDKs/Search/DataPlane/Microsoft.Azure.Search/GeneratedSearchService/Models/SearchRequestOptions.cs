// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional parameters for a set of operations.
    /// </summary>
    public partial class SearchRequestOptions
    {
        /// <summary>
        /// Initializes a new instance of the SearchRequestOptions class.
        /// </summary>
        public SearchRequestOptions() { }

        /// <summary>
        /// Initializes a new instance of the SearchRequestOptions class.
        /// </summary>
        /// <param name="clientRequestId">The tracking ID sent with the request
        /// to help with debugging.</param>
        public SearchRequestOptions(System.Guid? clientRequestId = default(System.Guid?))
        {
            ClientRequestId = clientRequestId;
        }

        /// <summary>
        /// Gets or sets the tracking ID sent with the request to help with
        /// debugging.
        /// </summary>
        [JsonProperty(PropertyName = "")]
        public System.Guid? ClientRequestId { get; set; }

    }
}

