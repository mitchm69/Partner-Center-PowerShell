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

    public partial class MicrosoftgraphteamsAppInstallation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphteamsAppInstallation class.
        /// </summary>
        public MicrosoftgraphteamsAppInstallation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftgraphteamsAppInstallation class.
        /// </summary>
        public MicrosoftgraphteamsAppInstallation(string id = default(string), MicrosoftgraphteamsApp teamsApp = default(MicrosoftgraphteamsApp), MicrosoftgraphteamsAppDefinition teamsAppDefinition = default(MicrosoftgraphteamsAppDefinition))
        {
            Id = id;
            TeamsApp = teamsApp;
            TeamsAppDefinition = teamsAppDefinition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamsApp")]
        public MicrosoftgraphteamsApp TeamsApp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "teamsAppDefinition")]
        public MicrosoftgraphteamsAppDefinition TeamsAppDefinition { get; set; }

    }
}