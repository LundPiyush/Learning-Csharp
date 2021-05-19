using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBookConsole
{
    class Contact
    {   
        public Contact(String name, String number)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public string Number { get; set; }

    }
}
