namespace Telegram.BotApi.Entities.MediaTypes
{
    public class Video : MediaFile
    {
        /// <summary>
        /// Video width as defined by sender
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Video height as defined by sender
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Duration of the video in seconds as defined by sender
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// Optional. Video thumbnail
        /// </summary>
        public Photo Thumb { get; set; }

        /// <summary>
        /// Optional. Mime type of a file as defined by sender
        /// </summary>
        public string MimeType { get; set; }
    }
}
