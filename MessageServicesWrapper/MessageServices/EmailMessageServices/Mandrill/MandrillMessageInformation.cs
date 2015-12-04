
using MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill
{
    public class MandrillMessageInformation
    {

        public MandrillMessageInformation()
        {
            this.template_content = new List<TemplateContent>();
            this.message = new Message();
        }

        public string key { get; set; }
        public string  template_name { get; set; }

        public List<TemplateContent> template_content { get; set; } 

        public Message message { get; set; }

        public string send_at { get; set; }
    }
}
