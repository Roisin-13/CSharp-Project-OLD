using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using System.IO;
using SalesApp.Exceptions;

namespace SalesApp.SalesApp
{
    class Controller
    {
        //------linking services with controller
        private readonly Services services;
        public Controller(Services services)
        {
            this.services = services;
        }
        //==============DATA ENTRY METHOD===============//
        public void Create()
        {
            Console.WriteLine("Please enter Product name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter quantity of product:");
            string quantityInput = Console.ReadLine();
            var quantity = int.Parse(quantityInput);
            Console.WriteLine("Please enter price of product (in pounds and pence):");
            string priceInput = Console.ReadLine();
            var price = double.Parse(priceInput);
            Console.WriteLine("Please enter date product was purchased:");
            string dateInput = Console.ReadLine();
            var a = DateTime.TryParse(dateInput, out DateTime date);
            if (!a)
            {
                date = DateTime.Now;
            } else
            {
                date = DateTime.ParseExact(dateInput, "d", null);
            }
 
            Sale toCreate = new Sale(name, quantity, price, date);
            Sale newSale = services.Create(toCreate);
            Console.WriteLine($"Created new sale {newSale}");

        }





        //==============DELETE METHOD===============//

        public void Delete()
        {
            Console.WriteLine("Please enter ID of sale you want to delete:");
            string inputID = Console.ReadLine();
            var remID = int.TryParse(inputID, out int id);
            if (remID)
            {
                try
                {
                    services.Delete(id);
                    Console.WriteLine($"Item with id: {id} deleted");
                }
                catch (ItemNotFoundException)
                {
                    Console.WriteLine($"item with id: {id} does not exist");
                }

            }
           
        }






    }
}
