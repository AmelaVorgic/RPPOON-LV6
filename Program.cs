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

            Console.ReadKey();
            */

            /*
            //zadatak 3
        
            CareTaker MycareTaker = new CareTaker();
            ToDoItem toDo = new ToDoItem("Važno", "Ne zaboravi predati zadatke!", new DateTime(2020, 1, 1));
            MycareTaker.AddPreviousState(toDo.StoreState());
            toDo.text = "Još samo jedna vježba!";
            toDo.title = "Update o labosima";
            MycareTaker.AddPreviousState(toDo.StoreState());
            Console.WriteLine(toDo.ToString());
            toDo.RestoreState(MycareTaker.Undo());
            Console.WriteLine(toDo.ToString());
            toDo.RestoreState(careTaker.Undo());
            Console.WriteLine(toDo.ToString());
            toDo.RestoreState(MycareTaker.Redo());
            Console.WriteLine(toDo.ToString());

            Console.ReadKey();
            */

            /*
            //zadatak 4
            BankCareTaker MybankCareTaker = new BankCareTaker();
            BankAccount MyAccount = new BankAccount("Amela", "Vijenac Ivana Mestrovica", 1.750);
            BankMemento memento = new BankMemento(MyAccount);
            MybankCareTaker.PreviousState = memento;
            Console.WriteLine(MybankCareTaker.PreviousState.Balance.ToString());
            MyAccount.UpdateBalance(1.200);
            memento.AddPreviousState(MyAccount);
            MybankCareTaker.PreviousState = memento;
            Console.WriteLine(MybankCareTaker.PreviousState.Balance.ToString());

            Console.ReadKey();
            */

            /*
            //zadatak 6
            StringChecker MyStringChecker = new StringDigitChecker();
            MyStringChecker.SetNext(newStringUpperCaseChecker());
            MyStringChecker.SetNext(newStringLowerCaseChecker());
            MyStringChecker.SetNext(newStringLengthChecker());

            if (MyStringChecker.Check("thisisjustatest"))
            {
                Console.WriteLine("This string is correct. It has passed the test");
            }
            else Console.WriteLine("This string is incorrect. It has failed the test");

            if (MyStringChecker.Check("IWillSurvive."))
            {
                Console.WriteLine("This string is correct. It has passed the test");
            }
            else Console.WriteLine("This string is incorrect. It has failed the test");


            Console.ReadKey();
            */

            //zadatak 7
            /*
            StringChecker MyStringChecker = new StringDigitChecker();
            MyStringChecker.SetNext(newStringUpperCaseChecker());
            MyStringChecker.SetNext(newStringLowerCaseChecker());
            MyStringChecker.SetNext(newStringLengthChecker());

            StringChecker passwordChecker = new PasswordValidator(MyStringChecker);

            if (passwordChecker.Check("thisisjustatest012"))
            {
                Console.WriteLine("This password passed the test. This is now your password");
            }
            else Console.WriteLine("This password is too weak. Please try again.");

            if (passwordChecker.Check("CANIUSETHIS1"))
            {
                Console.WriteLine("This password passed the test. This is now your password");
            }
            else Console.WriteLine("This password is too weak. Please try again.");

            if (passwordChecker.Check("Pa55w0rDD"))
            {
                Console.WriteLine("This password passed the test. This is now your password");
            }
            else Console.WriteLine("This password is too weak. Please try again.");
            Console.ReadKey();
            */
        }
    }

}
