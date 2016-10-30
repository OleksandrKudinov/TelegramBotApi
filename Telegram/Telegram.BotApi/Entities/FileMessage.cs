using Telegram.BotApi.Entities.MediaTypes;

namespace Telegram.BotApi.Entities
{
    public class FileMessage : Message
    {
        public MediaFile File { get; set; }
    }
}
