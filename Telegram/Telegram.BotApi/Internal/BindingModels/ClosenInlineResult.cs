using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    public class ClosenInlineResult
    {
        /// <summary>
        /// The unique identifier for the result that was chosen
        /// </summary>
        [JsonProperty(PropertyName = "result_id")]
        public string ResultId { get; set; }

        /// <summary>
        /// The user that chose the result
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public User From { get; set; }

        /// <summary>
        /// Optional. Sender location, only for bots that require user location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// Optional. Identifier of the sent inline message. Available only if there is an inline keyboard attached to the message. Will be also received in callback queries and can be used to edit the message.
        /// </summary>
        [JsonProperty(PropertyName = "inline_message_id")]
        public string InlineMessageId { get; set; }

        /// <summary>
        /// The query that was used to obtain the result
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }
    }
}