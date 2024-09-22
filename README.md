# Tripo

[![Nuget package](https://img.shields.io/nuget/vpre/Tripo)](https://www.nuget.org/packages/Tripo/)
[![dotnet](https://github.com/tryAGI/Tripo/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Tripo/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Tripo)](https://github.com/tryAGI/Tripo/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features 🔥
- Fully generated C# SDK based on [official Tripo OpenAPI specification](https://raw.githubusercontent.com/Tripo/assemblyai-api-spec/main/openapi.yml) using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Same day update to support new features
- Updated and supported automatically if there are no breaking changes
- All modern .NET features - nullability, trimming, NativeAOT, etc.
- Support .Net Framework/.Net Standard 2.0

### Usage
```csharp
using Tripo;

using var api = new TripoApi(apiKey);

SuccessTask response = await api.CreateTaskAsync(new CreateTaskRequestVariant1
{
    Type = CreateTaskRequestVariant1Type.TextToModel,
    Prompt = "Generate some girl face",
});

Console.WriteLine($"Code: {response.Code}");
Console.WriteLine($"TaskId: {response.Data.TaskId}");

await Task.Delay(TimeSpan.FromMinutes(1));

GetTaskResponse taskResponse = await api.GetTaskAsync(response.Data.TaskId);

Console.WriteLine($"Code: {taskResponse.Code}");
Console.WriteLine($"Status: {taskResponse.Data.Status}");
Console.WriteLine($"RenderedImage: {taskResponse.Data.Output.RenderedImage}");;
Console.WriteLine($"Model: {taskResponse.Data.Output.Model}");
Console.WriteLine($"PbrModel: {taskResponse.Data.Output.PbrModel}");
Console.WriteLine($"BaseModel: {taskResponse.Data.Output.BaseModel}");
```
![Result](assets/rendered_image.webp)

## Support

Priority place for bugs: https://github.com/tryAGI/Tripo/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Tripo/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).

![CodeRabbit logo](https://opengraph.githubassets.com/1c51002d7d0bbe0c4fd72ff8f2e58192702f73a7037102f77e4dbb98ac00ea8f/marketplace/coderabbitai)

This project is supported by CodeRabbit through the [Open Source Support Program](https://github.com/marketplace/coderabbitai).