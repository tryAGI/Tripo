
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
            typeof(global::Tripo.JsonConverters.OneOfJsonConverter<string, global::Tripo.MultiviewViewInput, global::Tripo.TaskReuseInput>),

            typeof(global::Tripo.JsonConverters.OneOfJsonConverter<string, global::Tripo.InputSourceObject>),

            typeof(global::Tripo.JsonConverters.OneOfJsonConverter<string, global::Tripo.InputSourceObject>),

            typeof(global::Tripo.JsonConverters.OneOfJsonConverter<string, global::Tripo.InputSourceObject>),

            typeof(global::Tripo.JsonConverters.OneOfJsonConverter<string, global::Tripo.InputSourceObject>),

            typeof(global::Tripo.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TextToModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.ImageToModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.MultiviewToModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tripo.OneOf<string, global::Tripo.MultiviewViewInput, global::Tripo.TaskReuseInput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.OneOf<string, global::Tripo.MultiviewViewInput, global::Tripo.TaskReuseInput>), TypeInfoPropertyName = "OneOfStringMultiviewViewInputTaskReuseInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.MultiviewViewInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TaskReuseInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.InputSourceObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.OneOf<string, global::Tripo.InputSourceObject>), TypeInfoPropertyName = "OneOfStringInputSourceObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.ImageToSplatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TextToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.ImageToImageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.ImageToMultiviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.EditMultiviewRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.ImportModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.RefineModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TextureModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.StylizeModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.ConvertModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.RigCheckRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.RigModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.RetargetAnimationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.SegmentMeshRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.SmartSegmentMeshRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.CompleteMeshRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.DecimateMeshRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TaskListRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.UploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.PresignFileUploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TaskCreatedData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TaskCreatedResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.Task))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TaskOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TaskError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.TaskListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tripo.Task>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.FileData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.FileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.UploadCredentialsData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.UploadCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.PresignFileUploadData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.PresignFileUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.BalanceData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.BalanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.UsageItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.UsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tripo.UsageItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tripo.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tripo.OneOf<string, global::Tripo.MultiviewViewInput, global::Tripo.TaskReuseInput>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tripo.Task>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tripo.UsageItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}