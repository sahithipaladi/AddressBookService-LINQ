using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AddressBook Service Using LINQ");
            AddressBookManagement management = new AddressBookManagement();

            Console.WriteLine("\n--------------Display DataTable------------");
            management.Display();

            Console.WriteLine("\n---------------DataTable After Editing---------");
            management.EditByName();
            management.Display();

        }
    }
}