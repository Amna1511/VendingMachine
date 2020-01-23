using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            
          
            Console.ReadLine();
            do
            {
           

                Console.WriteLine("     Main Menue           ");
                Console.WriteLine("===========================");
                Console.WriteLine("1.Drink Cost:10");
                Console.WriteLine("2.Snacks Cost:30");
                Console.WriteLine("3.Food Cost:30");
                Console.WriteLine("4.Quite");
                Console.WriteLine("1,2,5,10 (Kr) Coins are acceptable only");
                Console.WriteLine("Enter your choice");
                int ch = Int32.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        
                        Product d = new Drink();
                        d.Put();
                        break;
                    case 2:
                        Product s = new Snacks();
                        s.Put();
                        break;
                    case 3:
                        Product f = new Food();
                        f.Put();
                        break;

                    case 4:
                        break;
                }
                Console.WriteLine("You want to order again Y/N");
            }
            while (Console.ReadLine().ToUpper() == "Y");
        //}
        //else
        //{
        //    Console.WriteLine("invalid money");
        //    Console.WriteLine("try again ");

        //    Console.ReadLine();
        //}
    }
        
    }
}
