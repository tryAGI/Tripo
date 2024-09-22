#nullable enable

namespace Tripo.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTaskRequestVariant7AnimationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tripo.CreateTaskRequestVariant7Animation>
    {
        /// <inheritdoc />
        public override global::Tripo.CreateTaskRequestVariant7Animation Read(
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
                        return global::Tripo.CreateTaskRequestVariant7AnimationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tripo.CreateTaskRequestVariant7Animation)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tripo.CreateTaskRequestVariant7Animation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Tripo.CreateTaskRequestVariant7AnimationExtensions.ToValueString(value));
        }
    }
}
