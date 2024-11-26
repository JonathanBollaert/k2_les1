using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkApi.Model.Requests
{
    public class ChatMessageRequest
    {
        public required string Author { get; set; }
        public required string Message { get; set; }
        public required string Channel { get; set; }
    }
}
