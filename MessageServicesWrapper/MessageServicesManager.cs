using MessageServicesWrapper.Interface;
using MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper
{
    public class MessageServicesManager
    {

        /// <summary>
        /// Creates the message service without a provider key
        /// </summary>
        /// <param name="type">The type  of the message service to create from the enum <see cref="MessageServiceType"/></param>
        /// <returns></returns>
        public IMessageService CreateMessageService(MessageServiceType type)
        {
            switch (type)
            {
                case MessageServiceType.Mandrill: return new MandrillMessageService("");
                default: throw new Exception("");
            }
        

        }

        /// <summary>
        /// Creates the message service with a provider key
        /// </summary>
        /// <param name="type">The type  of the message service to create from the enum <see cref="MessageServiceType"/></param>
        /// <param name="key">The providers key</param>
        /// <returns></returns>
        public IMessageService CreateMessageService(MessageServiceType type,string key)
        {
            switch (type)
            {
                case MessageServiceType.Mandrill: return new MandrillMessageService(key);
                default: throw new Exception("");
            }


        }


    }
}
