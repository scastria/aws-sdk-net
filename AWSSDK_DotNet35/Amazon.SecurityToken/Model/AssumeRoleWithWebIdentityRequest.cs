/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the AssumeRoleWithWebIdentity operation.
    /// <para> Returns a set of temporary security credentials for users who have been authenticated in a mobile or web application with a web
    /// identity provider, such as Login with Amazon, Facebook, or Google. <c>AssumeRoleWithWebIdentity</c> is an API call that does not require the
    /// use of AWS security credentials. Therefore, you can distribute an application (for example, on mobile devices) that requests temporary
    /// security credentials without including long-term AWS credentials in the application or by deploying server-based proxy services that use
    /// long-term AWS credentials. For more information, see <a
    /// href="http://aws-docs-alpha.integ.amazon.com/STS/latest/UsingSTS/STSUseCases.html#MobileApplication-KnownProvider" >Creating a Mobile
    /// Application with Third-Party Sign-In</a> in <i>AWS Security Token Service</i> .
    /// </para> <para> The temporary security credentials consist of an access key ID, a secret access key, and a security token. Applications can
    /// use these temporary security credentials to sign calls to AWS service APIs. The credentials are valid for the duration that you specified
    /// when calling <c>AssumeRoleWithWebIdentity</c> , which can be from 900 seconds (15 minutes) to 3600 seconds (1 hour). By default, the
    /// temporary security credentials are valid for 1 hour. </para> <para> The temporary security credentials that are returned from the
    /// <c>AssumeRoleWithWebIdentity</c> response have the permissions that are associated with the access policy of the role being assumed. You can
    /// further restrict the permissions of the temporary security credentials by passing a policy in the request. The resulting permissions are an
    /// intersection of the role's access policy and the policy that you passed. These policies and any applicable resource-based policies are
    /// evaluated when calls to AWS service APIs are made using the temporary security credentials. </para> <para> Before your application can call
    /// <c>AssumeRoleWithWebIdentity</c> , you must have an identity token from a supported identity provider and create a role that the application
    /// can assume. The role that your application assumes must trust the identity provider that is associated with the identity token. In other
    /// words, the identity provider must be specified in the role's trust policy. For more information, see <a
    /// href="http://docs.aws.amazon.com/STS/latest/UsingSTS/CreatingWIF.html" > Creating Temporary Security Credentials for Mobile Apps Using
    /// Third-Party Identity Providers</a> .
    /// </para>
    /// </summary>
    public partial class AssumeRoleWithWebIdentityRequest : AmazonWebServiceRequest
    {
        private string roleArn;
        private string roleSessionName;
        private string webIdentityToken;
        private string providerId;
        private string policy;
        private int? durationSeconds;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the role that the caller is assuming.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>20 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this.roleArn; }
            set { this.roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this.roleArn != null;
        }

        /// <summary>
        /// An identifier for the assumed role session. Typically, you pass the name or identifier that is associated with the user who is using your
        /// application. That way, the temporary security credentials that your application will use are associated with that user. This session name is
        /// included as part of the ARN and assumed role ID in the <c>AssumedRoleUser</c> response element.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>2 - 32</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string RoleSessionName
        {
            get { return this.roleSessionName; }
            set { this.roleSessionName = value; }
        }

        // Check to see if RoleSessionName property is set
        internal bool IsSetRoleSessionName()
        {
            return this.roleSessionName != null;
        }

        /// <summary>
        /// The OAuth 2.0 access token or OpenID Connect ID token that is provided by the identity provider. Your application must get this token by
        /// authenticating the user who is using your application with a web identity provider before the application makes an
        /// <c>AssumeRoleWithWebIdentity</c> call.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string WebIdentityToken
        {
            get { return this.webIdentityToken; }
            set { this.webIdentityToken = value; }
        }

        // Check to see if WebIdentityToken property is set
        internal bool IsSetWebIdentityToken()
        {
            return this.webIdentityToken != null;
        }

        /// <summary>
        /// Specify this value only for OAuth access tokens. Do not specify this value for OpenID Connect ID tokens, such as <c>accounts.google.com</c>.
        /// This is the fully-qualified host component of the domain name of the identity provider. Do not include URL schemes and port numbers.
        /// Currently, <c>www.amazon.com</c> and <c>graph.facebook.com</c> are supported.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>4 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ProviderId
        {
            get { return this.providerId; }
            set { this.providerId = value; }
        }

        // Check to see if ProviderId property is set
        internal bool IsSetProviderId()
        {
            return this.providerId != null;
        }

        /// <summary>
        /// A supplemental policy that is associated with the temporary security credentials from the <c>AssumeRoleWithWebIdentity</c> call. The
        /// resulting permissions of the temporary security credentials are an intersection of this policy and the access policy that is associated with
        /// the role. Use this policy to further restrict the permissions of the temporary security credentials.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 2048</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0009\u000A\u000D\u0020-\u00FF]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Policy
        {
            get { return this.policy; }
            set { this.policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this.policy != null;
        }

        /// <summary>
        /// The duration, in seconds, of the role session. The value can range from 900 seconds (15 minutes) to 3600 seconds (1 hour). By default, the
        /// value is set to 3600 seconds.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>900 - 129600</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int DurationSeconds
        {
            get { return this.durationSeconds ?? default(int); }
            set { this.durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this.durationSeconds.HasValue;
        }

    }
}
    
