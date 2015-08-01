using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using TelegramApiWrapper.Objects.Requests;
using TelegramApiWrapper.Objects.Responses;
using TelegramApiWrapper.Objects.Types;

namespace TelegramApiWrapper
{
    public class TelegramApi
    {
        private static Response<T1> ApiCall<T1>(string Token, string Method)
        {
            using (WebClient webClient = new WebClient())
            {
                Response<T1> resp = JsonConvert.DeserializeObject<Response<T1>>(webClient.DownloadString(string.Format("https://api.telegram.org/bot{0}/{1}", Token, Method)));
                if (resp.ok)
                    return resp;
                else
                    throw new ApiCallException(resp.description);
            }
        }



        private static Response<T1> PostApiCall<T1,T2>(string Token, string Method, T2 options)
        {
            using (WebClient webClient = new WebClient())
            {
                NameValueCollection formFields = new NameValueCollection();

                options.GetType().GetProperties()
                 .ToList()
                 .ForEach(pi => formFields.Add(pi.Name, (pi.GetValue(options, null) ?? "").ToString()));

                Response<T1> resp = JsonConvert.DeserializeObject<Response<T1>>(Encoding.Default.GetString(webClient.UploadValues(string.Format("https://api.telegram.org/bot{0}/{1}", Token, Method), formFields)));
                if (resp.ok)
                    return resp;
                else
                    throw new ApiCallException(resp.description);
            }
        }

        private static void PostApiCall<T1>(string Token, string Method, T1 options)
        {
            using (WebClient webClient = new WebClient())
            {
                NameValueCollection formFields = new NameValueCollection();

                options.GetType().GetProperties()
                 .ToList()
                 .ForEach(pi => formFields.Add(pi.Name, (pi.GetValue(options, null) ?? "").ToString()));

                Response<T1> resp = JsonConvert.DeserializeObject<Response<T1>>(Encoding.Default.GetString(webClient.UploadValues(string.Format("https://api.telegram.org/bot{0}/{1}", Token, Method), formFields)));
                if (!resp.ok)
                    throw new ApiCallException(resp.description);
            }
        }

        /// <summary>
        /// Use this method to receive incoming updates using long polling. An Array of Update objects is returned.
        /// </summary>
        /// <param name="Token">Your bot's token</param>
        /// <param name="Options">Options to post with the request</param>
        /// <returns>An array of Update Objects</returns>
        public static Update[] getUpdates(string Token, GetUpdates Options)
        {
            return PostApiCall<Update[], GetUpdates>(Token, "getUpdates", Options).result;    
        }

        /// <summary>
        /// Use this method to receive incoming updates using long polling. An Array of Update objects is returned.
        /// </summary>
        /// <param name="Token">Your bot's token</param>
        /// <returns>An array of Update Objects</returns>
        public static Update[] getUpdates(string Token)
        {
            return ApiCall<Update[]>(Token, "getUpdates").result;
        }

        /// <summary>
        /// Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts.
        /// </summary>
        /// <param name="Token">Your bot's token</param>
        /// <param name="Options">Options to post with the request</param>
        public static void setWebHook(string Token, SetWebHook Options)
        {
            PostApiCall(Token, "setWebHook", Options);
        }

        /// <summary>
        /// A simple method for testing your bot's auth token. Requires no parameters. 
        /// </summary>
        /// <param name="Token">Your bot's token</param>
        /// <returns>Returns basic information about the bot in form of a User object.</returns>
        public static User getMe(string Token)
        {
            return ApiCall<User>(Token, "getMe").result;
        }

        /// <summary>
        /// Use this method to send text messages.
        /// </summary>
        /// <param name="Token">Your bot's token</param>
        /// <param name="Options">Options to post with the request</param>
        /// <returns>On success, the sent Message is returned.</returns>
        public static Message sendMessage(string Token, SendMessage Options)
        {
            return PostApiCall<Message, SendMessage>(Token, "sendMessage", Options).result;
        }
    }
}
