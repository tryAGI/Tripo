dotnet tool install --global autosdk.cli --prerelease

autosdk init \
  Tripo \
  TripoClient \
  https://raw.githubusercontent.com/api/openapi.json \
  tryAGI \
  --output .
