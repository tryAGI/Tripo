# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

C# SDK for the [Tripo](https://www.tripo3d.ai/) AI 3D model generation platform, auto-generated from the Tripo OpenAPI specification using [AutoSDK](https://github.com/HavenDV/AutoSDK). Published as a NuGet package under the `tryAGI` organization.

## Build Commands

```bash
# Build the solution
dotnet build Tripo.slnx

# Build for release (also produces NuGet package)
dotnet build Tripo.slnx -c Release

# Run integration tests (requires TRIPO_API_KEY env var)
dotnet test src/tests/IntegrationTests/Tripo.IntegrationTests.csproj

# Regenerate SDK from OpenAPI spec
cd src/libs/Tripo && ./generate.sh
```

## Architecture

### Code Generation Pipeline

The SDK code is **entirely auto-generated** -- do not manually edit files in `src/libs/Tripo/Generated/`.

1. `src/libs/Tripo/openapi.yaml` -- the Tripo OpenAPI spec (see `https://platform.tripo3d.ai/docs/schema`)
3. `src/libs/Tripo/generate.sh` -- orchestrates: fix spec, run AutoSDK CLI, output to `Generated/`
4. CI auto-updates the spec and creates PRs if changes are detected

### Project Layout

| Project | Purpose |
|---------|---------|
| `src/libs/Tripo/` | Main SDK library (`TripoClient`) |
| `src/tests/IntegrationTests/` | Integration tests against real Tripo API |

### Documentation Generation

Tests in `src/tests/IntegrationTests/Examples` are the single source of truth for both test coverage and documentation:
- Each file has a JSDoc header (`order`, `title`, `slug`) consumed by `autosdk docs sync .`
- Comments prefixed with `////` become prose paragraphs in generated docs
- CI workflow (`.github/workflows/mkdocs.yml`) auto-generates `docs/examples/` and populates `EXAMPLES:START/END` markers in README.md, docs/index.md, and mkdocs.yml
- Config: `autosdk.docs.json` points to `src/tests/IntegrationTests/Examples`

### Build Configuration

- **Target:** `net10.0` (single target)
- **Language:** C# preview with nullable reference types
- **Signing:** Strong-named assemblies via `src/key.snk`
- **Versioning:** Semantic versioning from git tags (`v` prefix) via MinVer
- **Analysis:** All .NET analyzers enabled, AOT/trimming compatibility enforced
- **Testing:** MSTest + AwesomeAssertions

### CI/CD

- Uses shared workflows from `HavenDV/workflows` repo
- Dependabot updates NuGet packages weekly (auto-merged)
- Documentation deployed to GitHub Pages via MkDocs Material
