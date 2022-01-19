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
    public class Membership
    {
        MainForm form;
        public Membership(MainForm form)
        {
            this.form = form;
        }

        public async Task<bool> TransactionMineMember(int IndexRow, string AssetId)
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
                                Name = "mbsclaim",
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
                                    {"asset_id",  AssetId}
                                }
                            }
                            });
                await this.form.DelayTime(2, IndexRow);
                this.form.Info("" + packed_trx.Substring(0, 20) + " ...", IndexRow);
                var client = new RestClient("https://public-wax-on.wax.io/wam/sign");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
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
                var response = await client.ExecuteAsync(request);

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
            catch (Exception ex)
            {
                stausMine = false;
            }


            return stausMine;
        }
    }

}
