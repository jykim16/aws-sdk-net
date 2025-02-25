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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ClusterConfig Marshaller
    /// </summary>
    public class ClusterConfigMarshaller : IRequestMarshaller<ClusterConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ClusterConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetColdStorageOptions())
            {
                context.Writer.WritePropertyName("ColdStorageOptions");
                context.Writer.WriteObjectStart();

                var marshaller = ColdStorageOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.ColdStorageOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDedicatedMasterCount())
            {
                context.Writer.WritePropertyName("DedicatedMasterCount");
                context.Writer.Write(requestObject.DedicatedMasterCount);
            }

            if(requestObject.IsSetDedicatedMasterEnabled())
            {
                context.Writer.WritePropertyName("DedicatedMasterEnabled");
                context.Writer.Write(requestObject.DedicatedMasterEnabled);
            }

            if(requestObject.IsSetDedicatedMasterType())
            {
                context.Writer.WritePropertyName("DedicatedMasterType");
                context.Writer.Write(requestObject.DedicatedMasterType);
            }

            if(requestObject.IsSetInstanceCount())
            {
                context.Writer.WritePropertyName("InstanceCount");
                context.Writer.Write(requestObject.InstanceCount);
            }

            if(requestObject.IsSetInstanceType())
            {
                context.Writer.WritePropertyName("InstanceType");
                context.Writer.Write(requestObject.InstanceType);
            }

            if(requestObject.IsSetMultiAZWithStandbyEnabled())
            {
                context.Writer.WritePropertyName("MultiAZWithStandbyEnabled");
                context.Writer.Write(requestObject.MultiAZWithStandbyEnabled);
            }

            if(requestObject.IsSetNodeOptions())
            {
                context.Writer.WritePropertyName("NodeOptions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNodeOptionsListValue in requestObject.NodeOptions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = NodeOptionMarshaller.Instance;
                    marshaller.Marshall(requestObjectNodeOptionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetWarmCount())
            {
                context.Writer.WritePropertyName("WarmCount");
                context.Writer.Write(requestObject.WarmCount);
            }

            if(requestObject.IsSetWarmEnabled())
            {
                context.Writer.WritePropertyName("WarmEnabled");
                context.Writer.Write(requestObject.WarmEnabled);
            }

            if(requestObject.IsSetWarmType())
            {
                context.Writer.WritePropertyName("WarmType");
                context.Writer.Write(requestObject.WarmType);
            }

            if(requestObject.IsSetZoneAwarenessConfig())
            {
                context.Writer.WritePropertyName("ZoneAwarenessConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ZoneAwarenessConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ZoneAwarenessConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetZoneAwarenessEnabled())
            {
                context.Writer.WritePropertyName("ZoneAwarenessEnabled");
                context.Writer.Write(requestObject.ZoneAwarenessEnabled);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ClusterConfigMarshaller Instance = new ClusterConfigMarshaller();

    }
}