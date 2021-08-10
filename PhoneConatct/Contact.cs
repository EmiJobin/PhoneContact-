using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConatct
{
    class Contact
    {
        // properties- name and phn number

        public string Name { get; set; }
        public string PhnNumber { get; set; }

        // create constructor for this contact class with parametres

        public Contact(string name,string phnnumber)
        {
            this.Name = name;
            this.PhnNumber = phnnumber;
        }

    }
}
