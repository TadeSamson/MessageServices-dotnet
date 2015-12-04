using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageServicesWrapper.MessageServices.EmailMessageServices.Mandrill.Model
{
    public class Message
    {

        public Message()
        {
            this.to = new List<ToEmail>();
            this.global_merge_vars = new List<Merge>();
            this.merge_vars = new List<MergeVariable>();
            this.tags = new List<string>();
        }
        public string from_email { get; set; }

        public List<ToEmail> to { get; set; }

        public string from_name { get; set; }

        public string subject { get; set; }

        public string text { get; set; }
        public string html { get; set; }

        public List<Merge> global_merge_vars { get; set; }

        public List<MergeVariable> merge_vars { get; set; }

        public List<string> tags { get; set; }
    }
}
