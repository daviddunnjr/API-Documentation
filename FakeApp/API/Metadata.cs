using System;
namespace FakeApp.API
{
    /// <summary>
    /// Represents metadata associated with a message, including the author's name and the creation time.
    /// </summary>
    public class Metadata
    {
        public Metadata()
        {
            this.AuthorName = "Unknown Author";
            this.CreationTime = DateTime.Now;
        }
        /// <summary>
        /// Initializes a new instance of the Metadata class with the specified author's name and the current creation.
        /// </summary>
        /// <param name="authorName"></param>
        public Metadata(string authorName)
        {
            this.AuthorName = authorName;
            this.CreationTime = DateTime.Now;
        }
        /// <summary>
        /// Gets or sets the name of the author of the message.
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets the time when the message was created.
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}