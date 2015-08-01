using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramApiWrapper.Objects.Types
{
    public class GroupChat : User
    {
        /// <summary>
        /// Unique identifier for this user, bot or group chat
        /// </summary>
        public int id;

        /// <summary>
        /// Group name
        /// </summary>
        public string title;
    }
}
