using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MessageServicesWrapper;
using System.Threading.Tasks;
using MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill;
using System.IO;
using RestSharp;
using System.Text.RegularExpressions;
using MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill.Model;

namespace MessageServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageServicesManager manager = new MessageServicesManager();
            MandrillMessageService mandril = (MandrillMessageService)manager.CreateMessageService(MessageServiceType.Mandrill, "vLVQJR8PdCWJB2WJowBcig");
            MandrillMessageInformation messageInfo = new MandrillMessageInformation();
            messageInfo.message.from_email = "postmaster@transcademy.com";
            messageInfo.message.from_name = "transcademy";
            messageInfo.message.subject = "testing...";
            messageInfo.message.to.Add(new ToEmail() { email = "tdontop@yahoo.com", name ="tdontop@yahoo.com" , type = "to" });
            messageInfo.template_name = "Notification";
            messageInfo.template_content.Add(new TemplateContent() { name = "paragraph_one", content = "Testing Testing..." });
            messageInfo.message.global_merge_vars.Add(new Merge() { name = "name", content = messageInfo.message.to[0].name });
            List<Response> responses = mandril.Message.Send(messageInfo);


            //Regex rg = new Regex(@"^[a-z0-9]+(\.[a-z0-9]+)*@[a-z]+(\.[a-z]+)+$");
            //var status= rg.IsMatch("768696shafagsg7696.co.co.uk@gmail");
            Console.ReadLine();

        }
    }
}
