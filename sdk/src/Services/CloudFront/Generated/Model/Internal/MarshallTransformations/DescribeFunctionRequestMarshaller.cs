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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeFunction Request Marshaller
    /// </summary>       
    public class DescribeFunctionRequestMarshaller : IMarshaller<IRequest, DescribeFunctionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeFunctionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeFunctionRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "GET";
            if (!publicRequest.IsSetName())
                throw new AmazonCloudFrontException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            
            if (publicRequest.IsSetStage())
                request.Parameters.Add("Stage", StringUtils.FromString(publicRequest.Stage));
            request.ResourcePath = "/2020-05-31/function/{Name}/describe";


            request.UseQueryString = true;
            return request;
        }
        private static DescribeFunctionRequestMarshaller _instance = new DescribeFunctionRequestMarshaller();        

        internal static DescribeFunctionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeFunctionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}