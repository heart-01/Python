using AutoMine.Models;
using AutoMine.Models.Assets;
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
    public class Animals
    {
        MainForm form;
        public Animals(MainForm form)
        {
            this.form = form;
        }

        public async Task<bool> TransactionMineAnimals(int IndexRow, string AssetId)
        {
            SignatureAW signature = new SignatureAW();
            ResultSucessMine resultSucess = new ResultSucessMine();
            ErrorModel errorModel = new ErrorModel();

            bool stausMine = true;

            try
            {

                List<string> ArrayBarley = new List<string>();
                var client = new RestClient("https://wax.api.atomicassets.io/atomicassets/v1/assets?page=1&limit=100&collection_name=farmersworld&owner=" + LoginWax.ACCOUNT + "&schema_name=foods");
                client.Timeout = 10000;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Referer", "https://play.farmersworld.io/");
                request.AddHeader("Content-type", "application/json");
                var response = await client.ExecuteAsync(request);
                client.Timeout = 10000;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var assetsModel = Newtonsoft.Json.JsonConvert.DeserializeObject<AssetsModel>(response.Content);

                    foreach (var item in assetsModel.data)
                    {
                        if (item.name == "Barley")
                        {
                            //BarleyAsset_Id = item.asset_id;
                            ArrayBarley.Add(item.asset_id);
                            break;
                        }
                    }

                }

                if (ArrayBarley.Count > 0)
                {
                    EosClient EOSNET = new EosClient(new Uri("https://api.wax.alohaeos.com/"));
                    var packed_trx = await EOSNET.PushActionsAsync(new[] { new EOS.Client.Models.Action()
                            {
                                Account = "atomicassets",
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
                                    {"asset_ids", ArrayBarley},
                                    {"from",  LoginWax.ACCOUNT},
                                    {"memo",  "feed_animal:" + AssetId},
                                    {"to",  "farmersworld"},
                                }
                            }
                            });
                    await this.form.DelayTime(2, IndexRow);
                    this.form.Info("" + packed_trx.Substring(0, 20) + " ...", IndexRow);
                    client = new RestClient("https://public-wax-on.wax.io/wam/sign");
                    client.Timeout = 10000;
                    request = new RestRequest(Method.POST);
                    request.AddHeader("Referer", "https://play.alienworlds.io/");
                    request.AddHeader("x-access-token", LoginWax.TOKEN); //lblToken.Text
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

                        this.form.Info("Sing Signature ...", IndexRow);
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


                    await this.form.DelayTime(2, IndexRow);
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
                            this.form.Info("Mine Success : " + resultSucess.transaction_id.Substring(0, 20), IndexRow);
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }
                    else if (response.StatusCode == HttpStatusCode.InternalServerError)
                    {

                        errorModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ErrorModel>(response.Content);
                        this.form.Info(errorModel.error.name + " : " + errorModel.error.details[0].message, IndexRow);
                        if (errorModel.error.name == "tx_cpu_usage_exceeded")
                        {
                            await this.form.DelayTime(300, IndexRow);
                        }
                    }

                }
                else
                {
                    this.form.Info("No Barley.", IndexRow);
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
