namespace TalkApi.Model.Results
{
    public class ChatChannelResult
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
