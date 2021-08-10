using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneConatct
{
    class Program
    {
        class ph
        {
            

            static void Main(string[] args)
            {
                Console.WriteLine(" Console Application For Phone Book");

                Console.WriteLine("------------------------------------------------");
                PhoneBook obj = new PhoneBook();

                string go =" ";
              
                do {
                    Console.WriteLine(" Enter your option");
                    Console.WriteLine(" Select Operation");
                    Console.WriteLine("1: Add Contact");
                    Console.WriteLine("2: Dispaly Contact By Number");
                    Console.WriteLine("3: View All Contact");
                    Console.WriteLine("4: Search For   Contacts   by a given name or character");

                    var  option = Console.ReadLine() ;

                    switch (option)

                    {
                        case "1":
                            Console.WriteLine(" Enter Contact Name");
                            var name = Console.ReadLine();
                            Console.WriteLine(" Enter Contact Number");
                            var number = Console.ReadLine();
                            // new conatct create  so newcontact variable  which should be new contact object
                            var newConatct = new Contact(name, number);
                            // invoke add conatct method
                            obj.AddContact(newConatct);
                            break;

                        case "2":

                            Console.WriteLine("Enter Contact Number to search");
                            var serachnumber = Console.ReadLine();
                            obj.DispalyContact(serachnumber);
                            break;


                            case "3":
                            obj.DispalyAllContact();
                               break;

                            case "4":
                            Console.WriteLine(" Enter the phrase  to search the name");
                            var searchname = Console.ReadLine();
                             obj.DispalyMatchContact(searchname);
                              break;

                        default:
                            Console.WriteLine(" You Enter wrong Option ");
                            break;

                    }        

                    Console.WriteLine("Do You Want To Continue? (Y/N) : ");
                    go = (Console.ReadLine());

                } while (go != "N" && go != "n");


                Console.ReadKey();
            }
        }
    }
}
