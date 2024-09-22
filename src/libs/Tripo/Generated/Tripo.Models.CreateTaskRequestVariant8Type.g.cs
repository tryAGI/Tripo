
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        StylizeModel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant8Type value)
        {
            return value switch
            {
                CreateTaskRequestVariant8Type.StylizeModel => "stylize_model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "stylize_model" => CreateTaskRequestVariant8Type.StylizeModel,
                _ => null,
            };
        }
    }
}