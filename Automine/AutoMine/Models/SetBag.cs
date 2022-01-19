using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.SetBag
{
    public class Collection
    {
        public string collection_name { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public string author { get; set; }
        public bool allow_notify { get; set; }
        public List<string> authorized_accounts { get; set; }
        public List<string> notify_accounts { get; set; }
        public double market_fee { get; set; }
        public string created_at_block { get; set; }
        public string created_at_time { get; set; }
    }

    public class Format
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Schema
    {
        public string schema_name { get; set; }
        public List<Format> format { get; set; }
        public string created_at_block { get; set; }
        public string created_at_time { get; set; }
    }

    public class ImmutableData
    {
        public string img { get; set; }
        public int ease { get; set; }
        public int luck { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int delay { get; set; }
        public string shine { get; set; }
        public int cardid { get; set; }
        public string rarity { get; set; }
        public string backimg { get; set; }
        public int difficulty { get; set; }
    }

    public class Template
    {
        public string template_id { get; set; }
        public string max_supply { get; set; }
        public bool is_transferable { get; set; }
        public bool is_burnable { get; set; }
        public string issued_supply { get; set; }
        public ImmutableData immutable_data { get; set; }
        public string created_at_time { get; set; }
        public string created_at_block { get; set; }
    }

    public class MutableData
    {
    }

    public class Data
    {
        public string img { get; set; }
        public int ease { get; set; }
        public int luck { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int delay { get; set; }
        public string shine { get; set; }
        public int cardid { get; set; }
        public string rarity { get; set; }
        public string backimg { get; set; }
        public int difficulty { get; set; }
        public string contract { get; set; }
        public string asset_id { get; set; }
        public string owner { get; set; }
        public bool is_transferable { get; set; }
        public bool is_burnable { get; set; }
        public Collection collection { get; set; }
        public Schema schema { get; set; }
        public Template template { get; set; }
        public MutableData mutable_data { get; set; }
        public ImmutableData immutable_data { get; set; }
        public string template_mint { get; set; }
        public List<object> backed_tokens { get; set; }
        public object burned_by_account { get; set; }
        public object burned_at_block { get; set; }
        public object burned_at_time { get; set; }
        public string updated_at_block { get; set; }
        public string updated_at_time { get; set; }
        public string transferred_at_block { get; set; }
        public string transferred_at_time { get; set; }
        public string minted_at_block { get; set; }
        public string minted_at_time { get; set; }
        public Data data { get; set; }
    }

    public class SetBagModel
    {
        public bool success { get; set; }
        public List<Data> data { get; set; }
        public long query_time { get; set; }
    }


}
