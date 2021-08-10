using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConatct
{
    // this class phonebook is responsible for mangaing the contact list:
    class PhoneBook
    {
        // properties to store contact information - that should be private:_ contacts to indicate this is a private field

        private List<Contact> mainconatct { get; set; } = new List<Contact>();// to avoid execption


        // opertations-1.Addcontact method

        public void AddContact( Contact contactcoming)// contactcoming object as argument
        {
            // add the incoming contact to the  contact list that we have in the phonebook class

            mainconatct.Add(contactcoming);
        }
        // dispaly conatct by the number- accept number as parameter  and dispaly the contact details 
        public void DispalyContact(string number)
        {
            // find matching conatct from our conatct list
            var contactname = mainconatct.FirstOrDefault(c => c.PhnNumber == number);
            // lambda expresion- to find matching contact: for a given conatct c in this case check c.number== number either we got a null value based on tthe number  or a number that matches the conatct list

            if (contactname == null)
            {
                Console.WriteLine(" contact not found");
            }
            else
            {
                Console.WriteLine($"Conatct:{contactname.Name}, PhnNumber is:{contactname.PhnNumber}");
            }
        }

        // dispaly all conatct from phonebook
        public void DispalyAllContact()
        {
            foreach(var item in mainconatct)
            {
                Console.WriteLine($"Contact:{item.Name}, PhnNumber is: {item.PhnNumber}");
            }
        }



        // serach for contact for a given conatct name:- so type a contact name that fetches all the matching conatcts
        //meaning  that is conatct name contain only certain phrase and it is equal to the serchphrase


                public void DispalyMatchContact(string searchphrase )// method take serach phrase as input- it will be a string 
        {
           
            var matchingcontact = mainconatct.Where(c => c.Name.Contains(searchphrase)).ToList();//  Now we have certain fileds of the existing conatct listand get only those conatctswhich conatins the search phrase in their names;

            foreach(var item in matchingcontact)// display every  matchingcontacts
            {
                Console.WriteLine($"Contact: {item.Name} ,PhnNumber is:{item.PhnNumber}");
            }

        }

    }
}
