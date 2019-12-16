using System;
using System.Collections.Generic;

namespace LibManagement
{
    class Program
    {
        static void Main(string[] args)
        {


            var libModel = new libModel();
            while (true)
            {
                opdis();
                Console.WriteLine("Select an option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {

                    case 1:
                        Console.WriteLine("ADD BOOK");
                        libModel.addBook();

                        break;
                    case 2:
                        Console.WriteLine("Borrow BOOk: ");
                        libModel.Borrow();
                        break;
                    case 3:
                        Console.WriteLine("Return Book:");
                        libModel.ReturnBook();

                        break;
                    case 4:
                        Console.WriteLine("Show Display:");
                        libModel.Display();
                        break;
                }
            }
        }




            
       







                 
        public static void opdis()
        {
            Console.WriteLine("1: Add Book");
            Console.WriteLine("2: Borrow Book");
            Console.WriteLine("3: Return Book");
            Console.WriteLine("4: Display List");
            
        }




    }
}
