using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostVagrantUpdatesToServer
{
    class Program
    {
        static void Main(string[] args)
        //URLtoFlow, username, password, state
        {

            try
            {
                if (args.Length < 1)
                {
                    Console.WriteLine("URLtoFlow, username, password, state");
                }
                else
                {

                    var URLtoFlow = args.ElementAt(0);
                    var username = args.ElementAt(1);
                    var password = args.ElementAt(2);
                    var state = args.ElementAt(3);
                    
                    var hostname = System.Environment.MachineName;

                    var client = new RestClient(URLtoFlow);

                    var request = new RestRequest(Method.POST);
                    request.AddHeader("Host", client.BaseUrl.Host);
                    request.AddHeader("Content-Type", "application/json");
                    request.AddParameter("undefined", "{  \"userid\": \"" + username + "\",   \"password\": \"" + password + "\", \"outputtype\": \"Json\", \"MovingToState\": \"" + state + "\", \"Hostname\" : \"" + hostname + "\" }", ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                }
            }
            catch (Exception ex2)
            {
                Console.WriteLine(ex2.Message);
                throw;
            }
        }
    }
}
