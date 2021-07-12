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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Specifies capacity units configured for your enterprise edition index. You can add
    /// and remove capacity units to tune an index to your requirements.
    /// </summary>
    public partial class CapacityUnitsConfiguration
    {
        private int? _queryCapacityUnits;
        private int? _storageCapacityUnits;

        /// <summary>
        /// Gets and sets the property QueryCapacityUnits. 
        /// <para>
        /// The amount of extra query capacity for an index and <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_GetQuerySuggestions.html">GetQuerySuggestions</a>
        /// capacity.
        /// </para>
        ///  
        /// <para>
        /// A single extra capacity unit for an index provides 0.5 queries per second or approximately
        /// 40,000 queries per day.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetQuerySuggestions</code> capacity is 5 times the provisioned query capacity
        /// for an index. For example, the base capacity for an index is 0.5 queries per second,
        /// so GetQuerySuggestions capacity is 2.5 calls per second. If adding another 0.5 queries
        /// per second to total 1 queries per second for an index, the <code>GetQuerySuggestions</code>
        /// capacity is 5 calls per second.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int QueryCapacityUnits
        {
            get { return this._queryCapacityUnits.GetValueOrDefault(); }
            set { this._queryCapacityUnits = value; }
        }

        // Check to see if QueryCapacityUnits property is set
        internal bool IsSetQueryCapacityUnits()
        {
            return this._queryCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageCapacityUnits. 
        /// <para>
        /// The amount of extra storage capacity for an index. A single capacity unit for an index
        /// provides 150 GB of storage space or 500,000 documents, whichever is reached first.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int StorageCapacityUnits
        {
            get { return this._storageCapacityUnits.GetValueOrDefault(); }
            set { this._storageCapacityUnits = value; }
        }

        // Check to see if StorageCapacityUnits property is set
        internal bool IsSetStorageCapacityUnits()
        {
            return this._storageCapacityUnits.HasValue; 
        }

    }
}