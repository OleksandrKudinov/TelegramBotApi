namespace Telegram.BotApi.Entities.MediaTypes
{
    public class Document : MediaFile
    {
        /// <summary>
        /// Optional. Document thumbnail as defined by sender
        /// </summary>
        public Photo Thumb { get; set; }

        /// <summary>
        /// Optional. Original filename as defined by sender
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Optional. MIME type of the file as defined by sender
        /// </summary>
        public string MymeType { get; set; }
    }
}
