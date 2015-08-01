using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegramApiWrapper.Objects.Requests
{
    public class GetUpdates
    {
        /// <summary>
        /// [Optional] Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned. An update is considered confirmed as soon as getUpdates is called with an offset higher than its update_id.
        /// </summary>
        public int offset;

        /// <summary>
        /// [Optional] Limits the number of updates to be retrieved. Values between 1—100 are accepted. Defaults to 100
        /// </summary>
        public int limit;

        /// <summary>
        /// [Optional] Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling
        /// </summary>
        public int timeout;
    }
}
