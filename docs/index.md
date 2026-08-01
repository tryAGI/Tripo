# Tripo

[![Nuget package](https://img.shields.io/nuget/vpre/Tripo)](https://www.nuget.org/packages/Tripo/)
[![dotnet](https://github.com/tryAGI/Tripo/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Tripo/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Tripo)](https://github.com/tryAGI/Tripo/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK for [Tripo API V3](https://developers.tripo3d.ai/en/docs/quick-start) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Tripo;

using var api = new TripoClient(apiKey);

TaskCreatedResponse response = await api.ThreeDGeneration.TextToModelAsync(new TextToModelRequest
{
    Prompt = "Generate a stylized explorer character",
    Model = "v3.1-20260211",
    Texture = true,
});

Console.WriteLine($"Code: {response.Code}");
Console.WriteLine($"TaskId: {response.Data.TaskId}");

await System.Threading.Tasks.Task.Delay(TimeSpan.FromMinutes(1));

TaskResponse taskResponse = await api.Tasks.GetTaskAsync(response.Data.TaskId);

Console.WriteLine($"Code: {taskResponse.Code}");
Console.WriteLine($"Status: {taskResponse.Data.Status}");
Console.WriteLine($"RenderedImage: {taskResponse.Data.Output?.RenderedImageUrl}");
Console.WriteLine($"Model: {taskResponse.Data.Output?.ModelUrl}");
```
![Result](assets/rendered_image.webp)

### Migrating from Tripo API V2

This SDK now targets `https://openapi.tripo3d.ai/v3`. Tripo ends V2 maintenance on October 1, 2026 and disables all V2
endpoints on November 1, 2026, both at 00:00 UTC.

- Replace the single V2 `CreateTaskAsync` call with the capability client, such as
  `api.ThreeDGeneration.TextToModelAsync(...)`.
- Supply `Model` for text-, image-, and multiview-to-model requests. Use `v2.5-20250123` to preserve V2's former
  default behavior, or opt into a newer model deliberately.
- Read V3 task outputs from `ModelUrl`, `RenderedImageUrl`, and `GeneratedImageUrl`; V2 output names such as
  `PbrModel`, `Model`, and `BaseModel` are retired.
- Read uploaded file references from `FileToken`, and poll `api.Tasks.GetTaskAsync(...)` because V2 WebSocket watch
  endpoints have no V3 equivalent.

See Tripo's [V2 to V3 migration guide](https://developers.tripo3d.ai/en/docs/migration-v2-to-v3) for the complete
endpoint and payload mapping.

### CLI

```bash
dotnet tool install --global Tripo.CLI --prerelease
tripo api --help
```

## Support

Priority place for bugs: https://github.com/tryAGI/Tripo/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Tripo/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
