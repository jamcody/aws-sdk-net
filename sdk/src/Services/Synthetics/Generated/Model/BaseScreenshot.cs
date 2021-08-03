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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class BaseScreenshot
    {
        private List<string> _ignoreCoordinates = new List<string>();
        private string _screenshotName;

        /// <summary>
        /// Gets and sets the property IgnoreCoordinates.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> IgnoreCoordinates
        {
            get { return this._ignoreCoordinates; }
            set { this._ignoreCoordinates = value; }
        }

        // Check to see if IgnoreCoordinates property is set
        internal bool IsSetIgnoreCoordinates()
        {
            return this._ignoreCoordinates != null && this._ignoreCoordinates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ScreenshotName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ScreenshotName
        {
            get { return this._screenshotName; }
            set { this._screenshotName = value; }
        }

        // Check to see if ScreenshotName property is set
        internal bool IsSetScreenshotName()
        {
            return this._screenshotName != null;
        }

    }
}