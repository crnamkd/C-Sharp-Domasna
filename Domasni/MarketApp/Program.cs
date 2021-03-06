﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketApp.Classes;

namespace MarketApp
{

    class Program
    {
        static void Main(string[] args)
        {
            Product[] catalog =
            {
                new Product("Leb", 25.00),
                new Product("Mleko", 45.7),
                new Product("Kafe", 37.5),
                new Product("Jajca", 60),
                new Product("Rakija",90),
                new Product("Voda", 25),
                new Product("Vodka", 90)
            };

            Console.WriteLine("Total number of products in catalog is: " + Product.Count());

            var shoppingCart = new Cart();

            shoppingCart.AddItem(catalog[0]);
            shoppingCart.AddItem(catalog[3]);
            shoppingCart.AddItem(catalog[1]);

            shoppingCart.PrintTotalPrice();

            shoppingCart.CheckOut();

            Console.ReadLine();
        }
    }
}
