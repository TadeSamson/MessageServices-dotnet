using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill.Model
{
    public class ToEmail
    {
        public string email { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }
}
