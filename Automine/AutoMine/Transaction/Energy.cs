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
    public class Energy
    {
        MainForm form;

        public Energy(MainForm form)
        {
            this.form = form;
        }

        public async Task<bool> EATFOOD(int Energy)
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
                                Account = "farmersworld",
                                Name = "recover",
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
                                    {"energy_recovered",  Energy}
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
                            this.form.Message("EAT FOOD Successfully!");
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

            }
            catch (Exception ex)
            {
                stausMine = false;
            }


            return stausMine;
        }
    }
}
