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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The overrides that should be sent to a container.
    /// </summary>
    public partial class ContainerOverrides
    {
        private List<string> _command = new List<string>();
        private List<KeyValuePair> _environment = new List<KeyValuePair>();
        private string _instanceType;
        private int? _memory;
        private List<ResourceRequirement> _resourceRequirements = new List<ResourceRequirement>();
        private int? _vcpus;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command to send to the container that overrides the default command from the Docker
        /// image or the job definition.
        /// </para>
        /// </summary>
        public List<string> Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null && this._command.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment variables to send to the container. You can add new environment variables,
        /// which are added to the container at launch, or you can override the existing environment
        /// variables from the Docker image or the job definition.
        /// </para>
        ///  <note> 
        /// <para>
        /// Environment variables must not start with <code>AWS_BATCH</code>; this naming convention
        /// is reserved for variables that are set by the Batch service.
        /// </para>
        ///  </note>
        /// </summary>
        public List<KeyValuePair> Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null && this._environment.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type to use for a multi-node parallel job.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to single-node container jobs or jobs that run on
        /// Fargate resources, and shouldn't be provided.
        /// </para>
        ///  </note>
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// This parameter indicates the amount of memory (in MiB) that's reserved for the job.
        /// It overrides the <code>memory</code> parameter set in the job definition, but doesn't
        /// override any memory requirement specified in the <code>ResourceRequirement</code>
        /// structure in the job definition. To override memory requirements that are specified
        /// in the <code>ResourceRequirement</code> structure in the job definition, <code>ResourceRequirement</code>
        /// must be specified in the <code>SubmitJob</code> request, with <code>type</code> set
        /// to <code>MEMORY</code> and <code>value</code> set to the new value.
        /// </para>
        ///  
        /// <para>
        /// This parameter is supported for jobs that run on EC2 resources, but isn't supported
        /// for jobs that run on Fargate resources. For these resources, use <code>resourceRequirement</code>
        /// instead.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, use resourceRequirements instead.")]
        public int Memory
        {
            get { return this._memory.GetValueOrDefault(); }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceRequirements. 
        /// <para>
        /// The type and amount of resources to assign to a container. This overrides the settings
        /// in the job definition. The supported resources include <code>GPU</code>, <code>MEMORY</code>,
        /// and <code>VCPU</code>.
        /// </para>
        /// </summary>
        public List<ResourceRequirement> ResourceRequirements
        {
            get { return this._resourceRequirements; }
            set { this._resourceRequirements = value; }
        }

        // Check to see if ResourceRequirements property is set
        internal bool IsSetResourceRequirements()
        {
            return this._resourceRequirements != null && this._resourceRequirements.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Vcpus. 
        /// <para>
        /// This parameter indicates the number of vCPUs reserved for the container.It overrides
        /// the <code>vcpus</code> parameter that's set in the job definition, but doesn't override
        /// any vCPU requirement specified in the <code>resourceRequirement</code> structure in
        /// the job definition. To override vCPU requirements that are specified in the <code>ResourceRequirement</code>
        /// structure in the job definition, <code>ResourceRequirement</code> must be specified
        /// in the <code>SubmitJob</code> request, with <code>type</code> set to <code>VCPU</code>
        /// and <code>value</code> set to the new value.
        /// </para>
        ///  
        /// <para>
        /// This parameter maps to <code>CpuShares</code> in the <a href="https://docs.docker.com/engine/api/v1.23/#create-a-container">Create
        /// a container</a> section of the <a href="https://docs.docker.com/engine/api/v1.23/">Docker
        /// Remote API</a> and the <code>--cpu-shares</code> option to <a href="https://docs.docker.com/engine/reference/run/">docker
        /// run</a>. Each vCPU is equivalent to 1,024 CPU shares. You must specify at least one
        /// vCPU.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is supported for jobs that run on EC2 resources, but isn't supported
        /// for jobs that run on Fargate resources. For Fargate resources, you can only use <code>resourceRequirement</code>.
        /// For EC2 resources, you can use either this parameter or <code>resourceRequirement</code>
        /// but not both.
        /// </para>
        ///  </note>
        /// </summary>
        [Obsolete("This field is deprecated, use resourceRequirements instead.")]
        public int Vcpus
        {
            get { return this._vcpus.GetValueOrDefault(); }
            set { this._vcpus = value; }
        }

        // Check to see if Vcpus property is set
        internal bool IsSetVcpus()
        {
            return this._vcpus.HasValue; 
        }

    }
}