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
    /// Container for the parameters to the GetReadinessCheckResourceStatus operation.
    /// Returns detailed information about the status of an individual resource within a Readiness
    /// Check's Resource Set.
    /// </summary>
    public partial class GetReadinessCheckResourceStatusRequest : AmazonRoute53RecoveryReadinessRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _readinessCheckName;
        private string _resourceIdentifier;

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
        /// Gets and sets the property NextToken. A token used to resume pagination from the end
        /// of a previous request.
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
        /// Gets and sets the property ReadinessCheckName. The ReadinessCheck to get
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReadinessCheckName
        {
            get { return this._readinessCheckName; }
            set { this._readinessCheckName = value; }
        }

        // Check to see if ReadinessCheckName property is set
        internal bool IsSetReadinessCheckName()
        {
            return this._readinessCheckName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. The resource ARN or component Id to
        /// get
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

    }
}