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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the CopyClusterSnapshot operation.
    /// <para> Copies the specified automated cluster snapshot to a new manual cluster snapshot. The source must be an automated snapshot and it
    /// must be in the available state. </para> <para> When you delete a cluster, Amazon Redshift deletes any automated snapshots of the cluster.
    /// Also, when the retention period of the snapshot expires, Amazon Redshift automatically deletes it. If you want to keep an automated snapshot
    /// for a longer period, you can make a manual copy of the snapshot. Manual snapshots are retained until you delete them. </para> <para> For
    /// more information about working with snapshots, go to <a href="http://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html"
    /// >Amazon Redshift Snapshots</a> in the <i>Amazon Redshift Management Guide</i> .
    /// </para>
    /// </summary>
    public partial class CopyClusterSnapshotRequest : AmazonWebServiceRequest
    {
        private string sourceSnapshotIdentifier;
        private string sourceSnapshotClusterIdentifier;
        private string targetSnapshotIdentifier;

        /// <summary>
        /// The identifier for the source snapshot. Constraints: <ul> <li>Must be the identifier for a valid automated snapshot whose state is
        /// "available".</li> </ul>
        ///  
        /// </summary>
        public string SourceSnapshotIdentifier
        {
            get { return this.sourceSnapshotIdentifier; }
            set { this.sourceSnapshotIdentifier = value; }
        }

        // Check to see if SourceSnapshotIdentifier property is set
        internal bool IsSetSourceSnapshotIdentifier()
        {
            return this.sourceSnapshotIdentifier != null;
        }
        public string SourceSnapshotClusterIdentifier
        {
            get { return this.sourceSnapshotClusterIdentifier; }
            set { this.sourceSnapshotClusterIdentifier = value; }
        }

        // Check to see if SourceSnapshotClusterIdentifier property is set
        internal bool IsSetSourceSnapshotClusterIdentifier()
        {
            return this.sourceSnapshotClusterIdentifier != null;
        }

        /// <summary>
        /// The identifier given to the new manual snapshot. Constraints: <ul> <li>Cannot be null, empty, or blank.</li> <li>Must contain from 1 to 255
        /// alphanumeric characters or hyphens.</li> <li>First character must be a letter.</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens.</li> <li>Must be unique for the AWS account that is making the request.</li> </ul>
        ///  
        /// </summary>
        public string TargetSnapshotIdentifier
        {
            get { return this.targetSnapshotIdentifier; }
            set { this.targetSnapshotIdentifier = value; }
        }

        // Check to see if TargetSnapshotIdentifier property is set
        internal bool IsSetTargetSnapshotIdentifier()
        {
            return this.targetSnapshotIdentifier != null;
        }

    }
}
    
