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
 * Do not modify this file. This file is generated from the wellarchitected-2020-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// This is the response object from the ListLensShares operation.
    /// </summary>
    public partial class ListLensSharesResponse : AmazonWebServiceResponse
    {
        private List<LensShareSummary> _lensShareSummaries = new List<LensShareSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property LensShareSummaries. 
        /// <para>
        /// A list of lens share summaries.
        /// </para>
        /// </summary>
        public List<LensShareSummary> LensShareSummaries
        {
            get { return this._lensShareSummaries; }
            set { this._lensShareSummaries = value; }
        }

        // Check to see if LensShareSummaries property is set
        internal bool IsSetLensShareSummaries()
        {
            return this._lensShareSummaries != null && this._lensShareSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
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

    }
}