
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant9Format
    {
        /// <summary>
        /// 
        /// </summary>
        GLTF,
        /// <summary>
        /// 
        /// </summary>
        USDZ,
        /// <summary>
        /// 
        /// </summary>
        FBX,
        /// <summary>
        /// 
        /// </summary>
        OBJ,
        /// <summary>
        /// 
        /// </summary>
        STL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant9FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant9Format value)
        {
            return value switch
            {
                CreateTaskRequestVariant9Format.GLTF => "GLTF",
                CreateTaskRequestVariant9Format.USDZ => "USDZ",
                CreateTaskRequestVariant9Format.FBX => "FBX",
                CreateTaskRequestVariant9Format.OBJ => "OBJ",
                CreateTaskRequestVariant9Format.STL => "STL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant9Format? ToEnum(string value)
        {
            return value switch
            {
                "GLTF" => CreateTaskRequestVariant9Format.GLTF,
                "USDZ" => CreateTaskRequestVariant9Format.USDZ,
                "FBX" => CreateTaskRequestVariant9Format.FBX,
                "OBJ" => CreateTaskRequestVariant9Format.OBJ,
                "STL" => CreateTaskRequestVariant9Format.STL,
                _ => null,
            };
        }
    }
}