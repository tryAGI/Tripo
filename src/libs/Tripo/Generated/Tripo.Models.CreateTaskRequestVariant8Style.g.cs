
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant8Style
    {
        /// <summary>
        /// 
        /// </summary>
        Lego,
        /// <summary>
        /// 
        /// </summary>
        Voxel,
        /// <summary>
        /// 
        /// </summary>
        Voronoi,
        /// <summary>
        /// 
        /// </summary>
        Minecraft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant8StyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant8Style value)
        {
            return value switch
            {
                CreateTaskRequestVariant8Style.Lego => "lego",
                CreateTaskRequestVariant8Style.Voxel => "voxel",
                CreateTaskRequestVariant8Style.Voronoi => "voronoi",
                CreateTaskRequestVariant8Style.Minecraft => "minecraft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant8Style? ToEnum(string value)
        {
            return value switch
            {
                "lego" => CreateTaskRequestVariant8Style.Lego,
                "voxel" => CreateTaskRequestVariant8Style.Voxel,
                "voronoi" => CreateTaskRequestVariant8Style.Voronoi,
                "minecraft" => CreateTaskRequestVariant8Style.Minecraft,
                _ => null,
            };
        }
    }
}