// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class SsisMigrationInfo : IUtf8JsonSerializable, IJsonModel<SsisMigrationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SsisMigrationInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SsisMigrationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisMigrationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisMigrationInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SsisStoreType))
            {
                writer.WritePropertyName("ssisStoreType"u8);
                writer.WriteStringValue(SsisStoreType.Value.ToString());
            }
            if (Optional.IsDefined(ProjectOverwriteOption))
            {
                writer.WritePropertyName("projectOverwriteOption"u8);
                writer.WriteStringValue(ProjectOverwriteOption.Value.ToString());
            }
            if (Optional.IsDefined(EnvironmentOverwriteOption))
            {
                writer.WritePropertyName("environmentOverwriteOption"u8);
                writer.WriteStringValue(EnvironmentOverwriteOption.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        SsisMigrationInfo IJsonModel<SsisMigrationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisMigrationInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SsisMigrationInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSsisMigrationInfo(document.RootElement, options);
        }

        internal static SsisMigrationInfo DeserializeSsisMigrationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SsisStoreType? ssisStoreType = default;
            SsisMigrationOverwriteOption? projectOverwriteOption = default;
            SsisMigrationOverwriteOption? environmentOverwriteOption = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ssisStoreType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssisStoreType = new SsisStoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("projectOverwriteOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    projectOverwriteOption = new SsisMigrationOverwriteOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("environmentOverwriteOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    environmentOverwriteOption = new SsisMigrationOverwriteOption(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SsisMigrationInfo(ssisStoreType, projectOverwriteOption, environmentOverwriteOption, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SsisMigrationInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisMigrationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SsisMigrationInfo)} does not support writing '{options.Format}' format.");
            }
        }

        SsisMigrationInfo IPersistableModel<SsisMigrationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SsisMigrationInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSsisMigrationInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SsisMigrationInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SsisMigrationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
