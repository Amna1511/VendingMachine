using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Food : Product
    {
        readonly List<int> mon = new List<int>();
      
        public override void Put()
        {
            bool value = true;
            do
            {
                int b = 0;
                Console.WriteLine("enter ur money");
                MoneyEntered = int.Parse(Console.ReadLine());
                
                switch (MoneyEntered)
                {
                    case 1:
                        mon.Add(1);
                        Console.WriteLine("Money not enough");
                        break;
                    case 2:
                        mon.Add(2);
                        Console.WriteLine("Money not enough");
                        break;
                    case 5:
                        mon.Add(5);
                        Console.WriteLine("Money not enough");
                        break;
                    case 10:
                        mon.Add(10);
                        Console.WriteLine("Money not enough");
                        break;
                    default:
                        {
                            Console.WriteLine("invalid money");
                            break;
                        }
                }

                foreach (int item in mon)
                {

                    b += item;
                    Console.WriteLine(b);
                  
                    if (b >= 50 )

                    {
                        Menu();
                        if (b <ProductPrice)
                        { Console.WriteLine("money not enough to buy this product");

                        }

                        else
                        {
                            int money = b - ProductPrice;

                            Console.WriteLine("money back:" + money.ToString("N2") + "kr");
                            Console.WriteLine("Product Name\tTotal Amount\t\tRecievedBack");
                            Console.WriteLine(ProductName + "\t\t" + ProductPrice + "\t" + "\t\t" + money.ToString("N2") + "kr");
                            Console.WriteLine("thank you! &  welcome back");
                            value = false;
                            break;
                        }
                    }
                }

            }
            while (value);
        }
        public override void Menu()
       
        {
            {
                Console.WriteLine("Product Name\t Amount\t");
                Console.WriteLine("1.Sendvich\t50\t");
                Console.WriteLine("2.salad   \t50\t");
                Console.WriteLine("3.potatis  \t50\t");
                Console.WriteLine("1, 2 or 3");
                Choice = Console.ReadLine();
                if (Choice == "1")
                { this.ProductName = "Sendvich";
                    this.ProductPrice = 50;
                }
       
                else if (Choice == "2")
                { this.ProductName = "salad";
                    this.ProductPrice = 50;
                }
                else if (Choice == "3")
                { this.ProductName = "potatis";
                    this.ProductPrice = 50;
                }
               
                Console.WriteLine("{0} Price  is {1}kr", ProductName, ProductPrice);
            }
        }
    }
}
