using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacUnionFinancial.Intergration.WebApi.Models
{
    public class RoostifyNotification
    {
        public string id { get; set; }

        public string url { get; set; }

        public string event_type { get; set; }

        public DateTime created { get; set; }
    }
}
