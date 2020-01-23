using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public  class Product
    {
        public int MoneyEntered { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string Choice { get; set; }

        public Product()
        { }
        public Product(string productName, int ProductPrice, string Choice,int Mon)
        {
            this.ProductName = productName;
            this.ProductPrice = ProductPrice;
            this.Choice = Choice;
            this.MoneyEntered = Mon;
        }
        //public virtual void Price()
        //{ 
        //}
        public virtual void Menu()
        {
        }
        public virtual void Put()
            {
        }
   

    }
}
