using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper
{
    public  class MessageClient
    {
        RestClient client;
        public  MessageClient(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }
        public  T Execute<T>(RestRequest request) where T : new()
        {
            var response= client.Execute<T>(request);
            MessageClient.ValidateResponse(response.StatusCode);
            return response.Data;
        }

        public async Task<T> ExecuteAsync<T>(RestRequest request) where T : new()
        {
            var response = await client.ExecuteTaskAsync<T>(request);
            return   response.Data;
        }

        public async Task<string> ExecuteAsync(RestRequest request) 
        {
            var response = await client.ExecuteTaskAsync(request);
            return response.Content;
        }

        public  string Execute(RestRequest request)
        {
            var response= client.Execute(request);
            MessageClient.ValidateResponse(response.StatusCode);
            return response.Content;
        }

        public static void ValidateResponse(System.Net.HttpStatusCode code)
        {
            if (code == System.Net.HttpStatusCode.NotAcceptable)
            {
                throw new Exception("request couldn't be handled");
            }
        }
    }
}
