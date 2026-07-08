
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Tripo
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TextToModelRequest? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.ImageToModelRequest? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.MultiviewToModelRequest? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tripo.OneOf<string, global::Tripo.MultiviewViewInput, global::Tripo.TaskReuseInput>>? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.OneOf<string, global::Tripo.MultiviewViewInput, global::Tripo.TaskReuseInput>? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.MultiviewViewInput? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TaskReuseInput? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.InputSourceObject? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public object? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.OneOf<string, global::Tripo.InputSourceObject>? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.ImageToSplatRequest? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TextToImageRequest? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.ImageToImageRequest? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.ImageToMultiviewRequest? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.EditMultiviewRequest? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.ImportModelRequest? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.RefineModelRequest? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TextureModelRequest? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.StylizeModelRequest? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.ConvertModelRequest? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.RigCheckRequest? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.RigModelRequest? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.RetargetAnimationRequest? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.SegmentMeshRequest? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.SmartSegmentMeshRequest? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.CompleteMeshRequest? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.DecimateMeshRequest? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TaskListRequest? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.UploadFileRequest? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public byte[]? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.PresignFileUploadRequest? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TaskCreatedData? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TaskCreatedResponse? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.Task? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TaskOutput? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TaskError? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TaskResponse? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.TaskListResponse? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tripo.Task>? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.FileData? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.FileResponse? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.UploadCredentialsData? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.UploadCredentialsResponse? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.PresignFileUploadData? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.PresignFileUploadResponse? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.BalanceData? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.BalanceResponse? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.UsageItem? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.UsageResponse? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tripo.UsageItem>? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tripo.ErrorResponse? Type57 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tripo.OneOf<string, global::Tripo.MultiviewViewInput, global::Tripo.TaskReuseInput>>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tripo.Task>? ListType3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tripo.UsageItem>? ListType4 { get; set; }
    }
}