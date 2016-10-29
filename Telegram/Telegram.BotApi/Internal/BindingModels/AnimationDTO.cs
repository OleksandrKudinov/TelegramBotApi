using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    public class AnimationDTO
    {
        /// <summary>
        /// Unique file identifier
        /// </summary>
        [JsonProperty(PropertyName = "file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// Optional. Animation thumbnail as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "thumb")]
        public PhotoSizeDTO Thumb { get; set; }

        /// <summary>
        /// Optional. Original animation filename as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// Optional. MIME type of the file as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "mime_type")]
        public string MimeType { get; set; }

        /// <summary>
        ///  Optional. File size
        /// </summary>
        [JsonProperty(PropertyName = "file_size")]
        public int? FileSize { get; set; }
    }
}
