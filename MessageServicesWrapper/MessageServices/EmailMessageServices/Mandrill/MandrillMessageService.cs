using MessageServicesWrapper.Interface;
using MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill
{

    public class MandrillMessageService : IMessageService
    {
        private MandrillMessage message=null;
        public MandrillMessageService(string key) {
            message = new MandrillMessage(key);
        }

        public bool RequiredKey()
        {
            return true;
        }

        public IMessage<Response,MandrillMessageInformation> Message
        {
            get
            {
                return message;
            }
            set
            {
                value = message;
            }
        }

    }
}
