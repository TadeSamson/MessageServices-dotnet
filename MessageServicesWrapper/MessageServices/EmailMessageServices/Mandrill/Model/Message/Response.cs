using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill.Model
{
    public class Response
    {
        public string name { get; set; }
        public string _id { get;set;}
        public string status { get; set; }
        public string email { get; set; }
        public string reject_reason { get; set; }
        public string code { get; set; }
        public string message { get; set; }
    }
}
