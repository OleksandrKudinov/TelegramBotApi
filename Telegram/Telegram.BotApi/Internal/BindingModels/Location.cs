﻿using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    internal class Location
    {
        /// <summary>
        /// Longitude as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Latitude as defined by sender
        /// </summary>
        [JsonProperty(PropertyName = "latitude")]
        public double Latitude { get; set; }
    }
}
