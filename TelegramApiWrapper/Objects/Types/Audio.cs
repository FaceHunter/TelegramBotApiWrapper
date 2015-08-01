namespace TelegramApiWrapper.Objects.Types
{
    public class Audio
    {
        /// <summary>
        /// Unique identifier for this file
        /// </summary>
        public string file_id;

        /// <summary>
        /// Duration of the audio in seconds as defined by sender
        /// </summary>
        public int duration;

        /// <summary>
        /// [Optional] MIME type of the file as defined by sender
        /// </summary>
        public string mime_type;

        /// <summary>
        /// [Optional] File size
        /// </summary>
        public int file_size;
    }
}
