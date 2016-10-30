namespace Telegram.BotApi.Entities.MediaTypes
{
    public class Photo : MediaFile
    {
        /// <summary>
        /// Photo width
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Photo height
        /// </summary>
        public int Height { get; set; }
    }
}
