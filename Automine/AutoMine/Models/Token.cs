using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.GetToken
{
    public class SessionToken
    {
        public string token2fa { get; set; }
    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Phone
    {
        public string type { get; set; }
        public string country_code { get; set; }
        public string phone_number { get; set; }
        public bool verified { get; set; }
    }

    public class Address
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string address3 { get; set; }
        public string city { get; set; }
        public string locality { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
    }

    public class TokenModel
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string email_local_no_plus { get; set; }
        public string email_local_no_dots { get; set; }
        public string email_domain { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string password_changed_at { get; set; }
        public bool confirmed { get; set; }
        public object steam_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public object display_name { get; set; }
        public Phone phone { get; set; }
        public object additional_authentication { get; set; }
        public Address address { get; set; }
        public List<object> social_accounts { get; set; }
        public bool tos_accepted { get; set; }
        public bool age_accepted { get; set; }
        public string token { get; set; }
    }


    public class SignErrorModel
    {
        public string error { get; set; }
        public string message { get; set; }
    }

    public class Currency
    {
        public List<string> currency_balance { get; set; }
    }


    public class Row
    {
        public int init_energy { get; set; }
        public int init_max_energy { get; set; }
        public int reward_noise_min { get; set; }
        public int reward_noise_max { get; set; }
        public int min_fee { get; set; }
        public int max_fee { get; set; }
        public int last_fee_updated { get; set; }
        public int fee { get; set; }
    }

    public class ConfigModel
    {
        public List<Row> rows { get; set; }
        public bool more { get; set; }
        public string next_key { get; set; }
    }



}
