
#nullable enable

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateTaskRequestVariant9TextureFormat
    {
        /// <summary>
        /// 
        /// </summary>
        BMP,
        /// <summary>
        /// 
        /// </summary>
        DPX,
        /// <summary>
        /// 
        /// </summary>
        HDR,
        /// <summary>
        /// 
        /// </summary>
        JPEG,
        /// <summary>
        /// 
        /// </summary>
        OPENEXR,
        /// <summary>
        /// 
        /// </summary>
        PNG,
        /// <summary>
        /// 
        /// </summary>
        TARGA,
        /// <summary>
        /// 
        /// </summary>
        TIFF,
        /// <summary>
        /// 
        /// </summary>
        WEBP,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant9TextureFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant9TextureFormat value)
        {
            return value switch
            {
                CreateTaskRequestVariant9TextureFormat.BMP => "BMP",
                CreateTaskRequestVariant9TextureFormat.DPX => "DPX",
                CreateTaskRequestVariant9TextureFormat.HDR => "HDR",
                CreateTaskRequestVariant9TextureFormat.JPEG => "JPEG",
                CreateTaskRequestVariant9TextureFormat.OPENEXR => "OPEN_EXR",
                CreateTaskRequestVariant9TextureFormat.PNG => "PNG",
                CreateTaskRequestVariant9TextureFormat.TARGA => "TARGA",
                CreateTaskRequestVariant9TextureFormat.TIFF => "TIFF",
                CreateTaskRequestVariant9TextureFormat.WEBP => "WEBP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant9TextureFormat? ToEnum(string value)
        {
            return value switch
            {
                "BMP" => CreateTaskRequestVariant9TextureFormat.BMP,
                "DPX" => CreateTaskRequestVariant9TextureFormat.DPX,
                "HDR" => CreateTaskRequestVariant9TextureFormat.HDR,
                "JPEG" => CreateTaskRequestVariant9TextureFormat.JPEG,
                "OPEN_EXR" => CreateTaskRequestVariant9TextureFormat.OPENEXR,
                "PNG" => CreateTaskRequestVariant9TextureFormat.PNG,
                "TARGA" => CreateTaskRequestVariant9TextureFormat.TARGA,
                "TIFF" => CreateTaskRequestVariant9TextureFormat.TIFF,
                "WEBP" => CreateTaskRequestVariant9TextureFormat.WEBP,
                _ => null,
            };
        }
    }
}