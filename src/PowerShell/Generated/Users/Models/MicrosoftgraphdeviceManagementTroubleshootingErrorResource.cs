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
    /// deviceManagementTroubleshootingErrorResource
    /// </summary>
    public partial class MicrosoftgraphdeviceManagementTroubleshootingErrorResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphdeviceManagementTroubleshootingErrorResource class.
        /// </summary>
        public MicrosoftgraphdeviceManagementTroubleshootingErrorResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphdeviceManagementTroubleshootingErrorResource class.
        /// </summary>
        /// <param name="link">The link to the web resource. Can contain any of
        /// the following formatters: {{UPN}}, {{DeviceGUID}},
        /// {{UserGUID}}</param>
        public MicrosoftgraphdeviceManagementTroubleshootingErrorResource(string text = default(string), string link = default(string))
        {
            Text = text;
            Link = link;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the link to the web resource. Can contain any of the
        /// following formatters: {{UPN}}, {{DeviceGUID}}, {{UserGUID}}
        /// </summary>
        [JsonProperty(PropertyName = "link")]
        public string Link { get; set; }

    }
}