#nullable enable

namespace Tripo.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTaskRequestVariant4TypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tripo.CreateTaskRequestVariant4Type?>
    {
        /// <inheritdoc />
        public override global::Tripo.CreateTaskRequestVariant4Type? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Tripo.CreateTaskRequestVariant4TypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tripo.CreateTaskRequestVariant4Type)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tripo.CreateTaskRequestVariant4Type? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Tripo.CreateTaskRequestVariant4TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
