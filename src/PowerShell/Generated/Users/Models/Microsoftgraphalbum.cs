// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Store.PartnerCenter.PowerShell.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// album
    /// </summary>
    public partial class Microsoftgraphalbum
    {
        /// <summary>
        /// Initializes a new instance of the Microsoftgraphalbum class.
        /// </summary>
        public Microsoftgraphalbum()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Microsoftgraphalbum class.
        /// </summary>
        public Microsoftgraphalbum(string coverImageItemId = default(string))
        {
            CoverImageItemId = coverImageItemId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "coverImageItemId")]
        public string CoverImageItemId { get; set; }

    }
}