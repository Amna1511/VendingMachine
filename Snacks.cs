using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Snacks : Product
    {

        List<int> mon = new List<int>();
        public override void Menu()
        {
            {
                Console.WriteLine("Product Name\t Amount\t");
                Console.WriteLine("1:Chips-BBQ      \t 30\t");
                Console.WriteLine("2:Chips-Lays      \t 30\t");
                Console.WriteLine("3:Chips-Salt      \t 30\t");
                Console.WriteLine("1, 2 or 3");
                Choice = Console.ReadLine();
                if (Choice == "1")
                { this.ProductName = "Chips-BBQ"; }
                else if (Choice == "2")
                { this.ProductName = "Chips-Lays "; }
                else if (Choice == "3")
                { this.ProductName = "Chips-Salt"; }
                this.ProductPrice = 30;
                Console.WriteLine("{0} Price  is {1}kr", ProductName, ProductPrice);
            }
        }

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
                  
                    break;
                case 2:
                    mon.Add(2);
                    
                    break;
                case 5:
                    mon.Add(5);
                    
                    break;
                case 10:
                    mon.Add(10);
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
                Console.WriteLine("Total money: {0}",b);

                    if(b<30 )
                    {
                        Console.WriteLine("Money not enough to buy this product Enter more money");
                    }
                    if (b >= 30)

                    {
                        Menu();
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
        while (value);
    }

    }
}
