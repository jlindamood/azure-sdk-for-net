// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DatabaseFleetManager.Models
{
    /// <summary> The node image upgrade to be applied to the target nodes in update run. </summary>
    internal partial class NodeImageSelection
    {
        /// <summary> Initializes a new instance of NodeImageSelection. </summary>
        /// <param name="selectionType"> The node image upgrade type. </param>
        public NodeImageSelection(NodeImageSelectionType selectionType)
        {
            SelectionType = selectionType;
        }

        /// <summary> The node image upgrade type. </summary>
        public NodeImageSelectionType SelectionType { get; set; }
    }
}
