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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodePipeline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodePipeline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for StageState Object
    /// </summary>  
    public class StageStateUnmarshaller : IUnmarshaller<StageState, XmlUnmarshallerContext>, IUnmarshaller<StageState, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StageState IUnmarshaller<StageState, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public StageState Unmarshall(JsonUnmarshallerContext context)
        {
            StageState unmarshalledObject = new StageState();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actionStates", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ActionState, ActionStateUnmarshaller>(ActionStateUnmarshaller.Instance);
                    unmarshalledObject.ActionStates = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("beforeEntryConditionState", targetDepth))
                {
                    var unmarshaller = StageConditionStateUnmarshaller.Instance;
                    unmarshalledObject.BeforeEntryConditionState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inboundExecution", targetDepth))
                {
                    var unmarshaller = StageExecutionUnmarshaller.Instance;
                    unmarshalledObject.InboundExecution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inboundExecutions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StageExecution, StageExecutionUnmarshaller>(StageExecutionUnmarshaller.Instance);
                    unmarshalledObject.InboundExecutions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("inboundTransitionState", targetDepth))
                {
                    var unmarshaller = TransitionStateUnmarshaller.Instance;
                    unmarshalledObject.InboundTransitionState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("latestExecution", targetDepth))
                {
                    var unmarshaller = StageExecutionUnmarshaller.Instance;
                    unmarshalledObject.LatestExecution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("onFailureConditionState", targetDepth))
                {
                    var unmarshaller = StageConditionStateUnmarshaller.Instance;
                    unmarshalledObject.OnFailureConditionState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("onSuccessConditionState", targetDepth))
                {
                    var unmarshaller = StageConditionStateUnmarshaller.Instance;
                    unmarshalledObject.OnSuccessConditionState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("retryStageMetadata", targetDepth))
                {
                    var unmarshaller = RetryStageMetadataUnmarshaller.Instance;
                    unmarshalledObject.RetryStageMetadata = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("stageName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StageName = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StageStateUnmarshaller _instance = new StageStateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StageStateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}