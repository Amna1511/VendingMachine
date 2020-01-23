using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Drink : Product
    {

        List<int> mon = new List<int>();

     
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
                        Console.WriteLine("Welcome to main Menu");
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
                   
                    if (b >= 10)

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
    
        public override void Menu()
        {
            {
                Console.WriteLine("Product Name\t Amount\t");
                Console.WriteLine("1.Cola       \t10\t");
                Console.WriteLine("2.Pepsi       \t10\t");
                Console.WriteLine("3.Fanta       \t10\t");
                Console.WriteLine("1, 2 or 3");
                Choice = Console.ReadLine();
                if (Choice == "1")
                { this.ProductName = "cola"; }
                else if (Choice == "2")
                { this.ProductName = "Pepsi"; }
                else if (Choice == "3")
                { this.ProductName = "Fanta"; }
                this.ProductPrice = 10;
                Console.WriteLine("{0} Price  is {1}kr", ProductName, ProductPrice);
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        //public override void Price()
        //{
        //    Console.WriteLine("small medium or larg");
        //    Choice = Console.ReadLine().ToUpper();
        //    this.ProductName = "CocaCola";
        //    if (Choice == "M")
        //    { this.ProductPrice = 30; }
        //    else if (Choice == "L")
        //    { this.ProductPrice = 40; }
        //    else if (Choice == "S")
        //    { this.ProductPrice = 25; }
        //    Console.WriteLine("{0} Price  is {1}kr", ProductName, ProductPrice);

        //}
    }
}
