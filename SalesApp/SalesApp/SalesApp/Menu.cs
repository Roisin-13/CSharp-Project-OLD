using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesApp.SalesApp
{
    class Menu
    {
        //---code to link to controller (will need later)
        private Controller controller;

        public Menu(Controller controller)
        {
            this.controller = controller;
        }

        //===========MENU===============//
        //---controlled by a switch statement, works in a test.
        //----(code not added to link with controller yet)
        public void firstMenu()
        {
            Console.WriteLine("Please pick a menu option:");
            Console.WriteLine("1. Data-Entry");
            Console.WriteLine("2. Reports");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Quit");

            bool inMenu = true;
            while (inMenu)
            {
                Console.Write("enter number > ");
                string input = Console.ReadLine();
                var a = int.TryParse(input, out int id);
                if (!a)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                switch (id)
                {
                    case 1:
                        //Console.WriteLine("Data-Entry");
                        controller.Create();
                        break;
                    case 2:

                        Console.WriteLine("Please pick a menu option:");
                        Console.WriteLine("1. list sales by year");
                        Console.WriteLine("2. list sales by month and year");
                        Console.WriteLine("3. list sales by year");
                        Console.WriteLine("4. list sales by month and year");
                        Console.WriteLine("5. Quit");
                        bool inMenu2 = true;
                        while (inMenu2)
                        {
                            Console.Write("enter number > ");
                            string input2 = Console.ReadLine();
                            var a2 = int.TryParse(input2, out int id2);
                            if (!a2)
                            {
                                Console.WriteLine("Invalid Input");
                                continue;
                            }
                            switch (id2)
                            {
                                case 1:
                                    //Console.WriteLine("sales by year");
                                    break;
                                case 2:
                                    //Console.WriteLine("sales by month");
                                    break;
                                case 3:
                                    //Console.WriteLine("sales by year");
                                    break;
                                case 4:
                                    //Console.WriteLine("sales by month");
                                    break;
                                case 5:
                                    inMenu2 = false;
                                    break;

                            }
                        }
                        break;
                    case 3:
                        controller.Delete();
                        break;
                    case 4:
                        inMenu = false;
                        break;
                }

            }
        }











    }
}
