
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant3ModelVersion
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        V1420240625,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant3ModelVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant3ModelVersion value)
        {
            return value switch
            {
                CreateTaskRequestVariant3ModelVersion.Default => "default",
                CreateTaskRequestVariant3ModelVersion.V1420240625 => "v1.4-20240625",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant3ModelVersion? ToEnum(string value)
        {
            return value switch
            {
                "default" => CreateTaskRequestVariant3ModelVersion.Default,
                "v1.4-20240625" => CreateTaskRequestVariant3ModelVersion.V1420240625,
                _ => null,
            };
        }
    }
}