using AutoMine.FarmAccount;
using AutoMine.FarmTools;
using AutoMine.GetToken;
using AutoMine.Models;
using AutoMine.Models.Assets2;
using AutoMine.Models.Crops;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.GetTableRow
{
    public class Get_Table_Row
    {

        MainForm form;
        Transaction.Energy energy;
        public Get_Table_Row(MainForm form)
        {
            this.form = form;
            this.energy = new Transaction.Energy(form);
        }

        private void addGrid(string Column1, string Column2, int Column3, string Column4, string Column5, string Column6)
        {
            this.form.addGrid(Column1, Column2, Column3.ToString(), Column4, Column5, Column6);
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        public async Task GetNFTAccount()
        {
            var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                code = "farmersworld",
                index_position = 2,
                json = true,
                key_type = "i64",
                limit = "100",
                lower_bound = LoginWax.ACCOUNT,
                reverse = false,
                scope = "farmersworld",
                show_payer = false,
                table = "tools",
                upper_bound = LoginWax.ACCOUNT,
            });
            var response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var Tools = Newtonsoft.Json.JsonConvert.DeserializeObject<ToolsFarm>(response.Content);
                var i = 0;
                foreach (var item in Tools.rows)
                {

                    var stime = UnixTimeStampToDateTime(item.next_availability);
                    var TimeMine = (stime - DateTime.Now).TotalSeconds;

                    var ms_until_mine = Convert.ToInt32(TimeMine);
                    if (ms_until_mine < 0)
                    {
                        ms_until_mine = 0;
                    }

                    var Itemname = "";

                    client = new RestClient("https://wax.api.atomicassets.io/atomicmarket/v1/assets/" + item.asset_id);
                    client.Timeout = 10000;
                    request = new RestRequest(Method.GET);
                    request.AddHeader("Referer", "https://play.farmersworld.io/");
                    request.AddHeader("Content-type", "application/json");
                    response = await client.ExecuteAsync(request);
                    client.Timeout = 10000;
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var modelAssets2 = Newtonsoft.Json.JsonConvert.DeserializeObject<ModelAssets2>(response.Content);
                        Itemname = modelAssets2.data.name;
                    }

                    addGrid(item.asset_id, Itemname, ms_until_mine + (30 * i), item.current_durability + "/" + item.durability, "Next " + DateTime.Now.AddSeconds(ms_until_mine).ToString("dd-MM-yyy HH:mm:ss"), "Tools");
                    i++;
                }

            }

            client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                code = "farmersworld",
                index_position = 2,
                json = true,
                key_type = "i64",
                limit = "100",
                lower_bound = LoginWax.ACCOUNT,
                reverse = false,
                scope = "farmersworld",
                show_payer = false,
                table = "mbs",
                upper_bound = LoginWax.ACCOUNT,
            });
            response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var Tools = Newtonsoft.Json.JsonConvert.DeserializeObject<FarmCrops>(response.Content);
                var i = 0;
                foreach (var item in Tools.rows)
                {

                    var stime = UnixTimeStampToDateTime(item.next_availability);
                    var TimeMine = (stime - DateTime.Now).TotalSeconds;

                    var ms_until_mine = Convert.ToInt32(TimeMine);
                    if (ms_until_mine < 0)
                    {
                        ms_until_mine = 0;
                    }


                    addGrid(item.asset_id, item.name, ms_until_mine + (30 * i), "Membership", "Next " + DateTime.Now.AddSeconds(ms_until_mine).ToString("dd-MM-yyy HH:mm:ss"), "Member");
                    i++;
                }

            }


            client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                code = "farmersworld",
                index_position = 2,
                json = true,
                key_type = "i64",
                limit = "100",
                lower_bound = LoginWax.ACCOUNT,
                reverse = false,
                scope = "farmersworld",
                show_payer = false,
                table = "animals",
                upper_bound = LoginWax.ACCOUNT,
            });
            response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var Tools = Newtonsoft.Json.JsonConvert.DeserializeObject<FarmCrops>(response.Content);
                var i = 0;
                foreach (var item in Tools.rows)
                {

                    var stime = UnixTimeStampToDateTime(item.next_availability);
                    var TimeMine = (stime - DateTime.Now).TotalSeconds;

                    var ms_until_mine = Convert.ToInt32(TimeMine);
                    if (ms_until_mine < 0)
                    {
                        ms_until_mine = 0;
                    }


                    addGrid(item.asset_id, item.name, ms_until_mine + (30 * i), "Animals", "Next " + DateTime.Now.AddSeconds(ms_until_mine).ToString("dd-MM-yyy HH:mm:ss"), "Animals");
                    i++;
                }

            }


            client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                code = "farmersworld",
                index_position = 2,
                json = true,
                key_type = "i64",
                limit = "100",
                lower_bound = LoginWax.ACCOUNT,
                reverse = false,
                scope = "farmersworld",
                show_payer = false,
                table = "crops",
                upper_bound = LoginWax.ACCOUNT,
            });
            response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var Crops = Newtonsoft.Json.JsonConvert.DeserializeObject<FarmCrops>(response.Content);
                var i = 0;
                foreach (var item in Crops.rows)
                {

                    var stime = UnixTimeStampToDateTime(item.next_availability);
                    var TimeMine = (stime - DateTime.Now).TotalSeconds;

                    var ms_until_mine = Convert.ToInt32(TimeMine);
                    if (ms_until_mine < 0)
                    {
                        ms_until_mine = 0;
                    }


                    addGrid(item.asset_id, item.name, ms_until_mine + (30 * i), item.times_claimed + "/42", "Next " + DateTime.Now.AddSeconds(ms_until_mine).ToString("dd-MM-yyy HH:mm:ss"), "Crops");
                    i++;
                }

            }
        }

        public async Task GetWalletAccount()
        {
            var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                code = "farmersworld",
                index_position = 1,
                json = true,
                key_type = "i64",
                limit = "100",
                lower_bound = LoginWax.ACCOUNT,
                reverse = false,
                scope = "farmersworld",
                show_payer = false,
                table = "accounts",
                upper_bound = LoginWax.ACCOUNT,
            });
            var response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var Farm = Newtonsoft.Json.JsonConvert.DeserializeObject<AccountFarm>(response.Content);
                var lblEnergy = "Energy : " + Farm.rows[0].energy.ToString() + "/" + Farm.rows[0].max_energy.ToString();
                var lblGold = "";
                var lblWood = "";
                var lblFood = "";
                foreach (var item in Farm.rows[0].balances)
                {
                    var type = item.Substring(item.Length - 4, 4);
                    if (type == "GOLD")
                    {
                        lblGold = "GOLD : " + item.Replace("GOLD", "");
                    }
                    else if (type == "WOOD")
                    {
                        lblWood = "WOOD : " + item.Replace("WOOD", "");
                    }
                    else if (type == "FOOD")
                    {
                        lblFood = "FOOD : " + item.Replace("FOOD", "");
                    }
                }

                this.form.ConfigWallet(lblEnergy, lblGold, lblFood, lblWood);
            }
        }

        public async Task GetConfigGame()
        {
            var client = new RestClient("https://wax.pink.gg/v1/chain/get_account");
            client.Timeout = 10000;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                account_name = LoginWax.ACCOUNT,
            });
            var response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var accountView = Newtonsoft.Json.JsonConvert.DeserializeObject<accountViewModles>(response.Content);
                var Cpu = (Convert.ToDecimal(accountView.cpu_limit.used) / Convert.ToDecimal(accountView.cpu_limit.max)) * 100;
                var WAX = accountView.core_liquid_balance.Replace("WAX", ""); //WAX
                var STAKECPU = accountView.total_resources.cpu_weight.Replace("WAX", ""); //WAX Stack
                var lblCPU = "CPU : " + Cpu.ToString("0.00") + " %";
                var lblWAX = "WAX : " + Convert.ToDecimal(WAX).ToString("0.00");
                var lblStake = "STAKE : " + Convert.ToDecimal(STAKECPU).ToString("0.00");

                this.form.CPUWAXSTAKE(lblCPU, lblWAX, lblStake);
            }

            client = new RestClient("https://wax.pink.gg/v1/chain/get_currency_balance");
            client.Timeout = 10000;
            request = new RestRequest(Method.POST);
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                account = LoginWax.ACCOUNT,
                code = "farmerstoken",
            });
            response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var lstCurrency = Newtonsoft.Json.JsonConvert.DeserializeObject<string[]>(response.Content);
                var lblTF = "";
                var lblTW = "";
                var lblTG = "";

                foreach (var item in lstCurrency)
                {
                    var Currency = item.Substring(item.Length - 3, 3);
                    if (Currency == "FWF")
                    {
                        lblTF = item;
                    }
                    else if (Currency == "FWW")
                    {
                        lblTW = item;
                    }
                    else if (Currency == "FWG")
                    {
                        lblTG = item;
                    }

                }

                this.form.TokenWallet(lblTG, lblTF, lblTW);


            }

            client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            request = new RestRequest(Method.POST);
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
            response = await client.ExecuteAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var lstConfig = Newtonsoft.Json.JsonConvert.DeserializeObject<ConfigModel>(response.Content);
                this.form.Vat("FEE : " + lstConfig.rows[0].fee);
            }

        }


        public async Task GetCheckEatFood(int Energy)
        {
            try
            {
                var lblGold = "";
                var lblWood = "";
                var lblFood = "";


                var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Referer", "https://play.farmersworld.io/");
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                new
                {
                    code = "farmersworld",
                    index_position = 1,
                    json = true,
                    key_type = "i64",
                    limit = "100",
                    lower_bound = LoginWax.ACCOUNT,
                    reverse = false,
                    scope = "farmersworld",
                    show_payer = false,
                    table = "accounts",
                    upper_bound = LoginWax.ACCOUNT,
                });
                var response = await client.ExecuteAsync(request);
                client.Timeout = 10000;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var Farm = Newtonsoft.Json.JsonConvert.DeserializeObject<AccountFarm>(response.Content);
                    var lblEnergy = "Energy : " + Farm.rows[0].energy.ToString() + "/" + Farm.rows[0].max_energy.ToString();

                    foreach (var item in Farm.rows[0].balances)
                    {
                        var type = item.Substring(item.Length - 4, 4);
                        if (type == "GOLD")
                        {
                            lblGold = "GOLD : " + item.Replace("GOLD", "");
                        }
                        else if (type == "WOOD")
                        {
                            lblWood = "WOOD : " + item.Replace("WOOD", "");
                        }
                        else if (type == "FOOD")
                        {
                            lblFood = "FOOD : " + item.Replace("FOOD", "");
                        }
                    }

                    this.form.ConfigWallet(lblEnergy, lblGold, lblFood, lblWood);

                    if (Farm.rows[0].energy < Energy)
                    {
                        var EnergyFood = Math.Floor(Convert.ToDouble(lblFood.Replace("FOOD : ", "").ToString().Trim()));

                        if (EnergyFood > 0)
                        {
                            var Total = EnergyFood * 5;

                            var RemainSum = Farm.rows[0].max_energy - Farm.rows[0].energy;

                            //Transaction.Energy energy = new Transaction.Energy(); 

                            if (Total > RemainSum)
                            {
                                await energy.EATFOOD(Convert.ToInt32(RemainSum));
                            }
                            else
                            {
                                await energy.EATFOOD(Convert.ToInt32(Total));
                            }

                        }
                        else
                        {
                            this.form.Message("NO FOOD !!");
                        }


                    }

                }
            }
            catch (Exception)
            {


            }

        }

        public async Task GetCheckEatFarm(string AssetId)
        {
            try
            {
                var lblGold = "";
                var lblWood = "";
                var lblFood = "";


                var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Referer", "https://play.farmersworld.io/");
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                new
                {
                    code = "farmersworld",
                    index_position = 2,
                    json = true,
                    key_type = "i64",
                    limit = "100",
                    lower_bound = LoginWax.ACCOUNT,
                    reverse = false,
                    scope = "farmersworld",
                    show_payer = false,
                    table = "crops",
                    upper_bound = LoginWax.ACCOUNT,
                });
                var response = await client.ExecuteAsync(request);
                client.Timeout = 10000;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var farmCrops = Newtonsoft.Json.JsonConvert.DeserializeObject<FarmCrops>(response.Content);

                    foreach (var tmp in farmCrops.rows.Where(x => x.asset_id == AssetId))
                    {

                        if (tmp.times_claimed == 41)
                        {
                            client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
                            client.Timeout = 10000;
                            request = new RestRequest(Method.POST);
                            request.AddHeader("Referer", "https://play.farmersworld.io/");
                            request.AddHeader("Content-type", "application/json");
                            request.AddJsonBody(
                            new
                            {
                                code = "farmersworld",
                                index_position = 1,
                                json = true,
                                key_type = "i64",
                                limit = "100",
                                lower_bound = LoginWax.ACCOUNT,
                                reverse = false,
                                scope = "farmersworld",
                                show_payer = false,
                                table = "accounts",
                                upper_bound = LoginWax.ACCOUNT,
                            });
                            response = await client.ExecuteAsync(request);
                            client.Timeout = 10000;
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                var Farm = Newtonsoft.Json.JsonConvert.DeserializeObject<AccountFarm>(response.Content);
                                var lblEnergy = "Energy : " + Farm.rows[0].energy.ToString() + "/" + Farm.rows[0].max_energy.ToString();

                                foreach (var item in Farm.rows[0].balances)
                                {
                                    var type = item.Substring(item.Length - 4, 4);
                                    if (type == "GOLD")
                                    {
                                        lblGold = "GOLD : " + item.Replace("GOLD", "");
                                    }
                                    else if (type == "WOOD")
                                    {
                                        lblWood = "WOOD : " + item.Replace("WOOD", "");
                                    }
                                    else if (type == "FOOD")
                                    {
                                        lblFood = "FOOD : " + item.Replace("FOOD", "");
                                    }
                                }

                                this.form.ConfigWallet(lblEnergy, lblGold, lblFood, lblWood);

                                if (Farm.rows[0].energy < 250)
                                {
                                    var EnergyFood = Math.Floor(Convert.ToDouble(lblFood.Replace("FOOD : ", "").ToString().Trim()));

                                    if (EnergyFood > 0)
                                    {
                                        var Total = EnergyFood * 5;

                                        var RemainSum = Farm.rows[0].max_energy - Farm.rows[0].energy;

                                        //Transaction.Energy energy = new Transaction.Energy(); 

                                        if (Total > RemainSum)
                                        {
                                            await energy.EATFOOD(Convert.ToInt32(RemainSum));
                                        }
                                        else
                                        {
                                            await energy.EATFOOD(Convert.ToInt32(Total));
                                        }

                                    }
                                    else
                                    {
                                        this.form.Message("NO FOOD !!");
                                    }


                                }

                            }
                        }
                    }
                }


            }
            catch (Exception)
            {


            }

        }

        public async Task GetCheckEatAnimal()
        {
            try
            {
                var lblGold = "";
                var lblWood = "";
                var lblFood = "";

                var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
                client.Timeout = 10000;
                var request = new RestRequest(Method.POST);
                request.AddHeader("Referer", "https://play.farmersworld.io/");
                request.AddHeader("Content-type", "application/json");
                request.AddJsonBody(
                new
                {
                    code = "farmersworld",
                    index_position = 1,
                    json = true,
                    key_type = "i64",
                    limit = "100",
                    lower_bound = LoginWax.ACCOUNT,
                    reverse = false,
                    scope = "farmersworld",
                    show_payer = false,
                    table = "accounts",
                    upper_bound = LoginWax.ACCOUNT,
                });
                var response = await client.ExecuteAsync(request);
                client.Timeout = 10000;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var Farm = Newtonsoft.Json.JsonConvert.DeserializeObject<AccountFarm>(response.Content);
                    var lblEnergy = "Energy : " + Farm.rows[0].energy.ToString() + "/" + Farm.rows[0].max_energy.ToString();

                    foreach (var item in Farm.rows[0].balances)
                    {
                        var type = item.Substring(item.Length - 4, 4);
                        if (type == "GOLD")
                        {
                            lblGold = "GOLD : " + item.Replace("GOLD", "");
                        }
                        else if (type == "WOOD")
                        {
                            lblWood = "WOOD : " + item.Replace("WOOD", "");
                        }
                        else if (type == "FOOD")
                        {
                            lblFood = "FOOD : " + item.Replace("FOOD", "");
                        }
                    }

                    this.form.ConfigWallet(lblEnergy, lblGold, lblFood, lblWood);

                    if (Farm.rows[0].energy < 250)
                    {
                        var EnergyFood = Math.Floor(Convert.ToDouble(lblFood.Replace("FOOD : ", "").ToString().Trim()));

                        if (EnergyFood > 0)
                        {
                            var Total = EnergyFood * 5;

                            var RemainSum = Farm.rows[0].max_energy - Farm.rows[0].energy;

                            //Transaction.Energy energy = new Transaction.Energy(); 

                            if (Total > RemainSum)
                            {
                                await energy.EATFOOD(Convert.ToInt32(RemainSum));
                            }
                            else
                            {
                                await energy.EATFOOD(Convert.ToInt32(Total));
                            }

                        }
                        else
                        {
                            this.form.Message("NO FOOD !!");
                        }


                    }

                }




            }
            catch (Exception)
            {


            }

        }

        public async Task GetBagAccountToLine()
        {
            var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                code = "farmersworld",
                index_position = 1,
                json = true,
                key_type = "i64",
                limit = "100",
                lower_bound = LoginWax.ACCOUNT,
                reverse = false,
                scope = "farmersworld",
                show_payer = false,
                table = "accounts",
                upper_bound = LoginWax.ACCOUNT,
            });
            var response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var Farm = Newtonsoft.Json.JsonConvert.DeserializeObject<AccountFarm>(response.Content);
                var Msg = LoginWax.ACCOUNT + "\n";
                foreach (var item in Farm.rows[0].balances)
                {
                    var type = item.Substring(item.Length - 4, 4);
                    if (type == "GOLD")
                    {
                        Msg += item + "\n";
                    }
                    else if (type == "WOOD")
                    {
                        Msg += item + "\n";
                    }
                    else if (type == "FOOD")
                    {
                        Msg += item + "\n";
                    }
                }

                lineNotify(Msg);
            }
        }

        public async Task GetNexToolstMine(int IndexRow, string AssetId)
        {
            var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                code = "farmersworld",
                index_position = 2,
                json = true,
                key_type = "i64",
                limit = "100",
                lower_bound = LoginWax.ACCOUNT,
                reverse = false,
                scope = "farmersworld",
                show_payer = false,
                table = "tools",
                upper_bound = LoginWax.ACCOUNT,
            });
            var response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var Tools = Newtonsoft.Json.JsonConvert.DeserializeObject<ToolsFarm>(response.Content);

                foreach (var item in Tools.rows.Where(x => x.asset_id == AssetId))
                {

                    var stime = UnixTimeStampToDateTime(item.next_availability);
                    var TimeMine = (stime - DateTime.Now).TotalSeconds;
                    var ms_until_mine = Convert.ToInt32(TimeMine);
                    if (ms_until_mine < 0)
                    {
                        ms_until_mine = 0;
                    }


                    var Column3 = ms_until_mine;
                    var Column4 = item.current_durability + "/" + item.durability;
                    var Column5 = "Next " + DateTime.Now.AddSeconds(ms_until_mine).ToString("dd-MM-yyy HH:mm:ss");

                    this.form.UpdateGrid("", "", Column3.ToString(), Column4, Column5, "", IndexRow);

                }

            }
        }

        public async Task GetNextMineMember(int IndexRow, string AssetId)
        {
            var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                code = "farmersworld",
                index_position = 2,
                json = true,
                key_type = "i64",
                limit = "100",
                lower_bound = LoginWax.ACCOUNT,
                reverse = false,
                scope = "farmersworld",
                show_payer = false,
                table = "mbs",
                upper_bound = LoginWax.ACCOUNT,
            });
            var response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var Tools = Newtonsoft.Json.JsonConvert.DeserializeObject<ToolsFarm>(response.Content);

                foreach (var item in Tools.rows.Where(x => x.asset_id == AssetId))
                {

                    var stime = UnixTimeStampToDateTime(item.next_availability);
                    var TimeMine = (stime - DateTime.Now).TotalSeconds;
                    var ms_until_mine = Convert.ToInt32(TimeMine);
                    if (ms_until_mine < 0)
                    {
                        ms_until_mine = 0;
                    }


                    var Column3 = ms_until_mine;
                    var Column5 = "Next " + DateTime.Now.AddSeconds(ms_until_mine).ToString("dd-MM-yyy HH:mm:ss");


                    this.form.UpdateGrid("", "", Column3.ToString(), "", Column5, "", IndexRow);
                }

            }
        }

        public async Task GetNextMineAnimals(int IndexRow, string AssetId)
        {
            var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                code = "farmersworld",
                index_position = 2,
                json = true,
                key_type = "i64",
                limit = "100",
                lower_bound = LoginWax.ACCOUNT,
                reverse = false,
                scope = "farmersworld",
                show_payer = false,
                table = "animals",
                upper_bound = LoginWax.ACCOUNT,
            });
            var response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var Tools = Newtonsoft.Json.JsonConvert.DeserializeObject<ToolsFarm>(response.Content);

                foreach (var item in Tools.rows.Where(x => x.asset_id == AssetId))
                {

                    var stime = UnixTimeStampToDateTime(item.next_availability);
                    var TimeMine = (stime - DateTime.Now).TotalSeconds;
                    var ms_until_mine = Convert.ToInt32(TimeMine);
                    if (ms_until_mine < 0)
                    {
                        ms_until_mine = 0;
                    }


                    var Column3 = ms_until_mine;
                    var Column5 = "Next " + DateTime.Now.AddSeconds(ms_until_mine).ToString("dd-MM-yyy HH:mm:ss");


                    this.form.UpdateGrid("", "", Column3.ToString(), "", Column5, "", IndexRow);
                }

            }
        }

        public async Task GetNextMineCrops(int IndexRow, string AssetId)
        {
            var client = new RestClient("https://wax.pink.gg/v1/chain/get_table_rows");
            client.Timeout = 10000;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Referer", "https://play.farmersworld.io/");
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                code = "farmersworld",
                index_position = 2,
                json = true,
                key_type = "i64",
                limit = "100",
                lower_bound = LoginWax.ACCOUNT,
                reverse = false,
                scope = "farmersworld",
                show_payer = false,
                table = "crops",
                upper_bound = LoginWax.ACCOUNT,
            });
            var response = await client.ExecuteAsync(request);
            client.Timeout = 10000;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var farmCrops = Newtonsoft.Json.JsonConvert.DeserializeObject<FarmCrops>(response.Content);
                var checkClaim = false;
                foreach (var item in farmCrops.rows.Where(x => x.asset_id == AssetId))
                {

                    var stime = UnixTimeStampToDateTime(item.next_availability);
                    var TimeMine = (stime - DateTime.Now).TotalSeconds;
                    var ms_until_mine = Convert.ToInt32(TimeMine);
                    if (ms_until_mine < 0)
                    {
                        ms_until_mine = 0;
                    }

                    var Column3 = ms_until_mine;
                    var Column4 = item.times_claimed + "/42";
                    var Column5 = "Next " + DateTime.Now.AddSeconds(ms_until_mine).ToString("dd-MM-yyy HH:mm:ss");
                    checkClaim = true;
                    this.form.UpdateGrid("", "", Column3.ToString(), Column4, Column5, "", IndexRow);
                }

                if (checkClaim == false)
                {
                    // ปลูกข้าว
                    var Column1 = 0;
                    var Column3 = 86400;
                    var Column6 = "ClaimSuccess!";
                    this.form.UpdateGrid(Column1.ToString(), "", Column3.ToString(), "", "", Column6, IndexRow);
                }

            }
        }


        void lineNotify(string msg)
        {
            try
            {
                if (Globals.TOKEN_LINE != "")
                {
                    var request = (HttpWebRequest)WebRequest.Create("https://notify-api.line.me/api/notify");
                    var postData = string.Format("message={0}", LoginWax.ACCOUNT + "\n" + msg);
                    var data = Encoding.UTF8.GetBytes(postData);

                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = data.Length;
                    request.Headers.Add("Authorization", "Bearer " + Globals.TOKEN_LINE);

                    using (var stream = request.GetRequestStream()) stream.Write(data, 0, data.Length);
                    var response = (HttpWebResponse)request.GetResponse();
                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


    }
}
