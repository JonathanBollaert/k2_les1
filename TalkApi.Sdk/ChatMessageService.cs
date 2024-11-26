using System.Net.Http.Json;
using TalkApi.Model.Results;

namespace TalkApi.Sdk
{
    public class ChatMessageService(IHttpClientFactory httpClientFactory)
    {
        private readonly IHttpClientFactory _httpClientFactory = httpClientFactory;

        public async Task<IList<ChatMessageResult>> Find()
        {
            var httpClient = _httpClientFactory.CreateClient("TalkApi");
            var route = "/api/chat-messages";
            var response = await httpClient.GetAsync(route);

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadFromJsonAsync<IList<ChatMessageResult>>();

            if (result is null)
            {
                return new List<ChatMessageResult>();
            }

            return result;
        }
    }
}
