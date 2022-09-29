using System;
using System.Collections.Generic;
using static CbasHome2Task.Book;

namespace CbasHome2Task
{
    class Book
    {

        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }

       public class Notes
        {
             string notes { get; set; }

            //List<string> myNotes = new List<string>();



            public Notes(string notes)
            {
                this.notes = notes;
            }
        }
    }
    /* Задание 3 

    Используя Visual Studio, создайте проект по шаблону Console Application. 
    Расширьте пример урока 005_Book, создав в классе Book, вложенный класс Notes, 
    который позволит сохранять заметки читателя.    */
    internal class Program
    {
        static void Main(string[] args)
        {

            //Book book = new Book();
            ///Notes notes = new Notes();
            

            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
