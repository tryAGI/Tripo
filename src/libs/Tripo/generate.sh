dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
# https://platform.tripo3d.ai/docs/schema
# curl -o openapi.yaml https://raw.githubusercontent.com/api/openapi.json
dotnet run --project ../../helpers/FixOpenApiSpec openapi.yaml
if [ $? -ne 0 ]; then
 echo "Failed, exiting..."
 exit 1
fi
autosdk generate openapi.yaml \
  --namespace Tripo \
  --clientClassName TripoApi \
  --targetFramework net8.0 \
  --output Generated \
  --exclude-deprecated-operations