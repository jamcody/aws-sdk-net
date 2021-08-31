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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// This is the response object from the DescribeSubnetGroups operation.
    /// </summary>
    public partial class DescribeSubnetGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SubnetGroup> _subnetGroups = new List<SubnetGroup>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An optional argument to pass in case the total number of records exceeds the value
        /// of MaxResults. If nextToken is returned, there are more results available. The value
        /// of nextToken is a unique pagination token for each page. Make the call again using
        /// the returned token to retrieve the next page. Keep all other arguments unchanged.
        /// 
        /// </para>
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
        /// Gets and sets the property SubnetGroups. 
        /// <para>
        /// A list of subnet groups. Each element in the list contains detailed information about
        /// one group.
        /// </para>
        /// </summary>
        public List<SubnetGroup> SubnetGroups
        {
            get { return this._subnetGroups; }
            set { this._subnetGroups = value; }
        }

        // Check to see if SubnetGroups property is set
        internal bool IsSetSubnetGroups()
        {
            return this._subnetGroups != null && this._subnetGroups.Count > 0; 
        }

    }
}