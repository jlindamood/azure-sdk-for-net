// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class DatabaseInviteFollowerResult
    {
        internal static DatabaseInviteFollowerResult DeserializeDatabaseInviteFollowerResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> generatedInvitation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("generatedInvitation"u8))
                {
                    generatedInvitation = property.Value.GetString();
                    continue;
                }
            }
            return new DatabaseInviteFollowerResult(generatedInvitation.Value);
        }
    }
}
