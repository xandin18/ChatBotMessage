using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotMesages.Models
{
    public class VideoMessage : Message
    {
        public string File { get; set; }
        public string Format { get; set; }
        public TimeSpan Duration { get; set; }

        public VideoMessage(string content, string file, string format, TimeSpan duration) : base(content)
        {
            File = file;
            Format = format;
            Duration = duration;
        }
    }
}
