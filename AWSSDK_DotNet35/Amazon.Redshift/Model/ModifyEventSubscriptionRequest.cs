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
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyEventSubscription operation.
    /// <para> Modifies an existing Amazon Redshift event notification subscription. </para>
    /// </summary>
    public partial class ModifyEventSubscriptionRequest : AmazonRedshiftRequest
    {
        private string subscriptionName;
        private string snsTopicArn;
        private string sourceType;
        private List<string> sourceIds = new List<string>();
        private List<string> eventCategories = new List<string>();
        private string severity;
        private bool? enabled;


        /// <summary>
        /// The name of the modified Amazon Redshift event notification subscription.
        ///  
        /// </summary>
        public string SubscriptionName
        {
            get { return this.subscriptionName; }
            set { this.subscriptionName = value; }
        }

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this.subscriptionName != null;
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the SNS topic to be used by the event notification subscription.
        ///  
        /// </summary>
        public string SnsTopicArn
        {
            get { return this.snsTopicArn; }
            set { this.snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this.snsTopicArn != null;
        }

        /// <summary>
        /// The type of source that will be generating the events. For example, if you want to be notified of events generated by a cluster, you would
        /// set this parameter to cluster. If this value is not specified, events are returned for all Amazon Redshift objects in your AWS account. You
        /// must specify a source type in order to specify source IDs. Valid values: cluster, cluster-parameter-group, cluster-security-group, and
        /// cluster-snapshot.
        ///  
        /// </summary>
        public string SourceType
        {
            get { return this.sourceType; }
            set { this.sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this.sourceType != null;
        }

        /// <summary>
        /// A list of one or more identifiers of Amazon Redshift source objects. All of the objects must be of the same type as was specified in the
        /// source type parameter. The event subscription will return only events generated by the specified objects. If not specified, then events are
        /// returned for all objects within the source type specified. Example: my-cluster-1, my-cluster-2 Example: my-snapshot-20131010
        ///  
        /// </summary>
        public List<string> SourceIds
        {
            get { return this.sourceIds; }
            set { this.sourceIds = value; }
        }

        // Check to see if SourceIds property is set
        internal bool IsSetSourceIds()
        {
            return this.sourceIds.Count > 0;
        }

        /// <summary>
        /// Specifies the Amazon Redshift event categories to be published by the event notification subscription. Values: Configuration, Management,
        /// Monitoring, Security
        ///  
        /// </summary>
        public List<string> EventCategories
        {
            get { return this.eventCategories; }
            set { this.eventCategories = value; }
        }

        // Check to see if EventCategories property is set
        internal bool IsSetEventCategories()
        {
            return this.eventCategories.Count > 0;
        }

        /// <summary>
        /// Specifies the Amazon Redshift event severity to be published by the event notification subscription. Values: ERROR, INFO
        ///  
        /// </summary>
        public string Severity
        {
            get { return this.severity; }
            set { this.severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this.severity != null;
        }

        /// <summary>
        /// A Boolean value indicating if the subscription is enabled. <c>true</c> indicates the subscription is enabled
        ///  
        /// </summary>
        public bool Enabled
        {
            get { return this.enabled ?? default(bool); }
            set { this.enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this.enabled.HasValue;
        }

    }
}
    
