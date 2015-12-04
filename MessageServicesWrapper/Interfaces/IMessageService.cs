using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper.Interface
{
    public interface IMessageService
    {
        bool RequiredKey();
       // public IMessage<MessageInformationBase> Message { get; set; }
    }
}
