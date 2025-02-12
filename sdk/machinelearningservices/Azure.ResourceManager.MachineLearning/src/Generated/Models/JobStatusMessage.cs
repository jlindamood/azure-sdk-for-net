// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Active message associated with project. </summary>
    public partial class JobStatusMessage
    {
        /// <summary> Initializes a new instance of JobStatusMessage. </summary>
        internal JobStatusMessage()
        {
        }

        /// <summary> Initializes a new instance of JobStatusMessage. </summary>
        /// <param name="code"> Service-defined message code. </param>
        /// <param name="createdOn"> Time in UTC at which the message was created. </param>
        /// <param name="level"> Severity level of message. </param>
        /// <param name="message"> A human-readable representation of the message code. </param>
        internal JobStatusMessage(string code, DateTimeOffset? createdOn, JobStatusMessageLevel? level, string message)
        {
            Code = code;
            CreatedOn = createdOn;
            Level = level;
            Message = message;
        }

        /// <summary> Service-defined message code. </summary>
        public string Code { get; }
        /// <summary> Time in UTC at which the message was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Severity level of message. </summary>
        public JobStatusMessageLevel? Level { get; }
        /// <summary> A human-readable representation of the message code. </summary>
        public string Message { get; }
    }
}
