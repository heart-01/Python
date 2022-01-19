using AutoMine.Models;
using AutoMine.SetBag;
using EOS.Client;
using EOS.Client.Cryptography;
using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMine
{
    public partial class FormConfig : Form
    {

        public FormConfig()
        {
            InitializeComponent();
        }

        private void FromConfig_Load(object sender, EventArgs e)
        {

        }


        private async void BtnStake_Click(object sender, EventArgs e)
        {
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();
            try
            {
                if (Globals.ACCOUNT_ID != "" && Globals.TOKEN_ID != "")
                {
                    var client = new RestClient("https://wax.pink.gg/v1/chain/get_account");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Referer", "https://play.alienworlds.io/");
                    request.AddHeader("Content-type", "application/json");
                    request.AddJsonBody(
                    new
                    {
                        account_name = Globals.ACCOUNT_ID,
                    });


                    var response = await client.ExecuteAsync(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var accountView = new JsonDeserializer().Deserialize<accountViewModles>(response);

                        if (accountView.total_resources.cpu_weight != null)
                        {
                            var WAXP = accountView.total_resources.cpu_weight.Replace("WAX", ""); //WAX Stack
                            EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                            var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "eosio",
                                Name = "delegatebw",
                                Authorization = new[]
                                {
                                    new EOS.Client.Models.Authorization
                                    {
                                        Actor = Globals.ACCOUNT_ID,
                                        Permission = "active",
                                    }
                                },
                                Data = new Dictionary<string, object>
                                {
                                    {"from", Globals.ACCOUNT_ID},
                                    {"receiver", Globals.ACCOUNT_ID}, // To account 
                                    {"stake_net_quantity","0.00000000 WAX"},
                                    {"stake_cpu_quantity", Convert.ToDouble(txtAmount.Text).ToString("0.00000000")+ " WAX"}, // To account 
                                    {"transfer", false},
                                }
                            }
                            });
                            client = new RestClient("https://public-wax-on.wax.io/wam/sign");
                            request = new RestRequest(Method.POST);
                            request.AddHeader("Referer", "https://play.alienworlds.io/");
                            request.AddHeader("x-access-token", Globals.TOKEN_ID);
                            request.AddHeader("Content-type", "application/json");
                            request.AddJsonBody(
                            new
                            {
                                serializedTransaction = Hex.Decode(packed_trx),
                                website = "play.farmersworld.io",
                                description = "jwt is insecure",
                            });
                            response = await client.ExecuteAsync(request);

                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                signature = new JsonDeserializer().Deserialize<SignatureAW>(response);
                            }

                            client = new RestClient("https://wax.pink.gg/v1/chain/push_transaction");
                            request = new RestRequest(Method.POST);
                            request.AddHeader("Referer", "https://play.alienworlds.io/");
                            request.AddHeader("Content-type", "application/json");
                            request.AddJsonBody(
                            new
                            {
                                signatures = signature.signatures,
                                compression = 0,
                                packed_context_free_data = "",
                                packed_trx = packed_trx,
                            });
                            response = await client.ExecuteAsync(request);
                            if (response.StatusCode == HttpStatusCode.Accepted)
                            {
                                resultSucess = new JsonDeserializer().Deserialize<ResultSucessMine>(response);

                                if (resultSucess.transaction_id == null)
                                {
                                    errorModel = new JsonDeserializer().Deserialize<ErrorModel>(response);
                                    MessageBox.Show(errorModel.error.name + " : " + errorModel.error.what + " : ID " + Globals.ACCOUNT_ID + " STACK WAX FAIL", "System !");
                                }
                                else
                                {
                                    MessageBox.Show("ID " + Globals.ACCOUNT_ID + " STACK WAX SUCCESS", "System !");
                                }
                            }
                            else if (response.StatusCode == HttpStatusCode.InternalServerError)
                            {
                                errorModel = new JsonDeserializer().Deserialize<ErrorModel>(response);
                                MessageBox.Show(errorModel.error.name + " : " + errorModel.error.what + " : ID " + Globals.ACCOUNT_ID + " STACK WAX FAIL", "System !");

                            }

                        }


                    }
                }
                else
                {
                    MessageBox.Show("Please Input Account WAX", "System !");
                }


            }
            catch (Exception)
            {


            }
        }

        private async void BtnUnstake_Click(object sender, EventArgs e)
        {
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();
            try
            {
                if (Globals.ACCOUNT_ID != "" && Globals.TOKEN_ID != "")
                {
                    var client = new RestClient("https://wax.pink.gg/v1/chain/get_account");
                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Referer", "https://play.alienworlds.io/");
                    request.AddHeader("Content-type", "application/json");
                    request.AddJsonBody(
                    new
                    {
                        account_name = Globals.ACCOUNT_ID,
                    });


                    var response = await client.ExecuteAsync(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var accountView = new JsonDeserializer().Deserialize<accountViewModles>(response);

                        if (accountView.total_resources.cpu_weight != null)
                        {
                            var STAKECPU = accountView.total_resources.cpu_weight.Replace("WAX", ""); //WAX Stack
                            EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                            var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "eosio",
                                Name = "undelegatebw",
                                Authorization = new[]
                                {
                                    new EOS.Client.Models.Authorization
                                    {
                                        Actor = Globals.ACCOUNT_ID,
                                        Permission = "active",
                                    }
                                },
                                Data = new Dictionary<string, object>
                                {
                                    {"from", Globals.ACCOUNT_ID},
                                    {"receiver", Globals.ACCOUNT_ID}, // To account 
                                    {"unstake_net_quantity","0.00000000 WAX"},
                                    {"unstake_cpu_quantity", (Convert.ToDouble(txtAmountUn.Text)).ToString("0.00000000")+ " WAX"}, // To account 
                                }
                            }
                            });
                            client = new RestClient("https://public-wax-on.wax.io/wam/sign");
                            request = new RestRequest(Method.POST);
                            request.AddHeader("Referer", "https://play.alienworlds.io/");
                            request.AddHeader("x-access-token", Globals.TOKEN_ID);
                            request.AddHeader("Content-type", "application/json");
                            request.AddJsonBody(
                            new
                            {
                                serializedTransaction = Hex.Decode(packed_trx),
                                website = "play.farmersworld.io",
                                description = "jwt is insecure",
                            });
                            response = await client.ExecuteAsync(request);

                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                signature = new JsonDeserializer().Deserialize<SignatureAW>(response);
                                //Info("Http Status Code OK", IndexRow);
                                //await DelayTime(2, IndexRow);
                            }

                            client = new RestClient("https://wax.pink.gg/v1/chain/push_transaction");
                            request = new RestRequest(Method.POST);
                            request.AddHeader("Referer", "https://play.alienworlds.io/");
                            request.AddHeader("Content-type", "application/json");
                            request.AddJsonBody(
                            new
                            {
                                signatures = signature.signatures,
                                compression = 0,
                                packed_context_free_data = "",
                                packed_trx = packed_trx,
                            });
                            response = await client.ExecuteAsync(request);
                            if (response.StatusCode == HttpStatusCode.Accepted)
                            {
                                resultSucess = new JsonDeserializer().Deserialize<ResultSucessMine>(response);

                                if (resultSucess.transaction_id == null)
                                {
                                    errorModel = new JsonDeserializer().Deserialize<ErrorModel>(response);
                                    MessageBox.Show(errorModel.error.name + " : " + errorModel.error.what + " : ID " + Globals.ACCOUNT_ID + " UNSTACK WAX FAIL", "System !");
                                }
                                else
                                {
                                    MessageBox.Show("ID " + Globals.ACCOUNT_ID + " UNSTACK WAX SUCCESS", "System !");
                                }
                            }
                            else if (response.StatusCode == HttpStatusCode.InternalServerError)
                            {
                                errorModel = new JsonDeserializer().Deserialize<ErrorModel>(response);
                                MessageBox.Show(errorModel.error.name + " : " + errorModel.error.what + " : ID " + Globals.ACCOUNT_ID + " UNSTACK WAX FAIL", "System !");

                            }

                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please Input Account WAX", "System !");
                }
            }
            catch (Exception)
            {


            }

        }

    }
}
