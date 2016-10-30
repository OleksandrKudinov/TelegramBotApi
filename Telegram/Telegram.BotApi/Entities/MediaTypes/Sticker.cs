using System;

namespace Telegram.BotApi.Entities.MediaTypes
{
    public class Sticker : MediaFile
    {
        /// <summary>
        /// Sticker width
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Sticker height
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Optional. Sticker thumbnail in .webp or .jpg format
        /// </summary>
        public Photo Thumb { get; set; }


        /// <summary>
        /// Optional. Emoji associated with the sticker
        /// </summary>
        public string Emoji { get; set; }
    }
}
