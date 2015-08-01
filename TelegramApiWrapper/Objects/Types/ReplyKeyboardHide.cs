using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramApiWrapper.Objects.Types
{
    public class ReplyKeyboardHide : ReplyKeyboardMarkup
    {
        /// <summary>
        /// Requests clients to hide the custom keyboard
        /// </summary>
        public bool hide_keyboard;
    }
}
