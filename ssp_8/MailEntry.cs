using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ssp_8
{
    class MailEntry
    {
        public String header { get; set; }
        public String body { get; set; }
        public String filePath { get; set; }
        public List<String> addresses = new List<String>();

        public MailEntry()
        {
            
        }

        public List<String> getAddresses()
        {
            return addresses;
        }

        public void setAddresses(List<String> addresses)
        {
            this.addresses = addresses;
        }

    }
}
