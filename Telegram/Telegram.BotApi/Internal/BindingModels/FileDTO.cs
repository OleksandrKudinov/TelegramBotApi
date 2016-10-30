using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    /// <summary>
    /// This object represents a file ready to be downloaded. 
    /// The file can be downloaded via the link https://api.telegram.org/file/bot{token}/{file_path};. 
    /// It is guaranteed that the link will be valid for at least 1 hour. When the link expires, 
    /// a new one can be requested by calling getFile.
    ///
    /// Maximum file size to download is 20 MB
    /// </summary>
    public class FileDTO
    {
        /// <summary>
        /// Unique identifier for this file
        /// </summary>
        [JsonProperty(PropertyName = "file_id")]
        public string  FileId { get; set; }

        /// <summary>
        /// Optional. File size, if known
        /// </summary>
        [JsonProperty(PropertyName = "file_size")]
        public int? FileSize { get; set; }

        /// <summary>
        /// Optional. File path. Use https://api.telegram.org/file/bot{token}/{file_path} to get the file.
        /// </summary>
        [JsonProperty(PropertyName = "file_path")]
        public string FilePath { get; set; }
    }
}
