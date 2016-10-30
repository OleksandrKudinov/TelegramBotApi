namespace Telegram.BotApi.Entities
{
    public class TextMessage : Message
    {
        /// <summary>
        /// Optional. For text messages, 
        /// the actual UTF-8 text of the message, 0-4096 characters.
        /// </summary>
        public string Text { get; set; }
    }
}
