using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.Models.Crops
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Row
    {
        public string asset_id { get; set; }
        public string owner { get; set; }
        public string name { get; set; }
        public string building_id { get; set; }
        public int template_id { get; set; }
        public int times_claimed { get; set; }
        public int last_claimed { get; set; }
        public int next_availability { get; set; }
    }

    public class FarmCrops
    {
        public List<Row> rows { get; set; }
        public bool more { get; set; }
        public string next_key { get; set; }
    }


}
