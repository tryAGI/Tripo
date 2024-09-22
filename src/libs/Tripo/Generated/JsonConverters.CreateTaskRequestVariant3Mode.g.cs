#nullable enable

namespace Tripo.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTaskRequestVariant3ModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tripo.CreateTaskRequestVariant3Mode>
    {
        /// <inheritdoc />
        public override global::Tripo.CreateTaskRequestVariant3Mode Read(
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
                        return global::Tripo.CreateTaskRequestVariant3ModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tripo.CreateTaskRequestVariant3Mode)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tripo.CreateTaskRequestVariant3Mode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Tripo.CreateTaskRequestVariant3ModeExtensions.ToValueString(value));
        }
    }
}
