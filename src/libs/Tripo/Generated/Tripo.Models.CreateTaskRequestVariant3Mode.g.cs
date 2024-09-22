
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant3Mode
    {
        /// <summary>
        /// 
        /// </summary>
        LEFT,
        /// <summary>
        /// 
        /// </summary>
        RIGHT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant3ModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant3Mode value)
        {
            return value switch
            {
                CreateTaskRequestVariant3Mode.LEFT => "LEFT",
                CreateTaskRequestVariant3Mode.RIGHT => "RIGHT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant3Mode? ToEnum(string value)
        {
            return value switch
            {
                "LEFT" => CreateTaskRequestVariant3Mode.LEFT,
                "RIGHT" => CreateTaskRequestVariant3Mode.RIGHT,
                _ => null,
            };
        }
    }
}