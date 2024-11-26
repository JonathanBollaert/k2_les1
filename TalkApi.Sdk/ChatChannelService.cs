using System.Net.Http.Json;
using TalkApi.Model.Results;

namespace TalkApi.Sdk
{
    public class ChatChannelService(IHttpClientFactory httpClientFactory)
    {
        private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;

        public async Task<IList<ChatChannelResult>> Find()
        {
            var httpClient = _httpClientFactory.CreateClient("TalkApi");
            var route = "/api/chat-channels";
            var response = await httpClient.GetAsync(route);

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<IList<ChatChannelResult>>();

            if (result is null)
            {
                return new List<ChatChannelResult>();
            }

            return result;
        }
    }
}
