
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
        Gltf,
        /// <summary>
        /// 
        /// </summary>
        Usdz,
        /// <summary>
        /// 
        /// </summary>
        Fbx,
        /// <summary>
        /// 
        /// </summary>
        Obj,
        /// <summary>
        /// 
        /// </summary>
        Stl,
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
                CreateTaskRequestVariant9Format.Gltf => "GLTF",
                CreateTaskRequestVariant9Format.Usdz => "USDZ",
                CreateTaskRequestVariant9Format.Fbx => "FBX",
                CreateTaskRequestVariant9Format.Obj => "OBJ",
                CreateTaskRequestVariant9Format.Stl => "STL",
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
                "GLTF" => CreateTaskRequestVariant9Format.Gltf,
                "USDZ" => CreateTaskRequestVariant9Format.Usdz,
                "FBX" => CreateTaskRequestVariant9Format.Fbx,
                "OBJ" => CreateTaskRequestVariant9Format.Obj,
                "STL" => CreateTaskRequestVariant9Format.Stl,
                _ => null,
            };
        }
    }
}