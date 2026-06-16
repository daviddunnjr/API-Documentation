namespace FakeApp.API
{
    /// <summary>
    /// Represents a message with content and metadata.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the Message class with the specified content and metadata.
    /// </remarks>
    /// <param name="content"></param>
    /// <param name="metadata"></param>
    public class Message(string content, Metadata metadata)
    {
        /// <summary>
        /// Gets or sets the content of the message.
        /// </summary>
        public string Content { get; set; } = content;
        /// <summary>
        /// Gets or sets the metadata associated with the message.
        /// </summary>
        public Metadata Metadata { get; set; } = metadata;
    }
}