
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant7Animation
    {
        /// <summary>
        /// 
        /// </summary>
        Preset_walk,
        /// <summary>
        /// 
        /// </summary>
        Preset_run,
        /// <summary>
        /// 
        /// </summary>
        Preset_dive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant7AnimationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant7Animation value)
        {
            return value switch
            {
                CreateTaskRequestVariant7Animation.Preset_walk => "preset:walk",
                CreateTaskRequestVariant7Animation.Preset_run => "preset:run",
                CreateTaskRequestVariant7Animation.Preset_dive => "preset:dive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant7Animation? ToEnum(string value)
        {
            return value switch
            {
                "preset:walk" => CreateTaskRequestVariant7Animation.Preset_walk,
                "preset:run" => CreateTaskRequestVariant7Animation.Preset_run,
                "preset:dive" => CreateTaskRequestVariant7Animation.Preset_dive,
                _ => null,
            };
        }
    }
}