// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.JobRouter;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> A unit of work to be routed. </summary>
    public partial class RouterJob
    {
        /// <summary> Initializes a new instance of RouterJob. </summary>
        /// <param name="id"> The id of the job. </param>
        /// <param name="channelReference"> Reference to an external parent context, eg. call ID. </param>
        /// <param name="status"> The status of the Job. </param>
        /// <param name="enqueuedAt"> The time a job was queued in UTC. </param>
        /// <param name="channelId"> The channel identifier. eg. voice, chat, etc. </param>
        /// <param name="classificationPolicyId"> The Id of the Classification policy used for classifying a job. </param>
        /// <param name="queueId"> The Id of the Queue that this job is queued to. </param>
        /// <param name="priority"> The priority of this job. </param>
        /// <param name="dispositionCode"> Reason code for cancelled or closed jobs. </param>
        /// <param name="requestedWorkerSelectors"> A collection of manually specified label selectors, which a worker must satisfy in order to process this job. </param>
        /// <param name="attachedWorkerSelectors"> A collection of label selectors attached by a classification policy, which a worker must satisfy in order to process this job. </param>
        /// <param name="labels"> A set of key/value pairs that are identifying attributes used by the rules engines to make decisions. </param>
        /// <param name="assignments">
        /// A collection of the assignments of the job.
        /// Key is AssignmentId.
        /// </param>
        /// <param name="tags"> A set of non-identifying attributes attached to this job. </param>
        /// <param name="notes"> Notes attached to a job, sorted by timestamp. </param>
        /// <param name="scheduledAt"> If set, job will be scheduled to be enqueued at a given time. </param>
        /// <param name="matchingMode"></param>
        internal RouterJob(string id, string channelReference, RouterJobStatus? status, DateTimeOffset? enqueuedAt, string channelId, string classificationPolicyId, string queueId, int? priority, string dispositionCode, IList<RouterWorkerSelector> requestedWorkerSelectors, IReadOnlyList<RouterWorkerSelector> attachedWorkerSelectors, IDictionary<string, object> labels, IReadOnlyDictionary<string, RouterJobAssignment> assignments, IDictionary<string, object> tags, IDictionary<string, string> notes, DateTimeOffset? scheduledAt, JobMatchingMode matchingMode)
        {
            Id = id;
            ChannelReference = channelReference;
            Status = status;
            EnqueuedAt = enqueuedAt;
            ChannelId = channelId;
            ClassificationPolicyId = classificationPolicyId;
            QueueId = queueId;
            Priority = priority;
            DispositionCode = dispositionCode;
            _requestedWorkerSelectors = requestedWorkerSelectors;
            AttachedWorkerSelectors = attachedWorkerSelectors;
            _labels = labels;
            Assignments = assignments;
            _tags = tags;
            _notes = notes;
            ScheduledAt = scheduledAt;
            MatchingMode = matchingMode;
        }

        /// <summary> The id of the job. </summary>
        public string Id { get; }
        /// <summary> The status of the Job. </summary>
        public RouterJobStatus? Status { get; }
        /// <summary> The time a job was queued in UTC. </summary>
        public DateTimeOffset? EnqueuedAt { get; }
        /// <summary> A collection of label selectors attached by a classification policy, which a worker must satisfy in order to process this job. </summary>
        public IReadOnlyList<RouterWorkerSelector> AttachedWorkerSelectors { get; }
        /// <summary>
        /// A collection of the assignments of the job.
        /// Key is AssignmentId.
        /// </summary>
        public IReadOnlyDictionary<string, RouterJobAssignment> Assignments { get; }
        /// <summary> If set, job will be scheduled to be enqueued at a given time. </summary>
        public DateTimeOffset? ScheduledAt { get; }
    }
}
