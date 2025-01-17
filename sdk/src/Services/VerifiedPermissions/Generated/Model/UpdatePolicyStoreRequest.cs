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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePolicyStore operation.
    /// Modifies the validation setting for a policy store.
    /// </summary>
    public partial class UpdatePolicyStoreRequest : AmazonVerifiedPermissionsRequest
    {
        private string _policyStoreId;
        private ValidationSettings _validationSettings;

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the ID of the policy store that you want to update
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyStoreId
        {
            get { return this._policyStoreId; }
            set { this._policyStoreId = value; }
        }

        // Check to see if PolicyStoreId property is set
        internal bool IsSetPolicyStoreId()
        {
            return this._policyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationSettings. 
        /// <para>
        /// A structure that defines the validation settings that want to enable for the policy
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidationSettings ValidationSettings
        {
            get { return this._validationSettings; }
            set { this._validationSettings = value; }
        }

        // Check to see if ValidationSettings property is set
        internal bool IsSetValidationSettings()
        {
            return this._validationSettings != null;
        }

    }
}