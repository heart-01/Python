using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.Models
{

    public static class Globals
    {
        public static string PATH_FILE = ""; // Modifiable
        public static string TOKEN_LINE = ""; // Modifiable
        public static string TOKEN_ID = ""; // Modifiable
        public static string ACCOUNT_ID = ""; // Modifiable
        public static string ACCOUNT_TRANSFER = ""; // Modifiable
        public static string ACCOUNT_AMT = ""; // Modifiable
        public static string ACCOUNT_MEMO = ""; // Modifiable
        public static string ACCOUNT_USER = ""; // Modifiable
        public static string LAND_ID = ""; // Modifiable
        public static int CountId = 0; // Modifiable
        public static DateTime Expire = DateTime.Now; // Modifiable
        public static bool Login = false;
        public static bool CropsClaim = false;
    }

    public static class LoginWax
    {
        public static string EMAIL = ""; // Modifiable
        public static string PASSWORD = ""; // Modifiable
        public static string FAC_PASSWORD = ""; // Modifiable
        public static string ACCOUNT = ""; // Modifiable
        public static string TOKEN = ""; // Modifiable
    }

    public static class GetFile
    {
        public static List<GetFileBot> FileBot { get; set; }
    }


    public class GetFileBot
    {
        public string FileName = ""; // Modifiable
        public string PathFile = ""; // Modifiable
    }

    public class LoginView
    {
        public bool verified { get; set; }
        public string accountName { get; set; }
        public List<string> publicKeys { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class NetLimit
    {
        public Int64 used { get; set; }
        public Int64 available { get; set; }
        public Int64 max { get; set; }
    }

    public class CpuLimit
    {
        public Int64 used { get; set; }
        public Int64 available { get; set; }
        public Int64 max { get; set; }
    }

    public class Key
    {
        public string key { get; set; }
        public Int64 weight { get; set; }
    }

    public class Permission2
    {
        public string actor { get; set; }
        public string permission { get; set; }
    }

    public class Account
    {
        public Permission permission { get; set; }
        public Int64 weight { get; set; }
    }

    public class RequiredAuth
    {
        public Int64 threshold { get; set; }
        public List<Key> keys { get; set; }
        public List<Account> accounts { get; set; }
        public List<object> waits { get; set; }
    }

    public class Permission
    {
        public string perm_name { get; set; }
        public string parent { get; set; }
        public RequiredAuth required_auth { get; set; }
    }

    public class TotalResources
    {
        public string owner { get; set; }
        public string net_weight { get; set; }
        public string cpu_weight { get; set; }
        public Int64 ram_bytes { get; set; }
    }

    public class SubjectiveCpuBillLimit
    {
        public Int64 used { get; set; }
        public Int64 available { get; set; }
        public Int64 max { get; set; }
    }

    public class accountViewModles
    {
        public string account_name { get; set; }
        public Int64 head_block_num { get; set; }
        public DateTime head_block_time { get; set; }
        public bool privileged { get; set; }
        public DateTime last_code_update { get; set; }
        public DateTime created { get; set; }
        public string core_liquid_balance { get; set; }
        public Int64 ram_quota { get; set; }
        public Int64 net_weight { get; set; }
        public Int64 cpu_weight { get; set; }
        public NetLimit net_limit { get; set; }
        public CpuLimit cpu_limit { get; set; }
        public Int64 ram_usage { get; set; }
        public List<Permission> permissions { get; set; }
        public TotalResources total_resources { get; set; }
        public object self_delegated_bandwidth { get; set; }
        public object refund_request { get; set; }
        public object voter_info { get; set; }
        public object rex_info { get; set; }
        public SubjectiveCpuBillLimit subjective_cpu_bill_limit { get; set; }
    }

    public class MineData
    {
        public string account { get; set; }
        public string rand_str { get; set; }
        public string hex_digest { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Receipt
    {
        public string status { get; set; }
        public Int64 cpu_usage_us { get; set; }
        public Int64 net_usage_words { get; set; }
        public string receiver { get; set; }
        public string act_digest { get; set; }
        public string global_sequence { get; set; }
        public long recv_sequence { get; set; }
        public List<List<object>> auth_sequence { get; set; }
        public Int64 code_sequence { get; set; }
        public Int64 abi_sequence { get; set; }
    }


    public class Data
    {
        public string miner { get; set; }
        public string nonce { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string quantity { get; set; }
        public string memo { get; set; }
        public Params @params { get; set; }
        public string bounty { get; set; }
        public string land_id { get; set; }
        public string planet_name { get; set; }
        public string landowner { get; set; }
        public List<string> bag_items { get; set; }
        public Int64? offset { get; set; }
    }

    public class Act
    {
        public string account { get; set; }
        public string name { get; set; }
        public List<Authorization> authorization { get; set; }
        public Data data { get; set; }
        public string hex_data { get; set; }
    }

    public class AccountRamDelta
    {
        public string account { get; set; }
        public Int64 delta { get; set; }
    }

    public class Params
    {
        public Int64 invalid { get; set; }
        public string error { get; set; }
        public Int64 delay { get; set; }
        public Int64 difficulty { get; set; }
        public Int64 ease { get; set; }
        public Int64 luck { get; set; }
        public Int64 commission { get; set; }
    }

    public class InlineTrace2
    {
        public Int64 action_ordinal { get; set; }
        public Int64 creator_action_ordinal { get; set; }
        public Int64 closest_unnotified_ancestor_action_ordinal { get; set; }
        public Receipt receipt { get; set; }
        public string receiver { get; set; }
        public Act act { get; set; }
        public bool context_free { get; set; }
        public Int64 elapsed { get; set; }
        public string console { get; set; }
        public string trx_id { get; set; }
        public Int64 block_num { get; set; }
        public DateTime block_time { get; set; }
        public object producer_block_id { get; set; }
        public List<object> account_ram_deltas { get; set; }
        public object except { get; set; }
        public object error_code { get; set; }
        public List<object> inline_traces { get; set; }
    }

    public class ActionTrace
    {
        public Int64 action_ordinal { get; set; }
        public Int64 creator_action_ordinal { get; set; }
        public Int64 closest_unnotified_ancestor_action_ordinal { get; set; }
        public Receipt receipt { get; set; }
        public string receiver { get; set; }
        public Act act { get; set; }
        public bool context_free { get; set; }
        public Int64 elapsed { get; set; }
        public string console { get; set; }
        public string trx_id { get; set; }
        public Int64 block_num { get; set; }
        public DateTime block_time { get; set; }
        public object producer_block_id { get; set; }
        public List<AccountRamDelta> account_ram_deltas { get; set; }
        public object except { get; set; }
        public object error_code { get; set; }
        public List<InlineTrace2> inline_traces { get; set; }
    }

    public class Processed
    {
        public string id { get; set; }
        public Int64 block_num { get; set; }
        public DateTime block_time { get; set; }
        public object producer_block_id { get; set; }
        public Receipt receipt { get; set; }
        public Int64 elapsed { get; set; }
        public Int64 net_usage { get; set; }
        public bool scheduled { get; set; }
        public List<ActionTrace> action_traces { get; set; }
        public object account_ram_delta { get; set; }
        public object except { get; set; }
        public object error_code { get; set; }
    }

    public class ResultSucessMine
    {
        public string transaction_id { get; set; }
        public Processed processed { get; set; }
    }

    public class ChainInfoModel
    {
        [JsonProperty("server_version")]
        public string ServerVersion { get; set; }

        [JsonProperty("server_version_string")]
        public string ServerVersionString { get; set; }

        [JsonProperty("chain_id")]
        public string ChainId { get; set; }

        [JsonProperty("head_block_num")]
        public uint HeadBlockNum { get; set; }

        [JsonProperty("last_irreversible_block_num")]
        public uint LastIrreversibleBlockNum { get; set; }

        [JsonProperty("last_irreversible_block_id")]
        public string LastIrreversibleBlockId { get; set; }

        [JsonProperty("head_block_id")]
        public string HeadBlockId { get; set; }

        [JsonProperty("head_block_time")]
        [JsonConverter(typeof(EosDateTimeConverter))]
        public DateTime HeadBlockTime { get; set; }

        [JsonProperty("head_block_producer")]
        public string HeadBlockProducer { get; set; }

        [JsonProperty("virtual_block_cpu_limit")]
        public ulong VirtualBlockCpuLimit { get; set; }

        [JsonProperty("virtual_block_net_limit")]
        public ulong VirtualBlockNetLimit { get; set; }

        [JsonProperty("block_cpu_limit")]
        public ulong BlockCpuLimit { get; set; }

        [JsonProperty("block_net_limit")]
        public ulong BlockNetLimit { get; set; }

    }



    public class Transaction
    {
        public string status { get; set; }
        public Int64 cpu_usage_us { get; set; }
        public Int64 net_usage_words { get; set; }
        public object trx { get; set; }
    }

    public class blockInfoModels
    {
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(EosDateTimeConverter))]
        public DateTime TimeStamp { get; set; }

        [JsonProperty("producer")]
        public string Producer { get; set; }

        [JsonProperty("confirmed")]
        public int Confirmed { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("transaction_mroot")]
        public string TransactionMRoot { get; set; }

        [JsonProperty("action_mroot")]
        public string ActionMRoot { get; set; }

        [JsonProperty("schedule_version")]
        public int ScheduleVersion { get; set; }

        [JsonProperty("producer_signature")]
        public string ProducerSignature { get; set; }

        [JsonProperty("transactions")]
        public IEnumerable<Transaction> Transactions { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("block_num")]
        public uint BlockNum { get; set; }

        [JsonProperty("ref_block_prefix")]
        public uint RefBlockPrefix { get; set; }
    }

    public class TransactionAction
    {
        [JsonProperty("expiration")]
        [JsonConverter(typeof(EosDateTimeConverter))]
        public DateTime Expiration { get; set; }

        [JsonProperty("ref_block_num")]
        public uint RefBlockNum { get; set; }

        [JsonProperty("ref_block_prefix")]
        public ulong RefBlockPrefix { get; set; }

        [JsonProperty("max_net_usage_words")]
        public ulong MaxNetUsageWords { get; set; }

        [JsonProperty("max_cpu_usage_ms")]
        public ulong MaxCpuUsageMs { get; set; }

        [JsonProperty("delay_sec")]
        public uint DelaySec { get; set; }

        [JsonProperty("actions")]
        public IEnumerable<Action> Actions { get; set; }
    }


    public class Action
    {
        [JsonProperty("account")]
        public string Account { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("authorization")]
        public IEnumerable<Authorization> Authorization { get; set; }

        [JsonProperty("data")]
        public IDictionary<string, object> Data { get; set; }

        [JsonProperty("hex_data")]
        public string HexData { get; set; }
    }

    public class Authorization
    {
        [JsonProperty("actor")]
        public string Actor { get; set; }

        [JsonProperty("permission")]
        public string Permission { get; set; }
    }


    public class Detail
    {
        public string message { get; set; }
        public string file { get; set; }
        public int line_number { get; set; }
        public string method { get; set; }
    }

    public class Error
    {
        public int code { get; set; }
        public string name { get; set; }
        public string what { get; set; }
        public List<Detail> details { get; set; }
    }

    public class ErrorModel
    {
        public int code { get; set; }
        public string message { get; set; }
        public Error error { get; set; }
    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Row
    {
        public string miner { get; set; }
        public string last_mine_tx { get; set; }
        public DateTime last_mine { get; set; }
        public string current_land { get; set; }
    }

    public class GetLastTRX
    {
        public List<Row> rows { get; set; }
        public bool more { get; set; }
        public string next_key { get; set; }
    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
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

    public class CURTLM
    {
        public List<string> Data { get; set; }
    }



    public class EosDateTimeConverter : DateTimeConverterBase
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var date = (DateTime)value;
            var iso = date.ToUniversalTime().ToString("s");

            writer.WriteValue(iso);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var utcDate = $"{reader.Value}Z";
            return DateTime.Parse(utcDate);
        }
    }
}
