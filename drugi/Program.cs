using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6ZD2
{
    class Program
    {
        static void Main(string[] args)
        {
        
           Box ChosenItems = new Box();

           ChosenItems.AddProduct(new Product("Smartwater", 1.99));
           ChosenItems.AddProduct(new Product("Balenciagas", 950));
           ChosenItems.AddProduct(new Product("Sweater", 64.99));
           ChosenItems.AddProduct(new Product("Blanket", 12.49));

           Iterator iterator = (Iterator)ChosenItems.GetIterator();
           for (Product product = iterator.First(); iterator.IsDone == false; product = iterator.Next())
           {
               Console.WriteLine(product.ToString());
           }

           Console.ReadKey();
         }
    }

}
