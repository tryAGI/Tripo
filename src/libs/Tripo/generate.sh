#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from https://platform.tripo3d.ai/docs/schema (no public spec download)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
# https://platform.tripo3d.ai/docs/schema
# curl -o openapi.yaml https://raw.githubusercontent.com/api/openapi.json
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
