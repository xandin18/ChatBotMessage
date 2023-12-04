using ChatBotMesages.Models;

namespace ChatBotMesages.Services
{
    public abstract class ChannelSend
    {
        public abstract void EnviarMensagem(Message mensagem);
    }
}
