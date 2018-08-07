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

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an egress-only internet gateway.
    /// </summary>
    public partial class EgressOnlyInternetGateway
    {
        private List<InternetGatewayAttachment> _attachments = new List<InternetGatewayAttachment>();
        private string _egressOnlyInternetGatewayId;

        /// <summary>
        /// Gets and sets the property Attachments. 
        /// <para>
        /// Information about the attachment of the egress-only internet gateway.
        /// </para>
        /// </summary>
        public List<InternetGatewayAttachment> Attachments
        {
            get { return this._attachments; }
            set { this._attachments = value; }
        }

        // Check to see if Attachments property is set
        internal bool IsSetAttachments()
        {
            return this._attachments != null && this._attachments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EgressOnlyInternetGatewayId. 
        /// <para>
        /// The ID of the egress-only internet gateway.
        /// </para>
        /// </summary>
        public string EgressOnlyInternetGatewayId
        {
            get { return this._egressOnlyInternetGatewayId; }
            set { this._egressOnlyInternetGatewayId = value; }
        }

        // Check to see if EgressOnlyInternetGatewayId property is set
        internal bool IsSetEgressOnlyInternetGatewayId()
        {
            return this._egressOnlyInternetGatewayId != null;
        }

    }
}