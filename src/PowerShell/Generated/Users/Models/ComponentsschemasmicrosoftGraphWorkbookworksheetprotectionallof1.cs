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
    /// workbookWorksheetProtection
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphWorkbookworksheetprotectionallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphWorkbookworksheetprotectionallof1
        /// class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphWorkbookworksheetprotectionallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphWorkbookworksheetprotectionallof1
        /// class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphWorkbookworksheetprotectionallof1(MicrosoftgraphworkbookWorksheetProtectionOptions options = default(MicrosoftgraphworkbookWorksheetProtectionOptions), bool? protectedProperty = default(bool?))
        {
            Options = options;
            ProtectedProperty = protectedProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        public MicrosoftgraphworkbookWorksheetProtectionOptions Options { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "protected")]
        public bool? ProtectedProperty { get; set; }

    }
}