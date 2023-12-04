using System;
using System.Collections.Generic;
using System.Linq;
namespace ChatBotMesages.Models
{
    public abstract class Message
    {
        public string Content { get; set; }
        public DateTime SendDate { get; set; } 

        public Message(string content)
        {
            Content = content;
            SendDate = DateTime.Now;
        }
    }
}
