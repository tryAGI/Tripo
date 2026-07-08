#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained from https://developers.tripo3d.ai/en/docs (no public unauthenticated spec download)
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Tripo \
  --clientClassName TripoClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

rm -rf ../../cli/Tripo.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Tripo.CLI \
  --sdk-project ../../libs/Tripo/Tripo.csproj \
  --targetFramework net10.0 \
  --namespace Tripo \
  --clientClassName TripoClient \
  --package-id Tripo.CLI \
  --tool-command-name tripo \
  --user-secrets-id Tripo.CLI \
  --api-key-env-var TRIPO_API_KEY \
  --base-url-env-var TRIPO_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
