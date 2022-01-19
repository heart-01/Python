using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.FarmTools
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Row
    {
        public string asset_id { get; set; }
        public string owner { get; set; }
        public string type { get; set; }
        public int template_id { get; set; }
        public int durability { get; set; }
        public int current_durability { get; set; }
        public int next_availability { get; set; }
    }

    public class ToolsFarm
    {
        public List<Row> rows { get; set; }
        public bool more { get; set; }
        public string next_key { get; set; }
    }


}
