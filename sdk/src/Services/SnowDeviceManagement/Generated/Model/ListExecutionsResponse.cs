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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SnowDeviceManagement.Model
{
    /// <summary>
    /// This is the response object from the ListExecutions operation.
    /// </summary>
    public partial class ListExecutionsResponse : AmazonWebServiceResponse
    {
        private List<ExecutionSummary> _executions = new List<ExecutionSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Executions. 
        /// <para>
        /// A list of executions. Each execution contains the task ID, the device that the task
        /// is executing on, the execution ID, and the status of the execution.
        /// </para>
        /// </summary>
        public List<ExecutionSummary> Executions
        {
            get { return this._executions; }
            set { this._executions = value; }
        }

        // Check to see if Executions property is set
        internal bool IsSetExecutions()
        {
            return this._executions != null && this._executions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token to continue to the next page of executions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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