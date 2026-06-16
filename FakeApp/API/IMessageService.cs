using System.Threading.Tasks;

namespace FakeApp.API
{
    /// <summary>
    /// Defines the contract for sending messages to a remote service.
    /// </summary>
    public interface IMessageService
    {
        /// <summary>
        /// Sends a message asynchronously to the remote API.
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        Task SendMessageAsync(Message message);
    }
}
