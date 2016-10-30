namespace Telegram.BotApi.Entities
{
    public class VenueMessage : Message
    {
        /// <summary>
        /// Venue location
        /// </summary>
        public Location Location { get; set; }

        /// <summary>
        /// Name of the venue
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Address of the venue
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Optional. Foursquare identifier of the venue
        /// </summary>
        public string FoursquareId { get; set; }
    }
}
