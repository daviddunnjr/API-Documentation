using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FakeApp.API
{
    /// <summary>
    /// Implements the IMessageService interface to send messages to a remote HTTP API.
    /// </summary>
    public class MessageService : IMessageService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        /// <summary>
        /// Initializes a new instance of the MessageService class.
        /// </summary>
        /// <param name="httpClient">The HTTP client to use for API communication.</param>
        /// <param name="baseUrl">The base URL of the API endpoint.</param>
        public MessageService(HttpClient httpClient, string baseUrl)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _baseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
        }

        /// <summary>
        /// Sends a message asynchronously to the remote API.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task SendMessageAsync(Message message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            var response = await _httpClient.PostAsJsonAsync($"{_baseUrl}/message", message);
            response.EnsureSuccessStatusCode();
        }
    }
}
