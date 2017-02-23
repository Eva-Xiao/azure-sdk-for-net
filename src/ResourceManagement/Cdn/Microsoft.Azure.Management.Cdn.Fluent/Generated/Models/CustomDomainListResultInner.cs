// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Result of the request to list custom domains. It contains a list of
    /// custom domain objects and a URL link to get the next set of results.
    /// </summary>
    public partial class CustomDomainListResultInner
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomainListResultInner
        /// class.
        /// </summary>
        public CustomDomainListResultInner() { }

        /// <summary>
        /// Initializes a new instance of the CustomDomainListResultInner
        /// class.
        /// </summary>
        /// <param name="value">List of CDN CustomDomains within an
        /// endpoint.</param>
        /// <param name="nextLink">URL to get the next set of custom domain
        /// objects if there are any.</param>
        public CustomDomainListResultInner(System.Collections.Generic.IList<CustomDomainInner> value = default(System.Collections.Generic.IList<CustomDomainInner>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary>
        /// Gets or sets list of CDN CustomDomains within an endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public System.Collections.Generic.IList<CustomDomainInner> Value { get; set; }

        /// <summary>
        /// Gets or sets URL to get the next set of custom domain objects if
        /// there are any.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}