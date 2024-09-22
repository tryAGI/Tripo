
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        TextToModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant1Type value)
        {
            return value switch
            {
                CreateTaskRequestVariant1Type.TextToModel => "text_to_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "text_to_model" => CreateTaskRequestVariant1Type.TextToModel,
                _ => null,
            };
        }
    }
}