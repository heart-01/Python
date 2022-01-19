using AutoMine.GetTableRow;
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
    public class Deposit
    {

        MainForm form;
        Get_Table_Row Table_Row;
        public Deposit(MainForm form)
        {
            this.form = form;
            this.Table_Row = new Get_Table_Row(form);
        }

        public async Task DepositWood()
        {

            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();

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
                    List<string> ctoken = new List<string>();
                    foreach (var item in lstCurrency)
                    {
                        var stmp = item.Substring(0, item.Length - 3).Trim();
                        if (item.Contains("FWW"))
                        {
                            if (Convert.ToDouble(stmp) > 1.0000)
                            {
                                ctoken.Add(item);
                                break;
                            }
                        }

                    }

                    if (ctoken.Count > 0)
                    {
                        EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                        var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "farmerstoken",
                                Name = "transfers",
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
                                    {"to", "farmersworld"},
                                    {"quantities",ctoken.ToArray()},
                                    {"memo", "deposit"},
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
                                this.form.Message("Deposit Wood Successfully!");
                            }
                            catch (Exception)
                            {

                            }
                        }
                        else if (response.StatusCode == HttpStatusCode.InternalServerError)
                        {

                            errorModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                        }
                    }


                }

            }
            catch (Exception ex)
            {

            }

        }

        public async Task DepositFood()
        {

            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();

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
                    List<string> ctoken = new List<string>();
                    foreach (var item in lstCurrency)
                    {
                        var stmp = item.Substring(0, item.Length - 3).Trim();
                        if (item.Contains("FWF"))
                        {
                            if (Convert.ToDouble(stmp) > 1.0000)
                            {
                                ctoken.Add(item);
                                break;
                            }
                        }

                    }

                    if (ctoken.Count > 0)
                    {
                        EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                        var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "farmerstoken",
                                Name = "transfers",
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
                                    {"to", "farmersworld"},
                                    {"quantities",ctoken.ToArray()},
                                    {"memo", "deposit"},
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
                                this.form.Message("Deposit Food Successfully!");
                            }
                            catch (Exception)
                            {

                            }
                        }
                        else if (response.StatusCode == HttpStatusCode.InternalServerError)
                        {

                            errorModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                        }
                    }


                }

            }
            catch (Exception ex)
            {

            }

        }

        public async Task DepositGold()
        {

            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();

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
                    List<string> ctoken = new List<string>();
                    foreach (var item in lstCurrency)
                    {
                        var stmp = item.Substring(0, item.Length - 3).Trim();
                        if (item.Contains("FWG"))
                        {
                            if (Convert.ToDouble(stmp) > 1.0000)
                            {
                                ctoken.Add(item);
                                break;
                            }
                        }

                    }

                    if (ctoken.Count > 0)
                    {
                        EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                        var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "farmerstoken",
                                Name = "transfers",
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
                                    {"to", "farmersworld"},
                                    {"quantities",ctoken.ToArray()},
                                    {"memo", "deposit"},
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
                                this.form.Message("Deposit Gold Successfully!");
                            }
                            catch (Exception)
                            {

                            }
                        }
                        else if (response.StatusCode == HttpStatusCode.InternalServerError)
                        {

                            errorModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                        }
                    }


                }

            }
            catch (Exception ex)
            {

            }

        }

        public async Task<bool> DepositAll()
        {
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
                    List<string> ctoken = new List<string>();
                    foreach (var item in lstCurrency)
                    {
                        var stmp = item.Substring(0, item.Length - 3).Trim();
                        if (Convert.ToDouble(stmp) > 1.0000)
                        {
                            ctoken.Add(item);
                        }
                    }

                    if (ctoken.Count > 0)
                    {
                        EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                        var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "farmerstoken",
                                Name = "transfers",
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
                                    {"to", "farmersworld"},
                                    {"quantities",ctoken.ToArray()},
                                    {"memo", "deposit"},
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
                                this.form.Message("Deposit all Successfully!");
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
