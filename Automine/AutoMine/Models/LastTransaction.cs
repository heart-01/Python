using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.GetTrans
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Receipt
    {
        public string status { get; set; }
        public int cpu_usage_us { get; set; }
        public int net_usage_words { get; set; }
        public List<object> trx { get; set; }
        public string receiver { get; set; }
        public string global_sequence { get; set; }
        public List<object> auth_sequence { get; set; }
        public string act_digest { get; set; }
        public int recv_sequence { get; set; }
        public int code_sequence { get; set; }
        public int abi_sequence { get; set; }
    }

    public class Trx2
    {
        public string expiration { get; set; }
        public int ref_block_num { get; set; }
        public int ref_block_prefix { get; set; }
        public int max_net_usage_words { get; set; }
        public int max_cpu_usage_ms { get; set; }
        public int delay_sec { get; set; }
        public List<object> context_free_actions { get; set; }
        public List<object> actions { get; set; }
        public List<object> transaction_extensions { get; set; }
        public List<object> signatures { get; set; }
        public List<object> context_free_data { get; set; }
    }

    public class Authorization
    {
        public string actor { get; set; }
        public string permission { get; set; }
    }

    public class Params
    {
        public int invalid { get; set; }
        public string error { get; set; }
        public int delay { get; set; }
        public int difficulty { get; set; }
        public int ease { get; set; }
        public int luck { get; set; }
        public int commission { get; set; }
    }

    public class Data
    {
        public string miner { get; set; }
        public string nonce { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public double? amount { get; set; }
        public string symbol { get; set; }
        public string memo { get; set; }
        public string quantity { get; set; }
        public Params @params { get; set; }
        public string bounty { get; set; }
        public string land_id { get; set; }
        public string planet_name { get; set; }
        public string landowner { get; set; }
        public List<string> bag_items { get; set; }
        public int? offset { get; set; }
    }

    public class Act
    {
        public string account { get; set; }
        public string name { get; set; }
        public List<Authorization> authorization { get; set; }
        public Data data { get; set; }
        public string hex_data { get; set; }
    }

    public class InlineTrace
    {
        public Receipt receipt { get; set; }
        public List<object> account_ram_deltas { get; set; }
        public Act act { get; set; }
        public int block_num { get; set; }
        public DateTime block_time { get; set; }
        public string console { get; set; }
        public bool context_free { get; set; }
        public int elapsed { get; set; }
        public object except { get; set; }
        public List<object> inline_traces { get; set; }
        public string producer_block_id { get; set; }
        public string trx_id { get; set; }
    }

    public class Trace
    {
        public Receipt receipt { get; set; }
        public Act act { get; set; }
        public List<object> account_ram_deltas { get; set; }
        public bool context_free { get; set; }
        public int block_num { get; set; }
        public DateTime block_time { get; set; }
        public string console { get; set; }
        public int elapsed { get; set; }
        public object except { get; set; }
        public List<InlineTrace> inline_traces { get; set; }
        public string producer_block_id { get; set; }
        public string trx_id { get; set; }
    }

    public class Trx
    {
        public Receipt receipt { get; set; }
        public Trx2 trx { get; set; }
    }

    public class Get_transaction
    {
        public string id { get; set; }
        public Trx trx { get; set; }
        public int block_num { get; set; }
        public DateTime block_time { get; set; }
        public int last_irreversible_block { get; set; }
        public List<Trace> traces { get; set; }
        public double query_time_ms { get; set; }
    }


}
