using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.FarmAccount
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Row
    {
        public string account { get; set; }
        public int energy { get; set; }
        public int max_energy { get; set; }
        public string last_mine_tx { get; set; }
        public List<string> balances { get; set; }
    }

    public class AccountFarm
    {
        public List<Row> rows { get; set; }
        public bool more { get; set; }
        public string next_key { get; set; }
    }


}
