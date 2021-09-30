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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// The description of the plugin.
    /// </summary>
    public partial class PluginDescription
    {
        private CustomPluginDescription _customPlugin;

        /// <summary>
        /// Gets and sets the property CustomPlugin. 
        /// <para>
        /// Details about a custom plugin.
        /// </para>
        /// </summary>
        public CustomPluginDescription CustomPlugin
        {
            get { return this._customPlugin; }
            set { this._customPlugin = value; }
        }

        // Check to see if CustomPlugin property is set
        internal bool IsSetCustomPlugin()
        {
            return this._customPlugin != null;
        }

    }
}