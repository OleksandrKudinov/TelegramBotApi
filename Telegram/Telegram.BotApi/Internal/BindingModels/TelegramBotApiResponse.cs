using Newtonsoft.Json;

namespace Telegram.BotApi.Internal.BindingModels
{
    public class TelegramBotApiResponse<T>
    {
        [JsonProperty(PropertyName = "ok")]
        public bool ResponseResult { get; set; }

        [JsonProperty(PropertyName = "result")]
        public T Data { get; set; }
    }
}
