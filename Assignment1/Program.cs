using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{

    class Program
    {
        static void Main(string[] args)
        {
            string[,] products =
        {
            {"Laptop", "Electronics", "750.50", "10"},
            {"Smartphone", "Electronics", "500.99", "15"},
            {"Chair", "Furniture", "80.25", "20"},
            {"Table", "Furniture", "150.00", "5"},
            {"Headphones", "Accessories", "30.75", "25"}
        };

            Console.WriteLine("Product Details:");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Name\tCategory\tPrice\tQuantity\tTotal Value");
            Console.WriteLine("--------------------------------------------------------");

            int rows = products.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                string name = products[i, 0];
                string category = products[i, 1];
                double price = Convert.ToDouble(products[i, 2]);
                int quantity = Convert.ToInt32(products[i, 3]);
                double totalValue = CalculateTotalStockValue(price, quantity);

                foreach (string detail in new string[] { name, category, price.ToString(), quantity.ToString() })
                {
                    Console.Write(detail + "\t");
                }
                Console.WriteLine("${0}", totalValue);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static double CalculateTotalStockValue(double price, int quantity)
        {
            return price * quantity;

        }
    }
}
