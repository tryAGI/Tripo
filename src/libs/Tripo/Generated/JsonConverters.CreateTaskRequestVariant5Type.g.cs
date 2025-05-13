#nullable enable

namespace Tripo.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTaskRequestVariant5TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tripo.CreateTaskRequestVariant5Type>
    {
        /// <inheritdoc />
        public override global::Tripo.CreateTaskRequestVariant5Type Read(
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
                        return global::Tripo.CreateTaskRequestVariant5TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tripo.CreateTaskRequestVariant5Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Tripo.CreateTaskRequestVariant5Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tripo.CreateTaskRequestVariant5Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Tripo.CreateTaskRequestVariant5TypeExtensions.ToValueString(value));
        }
    }
}
