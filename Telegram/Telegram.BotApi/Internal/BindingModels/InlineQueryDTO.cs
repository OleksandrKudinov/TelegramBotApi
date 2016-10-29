using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    public class InlineQueryDTO
    {
        /// <summary>
        /// Unique identifier for this query
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Sender
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public UserDTO From { get; set; }

        /// <summary>
        /// Optional. Sender location, only for bots that request user location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public LocationDTO Location { get; set; }

        /// <summary>
        /// Text of the query (up to 512 characters)
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// Offset of the results to be returned, can be controlled by the bot
        /// </summary>
        [JsonProperty(PropertyName = "offset")]
        public string Offset { get; set; }
    }
}