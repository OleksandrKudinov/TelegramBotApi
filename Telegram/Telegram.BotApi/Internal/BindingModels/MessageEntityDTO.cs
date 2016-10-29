using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    /// <summary>
    /// This object represents one special entity in a text message. 
    /// For example, hashtags, usernames, URLs, etc.
    /// </summary>
    public class MessageEntityDTO
    {
        // TODO : string to enum
        /// <summary>
        /// Type of the entity. Can be mention (@username), hashtag, bot_command, url, email, bold (bold text), italic (italic text), 
        /// code (monowidth string), pre (monowidth block), text_link (for clickable text URLs), text_mention (for users without usernames)
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Offset in UTF-16 code units to the start of the entity
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Length of the entity in UTF-16 code units
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }

        /// <summary>
        /// Optional. For “text_link” only, url that will be opened after user taps on the text
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Optional. For “text_mention” only, the mentioned user
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public User User { get; set; }
    }
}
