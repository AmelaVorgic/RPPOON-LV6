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
        }
    }

}