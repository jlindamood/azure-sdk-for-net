// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningDeploymentResourceConfiguration. </summary>
    public partial class MachineLearningDeploymentResourceConfiguration : MachineLearningResourceConfiguration
    {
        /// <summary> Initializes a new instance of MachineLearningDeploymentResourceConfiguration. </summary>
        public MachineLearningDeploymentResourceConfiguration()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningDeploymentResourceConfiguration. </summary>
        /// <param name="instanceCount"> Optional number of instances or nodes used by the compute target. </param>
        /// <param name="instanceType"> Optional type of VM used as supported by the compute target. </param>
        /// <param name="locations"> Locations where the job can run. </param>
        /// <param name="maxInstanceCount">
        /// Optional max allowed number of instances or nodes to be used by the compute target.
        /// For use with elastic training, currently supported by PyTorch distribution type only.
        /// </param>
        /// <param name="properties"> Additional properties bag. </param>
        internal MachineLearningDeploymentResourceConfiguration(int? instanceCount, string instanceType, IList<string> locations, int? maxInstanceCount, IDictionary<string, BinaryData> properties) : base(instanceCount, instanceType, locations, maxInstanceCount, properties)
        {
        }
    }
}
