using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Telegram.BotApi.Internal.BindingModels;

namespace Telegram.BotApi
{
    public class TelegramBot
    {
        public TelegramBot(BotConfig config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            _config = config;
        }

        public UpdateDTO[] GetUpdates()
        {
            var response = Invoke<UpdateDTO[]>(Method.getUpdates, null);
            return response.Data;
        }

        private TelegramBotApiResponse<T> Invoke<T>(Method method, object args)
        {
            var url = GetUrl(method);
            var request = HttpWebRequest.Create(url);
            request.Method = "POST";

            var serializer = JsonSerializer.Create();
            if (args != null)
            {
                var stream = request.GetRequestStream();
                serializer.Serialize(new JsonTextWriter(new StreamWriter(stream)), args);
            }

            var response = (TelegramBotApiResponse<T>)serializer.Deserialize(new JsonTextReader(new StreamReader(request.GetResponse().GetResponseStream())), typeof(TelegramBotApiResponse<T>));

            return response;
        }

        private string GetUrl(Method method)
        {
            // TODO change method.ToString to dictionary;
            string url = string.Format(_config.Url, _config.Token, method.ToString());
            return url;
        }

        private long _lastUpdateId;

        public BotConfig Config { get { return _config; } }
        private readonly BotConfig _config;
    }

    enum Method
    {
        getUpdates
    }
}
