using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dialog
{
    public class Contact
    {
        private string _firsttName;
        private string _lastName;
        private string _number;

        public string FirsttName
        {
            get { return _firsttName; }
            set { _firsttName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }
    }
}
