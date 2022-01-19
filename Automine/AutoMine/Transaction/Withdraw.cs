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
    public class Withdraw
    {

        MainForm form;
        Get_Table_Row Table_Row;
        public Withdraw(MainForm form)
        {
            this.form = form;
            this.Table_Row = new Get_Table_Row(form);
        }


        public async Task<bool> WithdrawWOOD(string Amount)
        {
            this.form.Message("Wating Withdraw WOOD");
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();
            bool stausMine = true;
            List<string> items = new List<string>();
            try
            {

                var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                new
                {
                    code = "farmersworld",
                    index_position = 1,
                    json = true,
                    key_type = "",
                    limit = "1",
                    lower_bound = "",
                    reverse = false,
                    scope = "farmersworld",
                    show_payer = false,
                    table = "config",
                    upper_bound = "",
                });
                var response = await client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var lstConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(response.Content);

                    var WOOD = Amount.Replace("WOOD : ", "").ToString().Trim() + " WOOD";
                    items.Add(WOOD);
                    EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                    var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "farmersworld",
                                Name = "withdraw",
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
                                    {"owner", LoginWax.ACCOUNT},
                                    {"quantities", items.ToArray()},
                                    {"fee",lstConfig.rows[0].fee},
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
                            this.form.Message("Withdraw WOOD Successfully!");
                            await Table_Row.GetWalletAccount();
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

        public async Task<bool> WithdrawFOOD(string Amount)
        {
            this.form.Message("Wating Withdraw FOOD");
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();
            bool stausMine = true;
            List<string> items = new List<string>();
            try
            {

                var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                new
                {
                    code = "farmersworld",
                    index_position = 1,
                    json = true,
                    key_type = "",
                    limit = "1",
                    lower_bound = "",
                    reverse = false,
                    scope = "farmersworld",
                    show_payer = false,
                    table = "config",
                    upper_bound = "",
                });
                var response = await client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var lstConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(response.Content);

                    var WOOD = Amount.Replace("FOOD : ", "").ToString().Trim() + " FOOD";
                    items.Add(WOOD);
                    EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                    var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "farmersworld",
                                Name = "withdraw",
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
                                    {"owner", LoginWax.ACCOUNT},
                                    {"quantities", items.ToArray()},
                                    {"fee",lstConfig.rows[0].fee},
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
                            this.form.Message("Withdraw FOOD Successfully!");
                            await Table_Row.GetWalletAccount();
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

        public async Task<bool> WithdrawGOLD(string Amount)
        {
            this.form.Message("Wating Withdraw GOLD");
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();
            bool stausMine = true;
            List<string> items = new List<string>();
            try
            {

                var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                new
                {
                    code = "farmersworld",
                    index_position = 1,
                    json = true,
                    key_type = "",
                    limit = "1",
                    lower_bound = "",
                    reverse = false,
                    scope = "farmersworld",
                    show_payer = false,
                    table = "config",
                    upper_bound = "",
                });
                var response = await client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var lstConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(response.Content);

                    var WOOD = Amount.Replace("GOLD : ", "").ToString().Trim() + " GOLD";
                    items.Add(WOOD);
                    EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                    var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "farmersworld",
                                Name = "withdraw",
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
                                    {"owner", LoginWax.ACCOUNT},
                                    {"quantities", items.ToArray()},
                                    {"fee",lstConfig.rows[0].fee},
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
                            this.form.Message("Withdraw GOLD Successfully!");
                            await Table_Row.GetWalletAccount();
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


        public async Task<bool> WithdrawWOODFEE5(string Amount, string Type)
        {
            this.form.Message("Wating Withdraw WOOD");
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();
            bool stausMine = true;
            List<string> items = new List<string>();
            try
            {

                var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                new
                {
                    code = "farmersworld",
                    index_position = 1,
                    json = true,
                    key_type = "",
                    limit = "1",
                    lower_bound = "",
                    reverse = false,
                    scope = "farmersworld",
                    show_payer = false,
                    table = "config",
                    upper_bound = "",
                });
                var response = await client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var lstConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(response.Content);

                    if (lstConfig.rows[0].fee == 5)
                    {
                        if (Type == "WOOD")
                        {
                            var Curency = Amount.Replace("WOOD : ", "").ToString().Trim() + " WOOD";
                            items.Add(Curency);
                        }
                        else if (Type == "FOOD")
                        {
                            var Curency = Amount.Replace("FOOD : ", "").ToString().Trim() + " FOOD";
                            items.Add(Curency);
                        }
                        else if (Type == "GOLD")
                        {
                            var Curency = Amount.Replace("GOLD : ", "").ToString().Trim() + " GOLD";
                            items.Add(Curency);
                        }

                        EosClient EOSNET = new EosClient(new Uri("https://wax.pink.gg/"));
                        var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "farmersworld",
                                Name = "withdraw",
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
                                    {"owner", LoginWax.ACCOUNT},
                                    {"quantities", items.ToArray()},
                                    {"fee",lstConfig.rows[0].fee},
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
                                this.form.Message("Withdraw WOOD Successfully!");
                                await Table_Row.GetWalletAccount();
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

            }
            catch (Exception ex)
            {
                stausMine = false;
            }


            return stausMine;
        }


    }
}
