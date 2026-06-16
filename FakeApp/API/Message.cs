namespace FakeApp.API
{
    public class Message
    {
        public Message(string content, Metadata metadata)
        {
            this.content = content;
            this.metadata = metadata;
        }
        public string content { get; set; }
        public Metadata metadata { get; set; }
    }
}