using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.Atomic
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class AssetsToMint
    {
        public int template_id { get; set; }
        public List<object> tokens_to_back { get; set; }
    }

    public class Row
    {
        public int drop_id { get; set; }
        public string collection_name { get; set; }
        public List<AssetsToMint> assets_to_mint { get; set; }
        public string listing_price { get; set; }
        public string settlement_symbol { get; set; }
        public string price_recipient { get; set; }
        public string fee_rate { get; set; }
        public int auth_required { get; set; }
        public int account_limit { get; set; }
        public int account_limit_cooldown { get; set; }
        public int max_claimable { get; set; }
        public int current_claimed { get; set; }
        public int start_time { get; set; }
        public int end_time { get; set; }
        public string display_data { get; set; }
    }

    public class atomicdropsx
    {
        public List<Row> rows { get; set; }
        public bool more { get; set; }
        public string next_key { get; set; }
    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Rowmedian
    {
        public int id { get; set; }
        public string owner { get; set; }
        public int value { get; set; }
        public int median { get; set; }
        public DateTime timestamp { get; set; }
    }

    public class median
    {
        public List<Rowmedian> rows { get; set; }
        public bool more { get; set; }
        public string next_key { get; set; }
    }




}
