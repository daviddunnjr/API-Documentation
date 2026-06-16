using System;

namespace FakeApp.API
{
    /// <summary>
    /// Handles the processing and logging of incoming messages.
    /// Follows the Single Responsibility Principle by focusing on message handling.
    /// </summary>
    public class MessageHandler
    {
        /// <summary>
        /// Processes and logs a message to the console.
        /// </summary>
        /// <param name="message">The message to process.</param>
        public void ProcessMessage(Message message)
        {
            if (message == null)
                throw new ArgumentNullException(nameof(message));

            Console.WriteLine("=== Message Received ===");
            Console.WriteLine($"Content: {message.Content}");
            Console.WriteLine($"Author: {message.Metadata.AuthorName}");
            Console.WriteLine($"Created: {message.Metadata.CreationTime:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine("========================\n");
        }
    }
}
