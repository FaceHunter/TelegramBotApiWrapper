namespace TelegramApiWrapper.Objects.Types
{
    public class Video
    {
        /// <summary>
        /// Unique identifier for this file
        /// </summary>
        public string file_id;

        /// <summary>
        /// Video width as defined by sender
        /// </summary>
        public int width;

        /// <summary>
        /// Video height as defined by sender
        /// </summary>
        public int height;

        /// <summary>
        /// Duration of the video in seconds as defined by sender
        /// </summary>
        public int duration;

        /// <summary>
        /// [Optional] Video thumbnail
        /// </summary>
        public PhotoSize thumb;

        /// <summary>
        /// [Optional] Mime type of a file as defined by sender
        /// </summary>
        public string mime_type;

        /// <summary>
        /// [Optional] File size
        /// </summary>
        public int file_size;
    }
}
