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
    public partial class MigrateMySqlAzureDBForMySqlSyncTaskInput : IUtf8JsonSerializable, IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskInput)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("sourceConnectionInfo"u8);
            writer.WriteObjectValue(SourceConnectionInfo, options);
            writer.WritePropertyName("targetConnectionInfo"u8);
            writer.WriteObjectValue(TargetConnectionInfo, options);
            writer.WritePropertyName("selectedDatabases"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
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

        MigrateMySqlAzureDBForMySqlSyncTaskInput IJsonModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskInput(document.RootElement, options);
        }

        internal static MigrateMySqlAzureDBForMySqlSyncTaskInput DeserializeMigrateMySqlAzureDBForMySqlSyncTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MySqlConnectionInfo sourceConnectionInfo = default;
            MySqlConnectionInfo targetConnectionInfo = default;
            IList<MigrateMySqlAzureDBForMySqlSyncDatabaseInput> selectedDatabases = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = MySqlConnectionInfo.DeserializeMySqlConnectionInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateMySqlAzureDBForMySqlSyncDatabaseInput> array = new List<MigrateMySqlAzureDBForMySqlSyncDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateMySqlAzureDBForMySqlSyncDatabaseInput.DeserializeMigrateMySqlAzureDBForMySqlSyncDatabaseInput(item, options));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigrateMySqlAzureDBForMySqlSyncTaskInput(sourceConnectionInfo, targetConnectionInfo, selectedDatabases, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskInput)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateMySqlAzureDBForMySqlSyncTaskInput IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateMySqlAzureDBForMySqlSyncTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlSyncTaskInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateMySqlAzureDBForMySqlSyncTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
