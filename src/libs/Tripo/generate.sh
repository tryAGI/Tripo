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
