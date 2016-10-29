using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    internal class Voice
    {
        /// <summary>
        /// Unique identifier for this file
        /// </summary>
        [JsonProperty(PropertyName = "file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// Integer	Duration of the audio in seconds as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int Duration { get; set; }

        /// <summary>
        /// String	Optional. MIME type of the file as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "mime_type")]
        public string MimeType { get; set; }

        /// <summary>
        /// Integer	Optional. File size
        /// </summary>
        [JsonProperty(PropertyName = "file_size")]
        public int FileSize { get; set; }
    }
}
