using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Inventory//Hang Ton Kho
    {
        private List<Product> products; // NULL
        public Inventory()
        {
            products = new List<Product>(); //Empty

        }
        public voi Import(Product p)
        {
            System.Console.WriteLine("Enter Product Name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Product Price: ");
            int price = int.Parse(Console.ReadLine());

            Product p = new Product(name, price);
            products.Add(p);


        }
        public void Export()
        {
            System.Console.WriteLine("Enter product ID: ");
            int ID = int.Parse(Console.ReadLine());

            //find product with ID
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ID == ID)
                {
                    products.Remove(products[i]);
                    break;
                }
            }
        }
    }
}