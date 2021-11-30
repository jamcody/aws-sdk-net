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
    /// The choice level improvement plan.
    /// </summary>
    public partial class ChoiceImprovementPlan
    {
        private string _choiceId;
        private string _displayText;
        private string _improvementPlanUrl;

        /// <summary>
        /// Gets and sets the property ChoiceId.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ChoiceId
        {
            get { return this._choiceId; }
            set { this._choiceId = value; }
        }

        // Check to see if ChoiceId property is set
        internal bool IsSetChoiceId()
        {
            return this._choiceId != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayText. 
        /// <para>
        /// The display text for the improvement plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DisplayText
        {
            get { return this._displayText; }
            set { this._displayText = value; }
        }

        // Check to see if DisplayText property is set
        internal bool IsSetDisplayText()
        {
            return this._displayText != null;
        }

        /// <summary>
        /// Gets and sets the property ImprovementPlanUrl.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ImprovementPlanUrl
        {
            get { return this._improvementPlanUrl; }
            set { this._improvementPlanUrl = value; }
        }

        // Check to see if ImprovementPlanUrl property is set
        internal bool IsSetImprovementPlanUrl()
        {
            return this._improvementPlanUrl != null;
        }

    }
}