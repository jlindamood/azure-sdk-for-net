// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Secret definition. </summary>
    public partial class ContainerAppWritableSecret
    {
        /// <summary> Initializes a new instance of ContainerAppWritableSecret. </summary>
        public ContainerAppWritableSecret()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppWritableSecret. </summary>
        /// <param name="name"> Secret Name. </param>
        /// <param name="value"> Secret Value. </param>
        /// <param name="identity"> Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned identity. </param>
        /// <param name="keyVaultUri"> Azure Key Vault URL pointing to the secret referenced by the container app. </param>
        internal ContainerAppWritableSecret(string name, string value, string identity, Uri keyVaultUri)
        {
            Name = name;
            Value = value;
            Identity = identity;
            KeyVaultUri = keyVaultUri;
        }

        /// <summary> Secret Name. </summary>
        public string Name { get; set; }
        /// <summary> Secret Value. </summary>
        public string Value { get; set; }
        /// <summary> Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned identity. </summary>
        public string Identity { get; set; }
        /// <summary> Azure Key Vault URL pointing to the secret referenced by the container app. </summary>
        public Uri KeyVaultUri { get; set; }
    }
}
