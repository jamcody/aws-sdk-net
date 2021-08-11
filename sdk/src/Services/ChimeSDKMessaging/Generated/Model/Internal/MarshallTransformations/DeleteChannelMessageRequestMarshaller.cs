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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteChannelMessage Request Marshaller
    /// </summary>       
    public class DeleteChannelMessageRequestMarshaller : IMarshaller<IRequest, DeleteChannelMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteChannelMessageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteChannelMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";            
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetChannelArn())
                throw new AmazonChimeSDKMessagingException("Request object does not have required field ChannelArn set");
            request.AddPathResource("{channelArn}", StringUtils.FromString(publicRequest.ChannelArn));
            if (!publicRequest.IsSetMessageId())
                throw new AmazonChimeSDKMessagingException("Request object does not have required field MessageId set");
            request.AddPathResource("{messageId}", StringUtils.FromString(publicRequest.MessageId));
            request.ResourcePath = "/channels/{channelArn}/messages/{messageId}";
        
            if(publicRequest.IsSetChimeBearer())
                request.Headers["x-amz-chime-bearer"] = publicRequest.ChimeBearer;

            return request;
        }
        private static DeleteChannelMessageRequestMarshaller _instance = new DeleteChannelMessageRequestMarshaller();        

        internal static DeleteChannelMessageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteChannelMessageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}