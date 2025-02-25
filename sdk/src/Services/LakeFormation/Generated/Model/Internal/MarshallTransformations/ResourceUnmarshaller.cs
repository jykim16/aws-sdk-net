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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Resource Object
    /// </summary>  
    public class ResourceUnmarshaller : IUnmarshaller<Resource, XmlUnmarshallerContext>, IUnmarshaller<Resource, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Resource IUnmarshaller<Resource, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Resource Unmarshall(JsonUnmarshallerContext context)
        {
            Resource unmarshalledObject = new Resource();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Catalog", targetDepth))
                {
                    var unmarshaller = CatalogResourceUnmarshaller.Instance;
                    unmarshalledObject.Catalog = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Database", targetDepth))
                {
                    var unmarshaller = DatabaseResourceUnmarshaller.Instance;
                    unmarshalledObject.Database = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataCellsFilter", targetDepth))
                {
                    var unmarshaller = DataCellsFilterResourceUnmarshaller.Instance;
                    unmarshalledObject.DataCellsFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DataLocation", targetDepth))
                {
                    var unmarshaller = DataLocationResourceUnmarshaller.Instance;
                    unmarshalledObject.DataLocation = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LFTag", targetDepth))
                {
                    var unmarshaller = LFTagKeyResourceUnmarshaller.Instance;
                    unmarshalledObject.LFTag = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LFTagExpression", targetDepth))
                {
                    var unmarshaller = LFTagExpressionResourceUnmarshaller.Instance;
                    unmarshalledObject.LFTagExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LFTagPolicy", targetDepth))
                {
                    var unmarshaller = LFTagPolicyResourceUnmarshaller.Instance;
                    unmarshalledObject.LFTagPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Table", targetDepth))
                {
                    var unmarshaller = TableResourceUnmarshaller.Instance;
                    unmarshalledObject.Table = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TableWithColumns", targetDepth))
                {
                    var unmarshaller = TableWithColumnsResourceUnmarshaller.Instance;
                    unmarshalledObject.TableWithColumns = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResourceUnmarshaller _instance = new ResourceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}