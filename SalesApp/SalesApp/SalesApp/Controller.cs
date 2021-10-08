using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Please enter quantity of pruduct:");
            string quantityInput = Console.ReadLine();
            var quantity = int.Parse(quantityInput);
            Console.WriteLine("Please enter price of product (in pounds and pence):");
            string priceInput = Console.ReadLine();
            var price = double.Parse(priceInput);
            Console.WriteLine("Please enter date product was purchased:");
            string dateInput = Console.ReadLine();
            var date = DateTime.ParseExact(dateInput, "d", null);


            Sale toCreate = new Sale(name, quantity, price, date);
            Sale newSale = services.Create(toCreate);
            Console.WriteLine($"Created new movie {newSale}");

        }
        




        //==============DELETE METHOD===============//
        //-----------delete method is a good idea, might leave this till later

        //public void Delete()
        //{
        //    Console.WriteLine("Please enter ID of sale you want to delete:");
        //    string inputID = Console.ReadLine();
        //    var remID = int.TryParse(inputID, out int id);
        //    if (remID)
        //    {
        //        try
        //        {
        //            services.Delete(id);
        //        }
        //        catch (ItemNotFoundException)
        //        {
        //            Console.WriteLine($"item with id: {id} does not exist");
        //        }

        //    }

        //}






    }
}
