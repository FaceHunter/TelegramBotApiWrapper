namespace TelegramApiWrapper.Objects.Types
{
    public class Contact
    {
        /// <summary>
        /// Contact's phone number
        /// </summary>
        public string phone_number;

        /// <summary>
        /// Contact's first name
        /// </summary>
        public string first_name;

        /// <summary>
        /// [Optional] Contact's last name
        /// </summary>
        public string last_name;

        /// <summary>
        /// [Optional] Contact's user identifier in Telegram
        /// </summary>
        public int user_id;
    }
}
