﻿using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    public class Game
    {
        /// <summary>
        /// Title of the game
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Description of the game
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Photo that will be displayed in the game message in chats.
        /// </summary>
        [JsonProperty(PropertyName = "photo")]
        public PhotoSize[] Photo { get; set; }

        /// <summary>
        /// Optional. Brief description of the game or high scores included in the game message. 
        /// Can be automatically edited to include current high scores for the game when the bot
        /// calls setGameScore, or manually edited using editMessageText. 0-4096 characters.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Optional. Special entities that appear in text, such as usernames, URLs, bot commands, etc.
        /// </summary>
        [JsonProperty(PropertyName = "text_entities")]
        public MessageEntity[] TextEntities { get; set; }

        /// <summary>
        /// Optional. Animation that will be displayed in the game message in chats. Upload via BotFather
        /// </summary>
        [JsonProperty(PropertyName = "animation")]
        public Animation Animation { get; set; }
    }
}
