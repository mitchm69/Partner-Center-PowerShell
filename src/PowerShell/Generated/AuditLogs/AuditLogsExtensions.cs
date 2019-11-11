// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Store.PartnerCenter.PowerShell
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AuditLogs.
    /// </summary>
    public static partial class AuditLogsExtensions
    {
            /// <summary>
            /// Get directoryAudits from auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PathsauditlogsDirectoryauditsgetresponses200contentapplicationJsonschema> ListDirectoryAuditsAsync(this IAuditLogs operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDirectoryAuditsWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new navigation property to directoryAudits for auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New navigation property
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftgraphdirectoryAudit> CreateDirectoryAuditsAsync(this IAuditLogs operations, MicrosoftgraphdirectoryAudit body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateDirectoryAuditsWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get directoryAudits from auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='directoryAuditId'>
            /// key: directoryAudit-id of directoryAudit
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftgraphdirectoryAudit> GetDirectoryAuditsAsync(this IAuditLogs operations, string directoryAuditId, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDirectoryAuditsWithHttpMessagesAsync(directoryAuditId, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the navigation property directoryAudits in auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New navigation property values
            /// </param>
            /// <param name='directoryAuditId'>
            /// key: directoryAudit-id of directoryAudit
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateDirectoryAuditsAsync(this IAuditLogs operations, MicrosoftgraphdirectoryAudit body, string directoryAuditId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateDirectoryAuditsWithHttpMessagesAsync(body, directoryAuditId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get directoryProvisioning from auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PathsauditlogsDirectoryprovisioninggetresponses200contentapplicationJsonschema> ListDirectoryProvisioningAsync(this IAuditLogs operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDirectoryProvisioningWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new navigation property to directoryProvisioning for auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New navigation property
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftgraphprovisioningObjectSummary> CreateDirectoryProvisioningAsync(this IAuditLogs operations, MicrosoftgraphprovisioningObjectSummary body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateDirectoryProvisioningWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get directoryProvisioning from auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='provisioningObjectSummaryId'>
            /// key: provisioningObjectSummary-id of provisioningObjectSummary
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftgraphprovisioningObjectSummary> GetDirectoryProvisioningAsync(this IAuditLogs operations, string provisioningObjectSummaryId, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDirectoryProvisioningWithHttpMessagesAsync(provisioningObjectSummaryId, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the navigation property directoryProvisioning in auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New navigation property values
            /// </param>
            /// <param name='provisioningObjectSummaryId'>
            /// key: provisioningObjectSummary-id of provisioningObjectSummary
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateDirectoryProvisioningAsync(this IAuditLogs operations, MicrosoftgraphprovisioningObjectSummary body, string provisioningObjectSummaryId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateDirectoryProvisioningWithHttpMessagesAsync(body, provisioningObjectSummaryId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get provisioning from auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PathsauditlogsProvisioninggetresponses200contentapplicationJsonschema> ListProvisioningAsync(this IAuditLogs operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListProvisioningWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new navigation property to provisioning for auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New navigation property
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftgraphprovisioningObjectSummary> CreateProvisioningAsync(this IAuditLogs operations, MicrosoftgraphprovisioningObjectSummary body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateProvisioningWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get provisioning from auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='provisioningObjectSummaryId'>
            /// key: provisioningObjectSummary-id of provisioningObjectSummary
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftgraphprovisioningObjectSummary> GetProvisioningAsync(this IAuditLogs operations, string provisioningObjectSummaryId, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetProvisioningWithHttpMessagesAsync(provisioningObjectSummaryId, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the navigation property provisioning in auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New navigation property values
            /// </param>
            /// <param name='provisioningObjectSummaryId'>
            /// key: provisioningObjectSummary-id of provisioningObjectSummary
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateProvisioningAsync(this IAuditLogs operations, MicrosoftgraphprovisioningObjectSummary body, string provisioningObjectSummaryId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateProvisioningWithHttpMessagesAsync(body, provisioningObjectSummaryId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get restrictedSignIns from auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PathsauditlogsRestrictedsigninsgetresponses200contentapplicationJsonschema> ListRestrictedSignInsAsync(this IAuditLogs operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRestrictedSignInsWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new navigation property to restrictedSignIns for auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New navigation property
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftgraphrestrictedSignIn> CreateRestrictedSignInsAsync(this IAuditLogs operations, MicrosoftgraphrestrictedSignIn body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateRestrictedSignInsWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get restrictedSignIns from auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='restrictedSignInId'>
            /// key: restrictedSignIn-id of restrictedSignIn
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftgraphrestrictedSignIn> GetRestrictedSignInsAsync(this IAuditLogs operations, string restrictedSignInId, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetRestrictedSignInsWithHttpMessagesAsync(restrictedSignInId, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the navigation property restrictedSignIns in auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New navigation property values
            /// </param>
            /// <param name='restrictedSignInId'>
            /// key: restrictedSignIn-id of restrictedSignIn
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateRestrictedSignInsAsync(this IAuditLogs operations, MicrosoftgraphrestrictedSignIn body, string restrictedSignInId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateRestrictedSignInsWithHttpMessagesAsync(body, restrictedSignInId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get signIns from auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PathsauditlogsSigninsgetresponses200contentapplicationJsonschema> ListSignInsAsync(this IAuditLogs operations, IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSignInsWithHttpMessagesAsync(orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create new navigation property to signIns for auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New navigation property
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftgraphsignIn> CreateSignInsAsync(this IAuditLogs operations, MicrosoftgraphsignIn body, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateSignInsWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get signIns from auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='signInId'>
            /// key: signIn-id of signIn
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftgraphsignIn> GetSignInsAsync(this IAuditLogs operations, string signInId, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSignInsWithHttpMessagesAsync(signInId, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the navigation property signIns in auditLogs
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// New navigation property values
            /// </param>
            /// <param name='signInId'>
            /// key: signIn-id of signIn
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateSignInsAsync(this IAuditLogs operations, MicrosoftgraphsignIn body, string signInId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateSignInsWithHttpMessagesAsync(body, signInId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}