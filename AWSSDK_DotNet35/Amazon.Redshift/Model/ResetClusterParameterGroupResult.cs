/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Contains the output from the ModifyClusterParameterGroup and ResetClusterParameterGroup actions and indicate the parameter group
    /// involved and the status of the operation on the parameter group. </para>
    /// </summary>
    public partial class ResetClusterParameterGroupResult : AmazonWebServiceResponse
    {
        
        private string parameterGroupName;
        private string parameterGroupStatus;


        /// <summary>
        /// The name of the cluster parameter group.
        ///  
        /// </summary>
        public string ParameterGroupName
        {
            get { return this.parameterGroupName; }
            set { this.parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this.parameterGroupName != null;
        }

        /// <summary>
        /// The status of the parameter group. For example, if you made a change to a parameter group name-value pair, then the change could be pending
        /// a reboot of an associated cluster.
        ///  
        /// </summary>
        public string ParameterGroupStatus
        {
            get { return this.parameterGroupStatus; }
            set { this.parameterGroupStatus = value; }
        }

        // Check to see if ParameterGroupStatus property is set
        internal bool IsSetParameterGroupStatus()
        {
            return this.parameterGroupStatus != null;
        }
    }
}
