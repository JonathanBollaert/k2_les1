namespace TalkApi.Model.Results
{
    public class ChatMessageResult
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public string Channel { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
