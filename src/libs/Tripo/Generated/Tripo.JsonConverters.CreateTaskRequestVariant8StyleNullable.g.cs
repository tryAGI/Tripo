#nullable enable

namespace Tripo.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTaskRequestVariant8StyleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tripo.CreateTaskRequestVariant8Style?>
    {
        /// <inheritdoc />
        public override global::Tripo.CreateTaskRequestVariant8Style? Read(
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
                        return global::Tripo.CreateTaskRequestVariant8StyleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tripo.CreateTaskRequestVariant8Style)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Tripo.CreateTaskRequestVariant8Style?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tripo.CreateTaskRequestVariant8Style? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Tripo.CreateTaskRequestVariant8StyleExtensions.ToValueString(value.Value));
            }
        }
    }
}
