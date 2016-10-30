namespace Telegram.BotApi.Entities.MediaTypes
{
    public class Audio : MediaFile
    {
        /// <summary>
        /// Duration of the audio in seconds as defined by sender
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Optional. Performer of the audio as defined by sender or by audio tags
        /// </summary>
        public string Performer { get; set; }

        /// <summary>
        /// Optional. Title of the audio as defined by sender or by audio tags
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Optional. MIME type of the file as defined by sender
        /// </summary>
        public string MimeType { get; set; }
    }
}
