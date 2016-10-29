using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    public class Venue
    {
        /// <summary>
        /// Venue location
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public Location Location { get; set; }

        /// <summary>
        /// Name of the venue
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Address of the venue
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// Optional. Foursquare identifier of the venue
        /// </summary>
        [JsonProperty(PropertyName = "foursquare_id")]
        public string FoursquareId { get; set; }
    }
}
