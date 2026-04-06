
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Tripo.JsonConverters.TaskStatusJsonConverter),

            typeof(global::Tripo.JsonConverters.TaskStatusNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant1TypeJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant1TypeNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant1ModelVersionJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant1ModelVersionNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant2TypeJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant2TypeNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant2ModelVersionJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant2ModelVersionNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant3TypeJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant3TypeNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant3ModeJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant3ModeNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant3ModelVersionJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant3ModelVersionNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant4TypeJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant4TypeNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant5TypeJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant5TypeNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant6TypeJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant6TypeNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant7TypeJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant7TypeNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant7AnimationJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant7AnimationNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant8TypeJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant8TypeNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant8StyleJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant8StyleNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant9TypeJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant9TypeNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant9FormatJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant9FormatNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant9TextureFormatJsonConverter),

            typeof(global::Tripo.JsonConverters.CreateTaskRequestVariant9TextureFormatNullableJsonConverter),

            typeof(global::Tripo.JsonConverters.OneOfJsonConverter<global::Tripo.CreateTaskRequestVariant1, global::Tripo.CreateTaskRequestVariant2, global::Tripo.CreateTaskRequestVariant3, global::Tripo.CreateTaskRequestVariant4, global::Tripo.CreateTaskRequestVariant5, global::Tripo.CreateTaskRequestVariant6, global::Tripo.CreateTaskRequestVariant7, global::Tripo.CreateTaskRequestVariant8, global::Tripo.CreateTaskRequestVariant9>),

            typeof(global::Tripo.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.Task))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TaskOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.SuccessTask))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.SuccessTaskData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.Balance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.BalanceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.UploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.OneOf<global::Tripo.CreateTaskRequestVariant1, global::Tripo.CreateTaskRequestVariant2, global::Tripo.CreateTaskRequestVariant3, global::Tripo.CreateTaskRequestVariant4, global::Tripo.CreateTaskRequestVariant5, global::Tripo.CreateTaskRequestVariant6, global::Tripo.CreateTaskRequestVariant7, global::Tripo.CreateTaskRequestVariant8, global::Tripo.CreateTaskRequestVariant9>), TypeInfoPropertyName = "CreateTaskRequestVariant9_60225df588eab470")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant1Type), TypeInfoPropertyName = "CreateTaskRequestVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant1ModelVersion), TypeInfoPropertyName = "CreateTaskRequestVariant1ModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant2Type), TypeInfoPropertyName = "CreateTaskRequestVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant2File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant2ModelVersion), TypeInfoPropertyName = "CreateTaskRequestVariant2ModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant3Type), TypeInfoPropertyName = "CreateTaskRequestVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tripo.CreateTaskRequestVariant3File>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant3File))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant3Mode), TypeInfoPropertyName = "CreateTaskRequestVariant3Mode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant3ModelVersion), TypeInfoPropertyName = "CreateTaskRequestVariant3ModelVersion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant4Type), TypeInfoPropertyName = "CreateTaskRequestVariant4Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant5Type), TypeInfoPropertyName = "CreateTaskRequestVariant5Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant6Type), TypeInfoPropertyName = "CreateTaskRequestVariant6Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant7Type), TypeInfoPropertyName = "CreateTaskRequestVariant7Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant7Animation), TypeInfoPropertyName = "CreateTaskRequestVariant7Animation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant8Type), TypeInfoPropertyName = "CreateTaskRequestVariant8Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant8Style), TypeInfoPropertyName = "CreateTaskRequestVariant8Style2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant9Type), TypeInfoPropertyName = "CreateTaskRequestVariant9Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant9Format), TypeInfoPropertyName = "CreateTaskRequestVariant9Format2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskRequestVariant9TextureFormat), TypeInfoPropertyName = "CreateTaskRequestVariant9TextureFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.GetTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.GetTaskResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.UploadFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.UploadFileResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.UploadFileResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CreateTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.GetBalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.GetBalanceResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tripo.CreateTaskRequestVariant3File>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}