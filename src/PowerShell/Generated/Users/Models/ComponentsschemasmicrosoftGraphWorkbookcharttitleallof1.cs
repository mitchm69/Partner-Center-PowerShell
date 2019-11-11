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
    /// workbookChartTitle
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphWorkbookcharttitleallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphWorkbookcharttitleallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphWorkbookcharttitleallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphWorkbookcharttitleallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphWorkbookcharttitleallof1(bool? overlay = default(bool?), string text = default(string), bool? visible = default(bool?), MicrosoftgraphworkbookChartTitleFormat format = default(MicrosoftgraphworkbookChartTitleFormat))
        {
            Overlay = overlay;
            Text = text;
            Visible = visible;
            Format = format;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overlay")]
        public bool? Overlay { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "visible")]
        public bool? Visible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public MicrosoftgraphworkbookChartTitleFormat Format { get; set; }

    }
}