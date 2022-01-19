using AutoMine.GetToken;
using AutoMine.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoMine.LoginWallet
{
    public class Login
    {
        public string username { get; set; }
        public string password { get; set; }
        public string redirectTo { get; set; }

        public Login(string user, string account, string password)
        {
            this.username = user;
            this.password = account;
            this.redirectTo = password;
        }


        public async Task LoginAccount()
        {
            Globals.Login = true;

        Login:
            SessionToken ichallengeToken = new SessionToken();
            TokenModel iToken = new TokenModel();
            try
            {
                if (LoginWax.TOKEN == "")
                {
                    string username = LoginWax.EMAIL;
                    string password = LoginWax.PASSWORD;
                    string redirectTo = "";
                    string url = "https://all-access.wax.io/api/session";
                    var objLogin = new Login(username, password, redirectTo);

                    var client = new RestClient(url);
                    var loginRequest = new RestRequest(Method.POST);
                    loginRequest.AddHeader("Content-type", "application/json");
                    loginRequest.AddJsonBody(objLogin);
                    var responseLogin = client.Execute(loginRequest);


                    if (responseLogin.StatusCode == System.Net.HttpStatusCode.OK)
                    {

                        client.CookieContainer = new System.Net.CookieContainer();
                        var authCookie = responseLogin.Cookies.First(a => a.Name == "token_id");
                        client.CookieContainer.Add(new System.Net.Cookie(authCookie.Name, authCookie.Value, authCookie.Path, authCookie.Domain));

                        var TokenRequest = new RestRequest(Method.GET);
                        var TokenResponse = client.Execute(TokenRequest);
                        if (TokenResponse.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            iToken = Newtonsoft.Json.JsonConvert.DeserializeObject<TokenModel>(TokenResponse.Content);
                            LoginWax.TOKEN = iToken.token;
                        }

                        client = new RestClient("https://public-wax-on.wax.io/wam/users");
                        client.Timeout = 10000;
                        var request = new RestRequest(Method.GET);
                        request.AddHeader("Referer", "https://play.alienworlds.io/");
                        request.AddHeader("x-access-token", iToken.token);
                        var response = await client.ExecuteAsync(request);

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            var _Login = Newtonsoft.Json.JsonConvert.DeserializeObject<LoginView>(response.Content);
                            if (_Login.accountName == null)
                            {
                                LoginWax.TOKEN = "";
                                goto Login;
                            }
                            else
                            {
                                LoginWax.TOKEN = iToken.token;
                                LoginWax.ACCOUNT = _Login.accountName;
                            }
                        }

                    }
                    else
                    {
                        var authenticator = new TwoStepsAuthenticator.TimeAuthenticator();
                        var code = authenticator.GetCode(LoginWax.FAC_PASSWORD);
                        ichallengeToken = Newtonsoft.Json.JsonConvert.DeserializeObject<SessionToken>(responseLogin.Content);
                        client = new RestClient("https://all-access.wax.io/api/session/2fa");
                        client.Timeout = 10000;
                        var _request = new RestRequest(Method.POST);
                        _request.AddHeader("Referer", "https://play.alienworlds.io/");
                        _request.AddJsonBody(
                         new
                         {
                             code = code,
                             token2fa = ichallengeToken.token2fa,
                         });
                        var _response = await client.ExecuteAsync(_request);
                        if (_response.StatusCode == System.Net.HttpStatusCode.OK)
                        {

                            client = new RestClient("https://all-access.wax.io/api/session");
                            client.CookieContainer = new System.Net.CookieContainer();
                            var authCookie = _response.Cookies.First(a => a.Name == "token_id");
                            client.CookieContainer.Add(new System.Net.Cookie(authCookie.Name, authCookie.Value, authCookie.Path, authCookie.Domain));
                            var TokenRequest = new RestRequest(Method.GET);
                            var TokenResponse = client.Execute(TokenRequest);
                            if (TokenResponse.StatusCode == System.Net.HttpStatusCode.OK)
                            {
                                iToken = Newtonsoft.Json.JsonConvert.DeserializeObject<TokenModel>(TokenResponse.Content);
                                LoginWax.TOKEN = iToken.token;
                            }

                        }

                        client = new RestClient("https://public-wax-on.wax.io/wam/users");
                        client.Timeout = 10000;
                        var request = new RestRequest(Method.GET);
                        request.AddHeader("Referer", "https://play.alienworlds.io/");
                        request.AddHeader("x-access-token", iToken.token);
                        var response = await client.ExecuteAsync(request);

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            var _Login = Newtonsoft.Json.JsonConvert.DeserializeObject<LoginView>(response.Content);
                            if (_Login.accountName == null)
                            {
                                LoginWax.TOKEN = "";
                                goto Login;
                            }
                            else
                            {
                                LoginWax.TOKEN = iToken.token;
                                LoginWax.ACCOUNT = _Login.accountName;
                            }
                        }
                    }
                }
                else
                {
                    iToken.token = LoginWax.TOKEN;
                    var client = new RestClient("https://public-wax-on.wax.io/wam/users");
                    client.Timeout = 10000;
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("Referer", "https://play.alienworlds.io/");
                    request.AddHeader("x-access-token", iToken.token);
                    var response = await client.ExecuteAsync(request);

                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var _Login = Newtonsoft.Json.JsonConvert.DeserializeObject<LoginView>(response.Content);
                        if (_Login.accountName == null)
                        {
                            LoginWax.TOKEN = "";
                            goto Login;
                        }
                        else
                        {
                            LoginWax.TOKEN = iToken.token;
                            LoginWax.ACCOUNT = _Login.accountName;
                        }
                    }
                    else
                    {
                        LoginWax.TOKEN = "";
                    }
                }



            }
            catch (Exception ex)
            {


            }

            Globals.Login = false;
        }



    }

}
