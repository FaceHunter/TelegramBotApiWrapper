using TelegramApiWrapper.Objects.Types;

namespace TelegramApiWrapper.Objects.Requests
{
    public class SendMessage
    {
        /// <summary>
        /// Unique identifier for the message recipient — User or GroupChat id
        /// </summary>
        public int chat_id;

        /// <summary>
        /// Text of the message to be sent
        /// </summary>
        public string text;

        /// <summary>
        /// [Optional] Disables link previews for links in this message
        /// </summary>
        public bool disable_web_page_preview;

        /// <summary>
        /// [Optional] If the message is a reply, ID of the original message
        /// </summary>
        public int reply_to_message_id;

        /// <summary>
        /// [Optional] Additional interface options. A JSON-serialized object for a custom reply keyboard, instructions to hide keyboard or to force a reply from the user.
        /// </summary>
        public ForceReply reply_markup;
    }
}
