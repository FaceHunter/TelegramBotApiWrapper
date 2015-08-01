using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramApiWrapper.Objects.Types
{
    public class Document
    {
        /// <summary>
        /// Unique file identifier
        /// </summary>
        public string file_id;

        /// <summary>
        /// [Optional] Document thumbnail as defined by sender
        /// </summary>
        public PhotoSize thumb;

        /// <summary>
        /// [Optional] Original filename as defined by sender
        /// </summary>
        public string file_name;

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
