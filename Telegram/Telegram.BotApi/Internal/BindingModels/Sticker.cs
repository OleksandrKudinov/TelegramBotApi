using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    internal class Sticker
    {
        /// <summary>
        /// Unique identifier for this file
        /// </summary>
        [JsonProperty(PropertyName = "file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// Sticker width
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Sticker height
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int Height { get; set; }


        /// <summary>
        /// Optional. Sticker thumbnail in .webp or .jpg format
        /// </summary>
        [JsonProperty(PropertyName = "thumb")]
        public PhotoSize Thumb { get; set; }


        /// <summary>
        /// Optional. Emoji associated with the sticker
        /// </summary>
        [JsonProperty(PropertyName = "emoji")]
        public string Emoji { get; set; }


        /// <summary>
        /// Optional. File size
        /// </summary>
        [JsonProperty(PropertyName = "file_size")]
        public int? FileSize { get; set; }
    }
}
