using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV6RPPOON
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //zadatak 1
            Notebook MyNotebook = new Notebook();

            MyNotebook.AddNote(new Note("Labosi", "Predaj do 23:00!"));
            MyNotebook.AddNote(new Note("Kupovina", "Kupi kruh i mlijeko."));
            MyNotebook.AddNote(new Note("Kitty", "Odvedi psa u šetnju"));
            MyNotebook.AddNote(new Note("Loomen", "Riješi kviz do sutra"));

            Iterator iterator = (Iterator)MyNotebook.GetIterator();

            for (Note note = iterator.First(); iterator.IsDone == false; note = iterator.Next())
            {
                note.Show();
            }
            */

            //zadatak 2

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

        }
    }

}