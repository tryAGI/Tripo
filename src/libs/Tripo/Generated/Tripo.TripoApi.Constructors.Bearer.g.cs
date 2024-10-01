
#nullable enable

namespace Tripo
{
    public sealed partial class TripoApi
    {
        /// <inheritdoc cref="TripoApi(global::System.Net.Http.HttpClient?, global::System.Uri?, global::Tripo.EndPointAuthorization?)"/>
        public TripoApi(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::Tripo.EndPointAuthorization? authorization = null) : this(httpClient, baseUri, authorization)
        {
            Authorizing(_httpClient, ref apiKey);

            AuthorizeUsingBearer(apiKey);

            Authorized(_httpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);
    }
}