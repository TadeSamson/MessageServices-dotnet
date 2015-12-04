using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill.Model
{
    public struct MergeVariable
    {
        public string rcpt { get; set; }
        public List<Merge> vars { get; set; }
    }
}
