using System.Net;
using System.Xml.Serialization;
using Mlt.Api.Base.Exceptions;
using System.Text.Json;

namespace Mlt.Api.Base.Services;

public abstract class BaseSvc
{
    private readonly HttpClient _client;

    protected BaseSvc(IHttpClientFactory clientFactory, string clientName)
        => _client = clientFactory.CreateClient(clientName);

    protected BaseSvc(HttpClient client)
        => _client = client;

    protected async Task<T> GetAsync<T>(string requestUri)
        => await ProcessRep<T>(await _client.GetAsync(requestUri));

    protected async Task<T> PostAsync<T>(string requestUri, IEnumerable<KeyValuePair<string, string>> content)
        => await ProcessRep<T>(await _client.PostAsync(requestUri, new FormUrlEncodedContent(content)));

    protected async Task<T> PostAsync<T>(string requestUri, string content)
        => await ProcessRep<T>(await _client.SendAsync(new HttpRequestMessage(HttpMethod.Post, requestUri)
                                                       { Content = new StringContent(content) }));

    private static async Task<T> ProcessRep<T>(HttpResponseMessage rep)
        => (rep.StatusCode switch
            {
                HttpStatusCode.OK => await TryDeserializeObject<T>(rep),
                HttpStatusCode.NoContent when typeof(T) == typeof(string) => (T)(object)rep.Content.ReadAsStringAsync()
                                                                                           .Result,
                HttpStatusCode.Created => await TryDeserializeObject<T>(rep),
                HttpStatusCode.NotFound =>
                    throw new
                        NotFoundException($"Call to {rep.RequestMessage!.RequestUri} returned {rep.StatusCode}: {rep}"),
                HttpStatusCode.Unauthorized => throw new
                    UnauthorizedAccessException($"Call to {rep.RequestMessage!.RequestUri} returned {rep.StatusCode}: {rep}"),
                _ => throw new
                    HttpRequestException($"Call to {rep.RequestMessage!.RequestUri} returned {rep.StatusCode}: {rep}")
            })!;

    private static async Task<T?> TryDeserializeObject<T>(HttpResponseMessage rep)
    {
        T? ret = default;

        if (rep.Content is { })
        {
            var contentStream = await rep.Content.ReadAsStreamAsync();

            switch (rep.Content.Headers.ContentType?.MediaType)
            {
                case "application/json":
                    ret = await JsonSerializer.DeserializeAsync<T>(contentStream);

                    break;
                case "application/xml":
                case "text/xml":
                {
                    ret = (T)new XmlSerializer(typeof(T)).Deserialize(contentStream)!;

                    break;
                }
            }
        }

        return ret;
    }
}