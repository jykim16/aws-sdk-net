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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UserContext Marshaller
    /// </summary>       
    public class UserContextMarshaller : IRequestMarshaller<UserContext, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UserContext requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDataSourceGroups())
            {
                context.Writer.WritePropertyName("DataSourceGroups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDataSourceGroupsListValue in requestObject.DataSourceGroups)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectDataSourceGroupsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetGroups())
            {
                context.Writer.WritePropertyName("Groups");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectGroupsListValue in requestObject.Groups)
                {
                        context.Writer.Write(requestObjectGroupsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetToken())
            {
                context.Writer.WritePropertyName("Token");
                context.Writer.Write(requestObject.Token);
            }

            if(requestObject.IsSetUserId())
            {
                context.Writer.WritePropertyName("UserId");
                context.Writer.Write(requestObject.UserId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static UserContextMarshaller Instance = new UserContextMarshaller();

    }
}