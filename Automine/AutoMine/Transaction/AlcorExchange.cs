using AutoMine.GetTableRow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMine.GetToken;
using AutoMine.Models;
using EOS.Client;
using EOS.Client.Cryptography;
using RestSharp;
using System.Net;

namespace AutoMine.Transaction
{
    public class AlcorExchange
    {

        MainForm form;
        Get_Table_Row Table_Row;
        public AlcorExchange(MainForm form)
        {
            this.form = form;
            this.Table_Row = new Get_Table_Row(form);
        }
        public async Task<bool> BuyGold(string Gold)
        {
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();

            bool stausMine = true;

            try
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
                                        Actor = LoginWax.ACCOUNT,  // Account Mine
                                        Permission = "active",
                                    }
                                },
                                Data = new Dictionary<string, object>
                                {
                                    {"from", LoginWax.ACCOUNT},
                                    {"to", "alcordexmain"},
                                    {"quantity",Convert.ToDouble(Gold).ToString("0.00000000")+" WAX"},
                                    {"memo", "0.0000 FWG@farmerstoken"},
                                }
                            }
                            });
                await Task.Delay(2000);
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
                    website = "play.farmersworld.io",
                    description = "jwt is insecure",
                });
                var response = await client.ExecuteAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    signature = Newtonsoft.Json.JsonConvert.DeserializeObject<SignatureAW>(response.Content);
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    Globals.Login = false;
                    if (Globals.Login == false)
                    {
                        LoginWallet.Login login = new LoginWallet.Login("", "", "");
                        await login.LoginAccount();

                    }

                    return false;
                }
                else
                {
                    return false;
                }


                await Task.Delay(2000);
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
                    try
                    {
                        resultSucess = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultSucessMine>(response.Content);
                        this.form.Message("Buy Gold Successfully!");
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else if (response.StatusCode == HttpStatusCode.InternalServerError)
                {

                    errorModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                }
            }
            catch (Exception ex)
            {
                stausMine = false;
            }


            return stausMine;
        }

        public async Task<bool> BuyFood(string Food)
        {
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();

            bool stausMine = true;

            try
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
                                        Actor = LoginWax.ACCOUNT,  // Account Mine
                                        Permission = "active",
                                    }
                                },
                                Data = new Dictionary<string, object>
                                {
                                    {"from", LoginWax.ACCOUNT},
                                    {"to", "alcordexmain"},
                                    {"quantity",Convert.ToDouble(Food).ToString("0.00000000")+" WAX"},
                                    {"memo", "0.0000 FWF@farmerstoken"},
                                }
                            }
                            });
                await Task.Delay(2000);
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
                    website = "play.farmersworld.io",
                    description = "jwt is insecure",
                });
                var response = await client.ExecuteAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    signature = Newtonsoft.Json.JsonConvert.DeserializeObject<SignatureAW>(response.Content);
                }
                else if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    Globals.Login = false;
                    if (Globals.Login == false)
                    {
                        LoginWallet.Login login = new LoginWallet.Login("", "", "");
                        await login.LoginAccount();

                    }

                    return false;
                }
                else
                {
                    return false;
                }


                await Task.Delay(2000);
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
                    try
                    {
                        resultSucess = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultSucessMine>(response.Content);
                        this.form.Message("Buy Food Successfully!");
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                else if (response.StatusCode == HttpStatusCode.InternalServerError)
                {

                    errorModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                }
            }
            catch (Exception ex)
            {
                stausMine = false;
            }


            return stausMine;
        }

        public async Task<bool> SellWOOD()
        {

            this.form.Message("Waiting Sell Wood!");
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();
            bool stausMine = true;

            try
            {

                var client = new RestClient("https://wax.pink.gg/v1/chain/get_currency_balance");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                new
                {
                    account = LoginWax.ACCOUNT,
                    code = "farmerstoken",
                });
                var response = await client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    var lstCurrency = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(response.Content);
                    var WOOD = "";
                    foreach (var item in lstCurrency)
                    {
                        if (item.Contains("FWW"))
                        {
                            WOOD = item;
                            break;
                        }
                    }

                    EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                    var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "farmerstoken",
                                Name = "transfer",
                                Authorization = new[]
                                {
                                      new EOS.Client.Models.Authorization
                                    {
                                        Actor = LoginWax.ACCOUNT,  // Account Mine
                                        Permission = "active",
                                    }
                                },
                                Data = new Dictionary<string, object>
                                {
                                    {"from", LoginWax.ACCOUNT},
                                    {"to", "alcordexmain"},
                                    {"quantity", WOOD},
                                    {"memo", "0.00000000 WAX@eosio.token"},
                                }
                            }
                            });
                    await Task.Delay(2000);
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
                        website = "play.farmersworld.io",
                        description = "jwt is insecure",
                    });
                    response = await client.ExecuteAsync(request);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        signature = Newtonsoft.Json.JsonConvert.DeserializeObject<SignatureAW>(response.Content);
                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        Globals.Login = false;
                        if (Globals.Login == false)
                        {
                            LoginWallet.Login login = new LoginWallet.Login("", "", "");
                            await login.LoginAccount();

                        }

                        return false;
                    }
                    else
                    {
                        return false;
                    }


                    await Task.Delay(2000);
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
                        try
                        {
                            resultSucess = Newtonsoft.Json.JsonConvert.DeserializeObject<ResultSucessMine>(response.Content);
                            this.form.Message("SellWOOD Successfully!");
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                    else if (response.StatusCode == HttpStatusCode.InternalServerError)
                    {

                        errorModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                        this.form.Message(errorModel.error.what);
                    }
                }

            }
            catch (Exception ex)
            {
                stausMine = false;
            }


            return stausMine;
        }
    }
}
