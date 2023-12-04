using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBotMesages.Models
{
    public class FileMessage : Message
    {
        public string File { get; set; }
        public string Format { get; set; }

        public FileMessage(string content, string file, string format) : base(content)
        {
            File = file;
            Format = format;
        }
    }
}
