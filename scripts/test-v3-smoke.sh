#!/usr/bin/env bash
set -euo pipefail

script_dir="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
repo_root="$(cd "${script_dir}/.." && pwd)"

if [[ ! -f "${repo_root}/.env" ]]; then
  echo "Missing ${repo_root}/.env. Add TRIPO_API_KEY before running the smoke test." >&2
  exit 1
fi

set -a
# shellcheck source=/dev/null
source "${repo_root}/.env"
set +a

export TRIPO_RUN_LIVE_SMOKE=true

dotnet test "${repo_root}/src/tests/IntegrationTests/Tripo.IntegrationTests.csproj" \
  --filter "TestCategory=LiveSmoke" \
  --logger "console;verbosity=detailed"
