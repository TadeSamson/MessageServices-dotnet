using MessageServicesWrapper.Interface;
using MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill.Model;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill
{
    public class MandrillMessage:IMessage<Response,MandrillMessageInformation>
    {

        private  string key;
        private MessageClient client;
        private RestRequest request;
        public MandrillMessage(string key)
        {
            this.key = key;
            client= new MessageClient("http://mandrillapp.com/api/1.0");
            request = new RestRequest();
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("content-type", "application/json");
        }
        public List<Response> Send(MandrillMessageInformation messageInfo)
        {
            messageInfo.key = key;
            if (!string.IsNullOrEmpty(messageInfo.template_name))
                request.Resource = "/messages/send-template";
            else
                request.Resource = "/messages/send";
            request.Method = Method.POST;
            request.AddBody( messageInfo );
            var response =  client.Execute<List<Response>>(request);
            return response;

        }






        public async Task<List<Response>> SendAsync(MandrillMessageInformation messageInfo)
        {
            messageInfo.key = key;
            if (!string.IsNullOrEmpty(messageInfo.template_name))
                request.Resource = "/messages/send-template";
            else
                request.Resource = "/messages/send";
            request.Method = Method.POST;
            request.AddBody(messageInfo);
            var response = await client.ExecuteAsync<List<Response>>(request);
            return response;
        }
    }
}
