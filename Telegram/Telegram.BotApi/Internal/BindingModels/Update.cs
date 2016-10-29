﻿using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    public class Update
    {
        /// <summary>
        /// The update‘s unique identifier. Update identifiers start from a certain positive number and increase sequentially. This ID becomes especially handy if you’re using Webhooks, since it allows you to ignore repeated updates or to restore the correct update sequence, should they get out of order.
        /// </summary>
        [JsonProperty(PropertyName = "update_id")]
        public int UpdateId { get; set; }

        /// <summary>
        /// Optional. New incoming message of any kind — text, photo, sticker, etc.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public Message Message { get; set; }

        /// <summary>
        /// Optional. New version of a message that is known to the bot and was edited
        /// </summary>
        [JsonProperty(PropertyName = "edited_message")]
        public Message EditedMessage { get; set; }

        /// <summary>
        /// Optional. New incoming inline query
        /// </summary>
        [JsonProperty(PropertyName = "inline_query")]
        public InlineQuery InlineQuery { get; set; }

        /// <summary>
        /// Optional. The result of an inline query that was chosen by a user and sent to their chat partner.
        /// </summary>
        [JsonProperty(PropertyName = "chosen_inline_result")]
        public ClosenInlineResult ClosenInlineResult { get; set; }

        /// <summary>
        /// callback_query
        /// </summary>
        [JsonProperty(PropertyName = "callback_query")]
        public CallbackQuery CallbackQuery { get; set; }
    }
}
