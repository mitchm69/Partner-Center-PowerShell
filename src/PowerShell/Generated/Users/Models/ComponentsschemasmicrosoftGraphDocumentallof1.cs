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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// document
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphDocumentallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphDocumentallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphDocumentallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphDocumentallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphDocumentallof1(IList<MicrosoftgraphdocumentComment> comments = default(IList<MicrosoftgraphdocumentComment>))
        {
            Comments = comments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public IList<MicrosoftgraphdocumentComment> Comments { get; set; }

    }
}