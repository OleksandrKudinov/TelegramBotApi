using System;
using System.IO;
using System.Net;
using System.Text;
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
            TelegramBotApiResponse<UpdateDTO[]> response = Invoke<UpdateDTO[]>("getUpdates", null);
            return response.Data;
        }

        private TelegramBotApiResponse<T> Invoke<T>(string method, object args)
        {
            var url = GenerateUriForMethod(method);

            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";

            if (args != null)
            {
                string requestJson = JsonConvert.SerializeObject(args);
                var bytes = Encoding.UTF8.GetBytes(requestJson);
                request.ContentLength = bytes.Length;

                using (var requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
            }

            WebResponse response = request.GetResponse();

            string rawResponse = null;

            using (var stream = new StreamReader(response.GetResponseStream()))
            {
                rawResponse = stream.ReadToEnd();
            }

            TelegramBotApiResponse<T> apiResponse = JsonConvert.DeserializeObject<TelegramBotApiResponse<T>>(rawResponse);
            return apiResponse;
        }

        private string GenerateUriForMethod(string method)
        {
            // TODO change method.ToString to dictionary;
            string url = string.Format(_config.Url, _config.Token, method);
            return url;
        }

        private long _lastUpdateId;

        public BotConfig Config { get { return _config; } }
        private readonly BotConfig _config;
    }
}
