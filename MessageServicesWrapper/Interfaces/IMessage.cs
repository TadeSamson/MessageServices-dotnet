using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper.Interface
{
    public interface IMessage<T1,T2> where T2:new()
    {
         List<T1> Send(T2 messageInfo);

         Task<List<T1>> SendAsync(T2 messageInfo);
    }
}
