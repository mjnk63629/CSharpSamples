using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dialog
{
    public class ContactArgs : EventArgs
    {
        public ContactArgs()
        {
            
        }

        public ContactArgs(Contact contact)
        {
            this.Contact = contact;
        }

        public Contact Contact { get; set; }

        //public int Age { get; set; }
    }
}
