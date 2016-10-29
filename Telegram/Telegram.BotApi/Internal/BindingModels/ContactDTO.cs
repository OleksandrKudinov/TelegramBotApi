using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    public class ContactDTO
    {
        /// <summary>
        /// Contact's phone number
        /// </summary>
        [JsonProperty(PropertyName = "phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Contact's first name
        /// </summary>
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Optional. Contact's last name
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Optional. Contact's user identifier in Telegram
        /// </summary>
        [JsonProperty(PropertyName = "user_id")]
        public long? UserId { get; set; }
    }
}
