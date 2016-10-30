using System.IO;

namespace Telegram.BotApi.Entities.MediaTypes
{
    public class MediaFile
    {
        /// <summary>
        /// Unique identifier for this file
        /// </summary>
        public string FileId { get; set; }

        public Stream File { get; set; }

        /// <summary>
        /// Optional. File size
        /// </summary>
        public int? FileSize { get; set; }
    }
}
