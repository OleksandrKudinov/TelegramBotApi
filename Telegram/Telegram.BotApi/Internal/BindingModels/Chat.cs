using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    public class Chat
    {
        /// <summary>
        /// Unique identifier for this chat. 
        /// This number may be greater than 32 bits and some programming
        /// languages may have difficulty/silent defects in interpreting it.
        /// But it smaller than 52 bits, so a signed 64 bit integer or 
        /// double-precision float type are safe for storing this identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        // TODO : string to enum converter
        /// <summary>
        /// Type of chat, can be either “private”, “group”, “supergroup” or “channel”
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Optional. Title, for supergroups, channels and group chats
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Optional. Username, for private chats, supergroups and channels if available
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Optional. First name of the other party in a private chat
        /// </summary>
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Optional. Last name of the other party in a private chat
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Optional. True if a group has ‘All Members Are Admins’ enabled.
        /// </summary>
        [JsonProperty(PropertyName = "all_members_are_administrators")]
        public bool? AllMembersAreAdministrators { get; set; }
    }
}
