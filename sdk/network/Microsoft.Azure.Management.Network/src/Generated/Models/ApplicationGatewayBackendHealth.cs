// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Response for ApplicationGatewayBackendHealth API service call.
    /// </summary>
    public partial class ApplicationGatewayBackendHealth
    {
        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendHealth
        /// class.
        /// </summary>
        public ApplicationGatewayBackendHealth()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApplicationGatewayBackendHealth
        /// class.
        /// </summary>
        /// <param name="backendAddressPools">A list of
        /// ApplicationGatewayBackendHealthPool resources.</param>
        public ApplicationGatewayBackendHealth(IList<ApplicationGatewayBackendHealthPool> backendAddressPools = default(IList<ApplicationGatewayBackendHealthPool>))
        {
            BackendAddressPools = backendAddressPools;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of ApplicationGatewayBackendHealthPool
        /// resources.
        /// </summary>
        [JsonProperty(PropertyName = "backendAddressPools")]
        public IList<ApplicationGatewayBackendHealthPool> BackendAddressPools { get; set; }

    }
}
