using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsoleApp2
{


    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            var collection = new List<Product>();

            for (int i = 0; i < 10; i++) {

                var product = new Product()
                {
                    Name = "Продукт" + i,
                    Energy = rnd.Next(10, 500)
                };

                collection.Add(product);
            }

            var result = from item in collection
                         where item.Energy < 200
                         select item;

            var result2 = collection.Where(item => item.Energy < 200);

            foreach(var item in result2)
            {
                Console.WriteLine(item);
            }

            
        }
    }

    
}
