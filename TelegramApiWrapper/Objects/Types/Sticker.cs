using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramApiWrapper.Objects.Types
{
    public class Sticker
    {
        /// <summary>
        /// Unique identifier for this file
        /// </summary>
        public string file_id;

        /// <summary>
        /// Sticker width
        /// </summary>
        public int width;

        /// <summary>
        /// Sticker height
        /// </summary>
        public int height;

        /// <summary>
        /// [Optional] Sticker thumbnail in .webp or .jpg format
        /// </summary>
        public PhotoSize thumb;

        /// <summary>
        /// [Optional] File size
        /// </summary>
        public int file_size;
    }
}
