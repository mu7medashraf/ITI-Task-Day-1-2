using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_day_7
{
    internal class Productexample
    {
        public class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        public static object createProduct()
        {
            return new { Name = "Laptop", Price = 15000.0 };
        }
        public static object createproduct2()
        {
            return new { Name = "mobile phone", Price = 7000.0 };
        }
        public static void Run()
        {
            var product = createProduct();

            Console.WriteLine(product); 
        }



    }
}
