/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// Container for the parameters to the GetArchitectureRecommendations operation.
    /// Returns a collection of recommendations to improve resilliance and readiness check
    /// quality for a Recovery Group.
    /// </summary>
    public partial class GetArchitectureRecommendationsRequest : AmazonRoute53RecoveryReadinessRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _recoveryGroupName;

        /// <summary>
        /// Gets and sets the property MaxResults. Upper bound on number of records to return.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. A token that can be used to resume pagination
        /// from the end of the collection.
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryGroupName. Name of RecoveryGroup (top level resource)
        /// to be analyzed.
        /// </summary>
        [AWSProperty(Required=true)]
        public string RecoveryGroupName
        {
            get { return this._recoveryGroupName; }
            set { this._recoveryGroupName = value; }
        }

        // Check to see if RecoveryGroupName property is set
        internal bool IsSetRecoveryGroupName()
        {
            return this._recoveryGroupName != null;
        }

    }
}