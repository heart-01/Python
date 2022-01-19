using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.TradeModel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Row
    {
        public int id { get; set; }
        public string account { get; set; }
        public string bid { get; set; }
        public string ask { get; set; }
        public string unit_price { get; set; }
        public int timestamp { get; set; }
    }

    public class TraderModel
    {
        public List<Row> rows { get; set; }
        public bool more { get; set; }
        public string next_key { get; set; }
    }


}
