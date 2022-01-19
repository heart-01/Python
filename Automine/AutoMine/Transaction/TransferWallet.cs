using AutoMine.GetTableRow;
using AutoMine.GetToken;
using AutoMine.Models;
using EOS.Client;
using EOS.Client.Cryptography;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.Transaction
{
    public class TransferWallet
    {
        MainForm form;
        Get_Table_Row Table_Row;
        public TransferWallet(MainForm form)
        {
            this.form = form;
            this.Table_Row = new Get_Table_Row(form);
        }


        public async Task TransferWAX()
        {
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();
            try
            {
                var client = new RestClient("https://wax.pink.gg/v1/chain/get_account");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Referer", "https://play.alienworlds.io/");
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                new
                {
                    account_name = LoginWax.ACCOUNT,
                });

                var response = await client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var accountView = Newtonsoft.Json.JsonConvert.DeserializeObject<accountViewModles>(response.Content);

                    if (accountView.core_liquid_balance != null)
                    {

                        var WAXP = accountView.core_liquid_balance.Replace("WAX", ""); //WAX

                        if (Convert.ToDouble(WAXP) > 1.00)
                        {
                            EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                            var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                        {
                            Account = "eosio.token",
                            Name = "transfer",
                            Authorization = new[]
                            {
                                new EOS.Client.Models.Authorization
                                {
                                    Actor =  LoginWax.ACCOUNT,
                                    Permission = "active",
                                }
                            },
                            Data = new Dictionary<string, object>
                            {
                                {"from",  LoginWax.ACCOUNT},
                                {"to", Globals.ACCOUNT_TRANSFER}, // To account 
                                {"quantity", Convert.ToDouble(Globals.ACCOUNT_AMT).ToString("0.00000000")+" WAX"},
                                {"memo", Globals.ACCOUNT_MEMO},
                            }
                        }
                        });

                            client = new RestClient("https://public-wax-on.wax.io/wam/sign");
                            client.Timeout = 10000;
                            request = new RestRequest(Method.POST);
                            request.AddHeader("Referer", "https://play.alienworlds.io/");
                            request.AddHeader("x-access-token", LoginWax.TOKEN);
                            request.AddHeader("Content-type", "application/json");
                            request.AddJsonBody(
                            new
                            {
                                serializedTransaction = Hex.Decode(packed_trx),
                                website = "play.alienworlds.io",
                                description = "jwt is insecure",
                            });
                            response = await client.ExecuteAsync(request);

                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                signature = Newtonsoft.Json.JsonConvert.DeserializeObject<SignatureAW>(response.Content);
                            }


                            client = new RestClient("https://wax.pink.gg/v1/chain/push_transaction");
                            client.Timeout = 10000;
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
                                resultSucess = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultSucessMine>(response.Content);

                                if (resultSucess.transaction_id == null)
                                {
                                    errorModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                                    this.form.Message(errorModel.error.name + " : " + errorModel.error.what);
                                }
                                else
                                {
                                    this.form.Message("TRANSFER WAX SUCCESS ");
                                }
                            }
                            else
                            {
                                this.form.Message("CPU OVER ");
                            }
                        }
                        else
                        {
                            this.form.Message("WAX < 1 ");
                        }

                    }


                }
            }
            catch (Exception)
            {


            }


        }

        public async Task TransferToken()
        {
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();
            try
            {
                EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                        {
                            Account = "farmerstoken",
                            Name = "transfer",
                            Authorization = new[]
                            {
                                new EOS.Client.Models.Authorization
                                {
                                    Actor = LoginWax.ACCOUNT,
                                    Permission = "active",
                                }
                            },
                            Data = new Dictionary<string, object>
                            {
                                {"from", LoginWax.ACCOUNT},
                                {"to", Globals.ACCOUNT_TRANSFER}, // To account 
                                {"quantity", Convert.ToDouble(Globals.ACCOUNT_AMT).ToString("0.0000")+" FWW"},
                                {"memo", Globals.ACCOUNT_MEMO},
                            }
                        }
                        });

                var client = new RestClient("https://public-wax-on.wax.io/wam/sign");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Referer", "https://play.alienworlds.io/");
                request.AddHeader("x-access-token", LoginWax.TOKEN);
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                new
                {
                    serializedTransaction = Hex.Decode(packed_trx),
                    website = "play.alienworlds.io",
                    description = "jwt is insecure",
                });
                var response = await client.ExecuteAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    signature = Newtonsoft.Json.JsonConvert.DeserializeObject<SignatureAW>(response.Content);
                }


                client = new RestClient("https://wax.pink.gg/v1/chain/push_transaction");
                client.Timeout = 10000;
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
                    resultSucess = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultSucessMine>(response.Content);

                    if (resultSucess.transaction_id == null)
                    {
                        errorModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                        this.form.Message(errorModel.error.name + " : " + errorModel.error.what);
                    }
                    else
                    {
                        this.form.Message("TRANSFER WOOD SUCCESS ");
                    }
                }
                else
                {
                    this.form.Message("Transfer WOOD Error");
                }


            }
            catch (Exception)
            {


            }


        }
    }
}
