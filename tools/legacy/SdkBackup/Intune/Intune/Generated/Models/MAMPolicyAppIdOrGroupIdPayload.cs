// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Intune.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// MAM Policy request body for properties Intune MAM.
    /// </summary>
    public partial class MAMPolicyAppIdOrGroupIdPayload
    {
        /// <summary>
        /// Initializes a new instance of the MAMPolicyAppIdOrGroupIdPayload
        /// class.
        /// </summary>
        public MAMPolicyAppIdOrGroupIdPayload() { }

        /// <summary>
        /// Initializes a new instance of the MAMPolicyAppIdOrGroupIdPayload
        /// class.
        /// </summary>
        public MAMPolicyAppIdOrGroupIdPayload(MAMPolicyAppOrGroupIdProperties properties = default(MAMPolicyAppOrGroupIdProperties))
        {
            Properties = properties;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public MAMPolicyAppOrGroupIdProperties Properties { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}
