//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Linq;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// FinancialTransaction Service class
    /// </summary>
    public partial class FinancialTransactionService : Service<FinancialTransaction>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinancialTransactionService"/> class
        /// </summary>
        /// <param name="context">The context.</param>
        public FinancialTransactionService(RockContext context) : base(context)
        {
        }

        /// <summary>
        /// Determines whether this instance can delete the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <returns>
        ///   <c>true</c> if this instance can delete the specified item; otherwise, <c>false</c>.
        /// </returns>
        public bool CanDelete( FinancialTransaction item, out string errorMessage )
        {
            errorMessage = string.Empty;
 
            if ( new Service<FinancialTransactionRefund>( Context ).Queryable().Any( a => a.OriginalTransactionId == item.Id ) )
            {
                errorMessage = string.Format( "This {0} is assigned to a {1}.", FinancialTransaction.FriendlyTypeName, FinancialTransactionRefund.FriendlyTypeName );
                return false;
            }  
            return true;
        }
    }

    /// <summary>
    /// Generated Extension Methods
    /// </summary>
    public static partial class FinancialTransactionExtensionMethods
    {
        /// <summary>
        /// Clones this FinancialTransaction object to a new FinancialTransaction object
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="deepCopy">if set to <c>true</c> a deep copy is made. If false, only the basic entity properties are copied.</param>
        /// <returns></returns>
        public static FinancialTransaction Clone( this FinancialTransaction source, bool deepCopy )
        {
            if (deepCopy)
            {
                return source.Clone() as FinancialTransaction;
            }
            else
            {
                var target = new FinancialTransaction();
                target.CopyPropertiesFrom( source );
                return target;
            }
        }

        /// <summary>
        /// Copies the properties from another FinancialTransaction object to this FinancialTransaction object
        /// </summary>
        /// <param name="target">The target.</param>
        /// <param name="source">The source.</param>
        public static void CopyPropertiesFrom( this FinancialTransaction target, FinancialTransaction source )
        {
            target.Id = source.Id;
            target.AuthorizedPersonAliasId = source.AuthorizedPersonAliasId;
            target.BatchId = source.BatchId;
            target.CheckMicrEncrypted = source.CheckMicrEncrypted;
            target.CheckMicrHash = source.CheckMicrHash;
            target.CheckMicrParts = source.CheckMicrParts;
            target.FinancialGatewayId = source.FinancialGatewayId;
            target.FinancialPaymentDetailId = source.FinancialPaymentDetailId;
            target.ForeignGuid = source.ForeignGuid;
            target.ForeignKey = source.ForeignKey;
            target.HistoryChanges = source.HistoryChanges;
            target.IsReconciled = source.IsReconciled;
            target.IsSettled = source.IsSettled;
            target.MICRStatus = source.MICRStatus;
            target.ProcessedByPersonAliasId = source.ProcessedByPersonAliasId;
            target.ProcessedDateTime = source.ProcessedDateTime;
            target.ScheduledTransactionId = source.ScheduledTransactionId;
            target.SettledDate = source.SettledDate;
            target.SettledGroupId = source.SettledGroupId;
            target.ShowAsAnonymous = source.ShowAsAnonymous;
            target.SourceTypeValueId = source.SourceTypeValueId;
            target.Status = source.Status;
            target.StatusMessage = source.StatusMessage;
            target.Summary = source.Summary;
            target.TransactionCode = source.TransactionCode;
            target.TransactionDateTime = source.TransactionDateTime;
            target.TransactionTypeValueId = source.TransactionTypeValueId;
            target.CreatedDateTime = source.CreatedDateTime;
            target.ModifiedDateTime = source.ModifiedDateTime;
            target.CreatedByPersonAliasId = source.CreatedByPersonAliasId;
            target.ModifiedByPersonAliasId = source.ModifiedByPersonAliasId;
            target.Guid = source.Guid;
            target.ForeignId = source.ForeignId;

        }
    }
}
