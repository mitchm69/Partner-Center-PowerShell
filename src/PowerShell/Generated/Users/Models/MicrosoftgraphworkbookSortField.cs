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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// workbookSortField
    /// </summary>
    public partial class MicrosoftgraphworkbookSortField
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphworkbookSortField
        /// class.
        /// </summary>
        public MicrosoftgraphworkbookSortField()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphworkbookSortField
        /// class.
        /// </summary>
        public MicrosoftgraphworkbookSortField(bool? ascending = default(bool?), string color = default(string), string dataOption = default(string), MicrosoftgraphworkbookIcon icon = default(MicrosoftgraphworkbookIcon), int? key = default(int?), string sortOn = default(string))
        {
            Ascending = ascending;
            Color = color;
            DataOption = dataOption;
            Icon = icon;
            Key = key;
            SortOn = sortOn;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ascending")]
        public bool? Ascending { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dataOption")]
        public string DataOption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "icon")]
        public MicrosoftgraphworkbookIcon Icon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public int? Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sortOn")]
        public string SortOn { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Icon != null)
            {
                Icon.Validate();
            }
            if (Key > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Key", 2147483647);
            }
            if (Key < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Key", -2147483648);
            }
        }
    }
}