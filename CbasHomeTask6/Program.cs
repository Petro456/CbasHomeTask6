using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CbasHomeTask6
{
   static class FindAndReplaceManager
    {
      static  string str { get; set; }

        
       public static void FindNext(string str)
        {
            FileStream book = new FileStream("C:\\............\\book.txt", FileMode.Open);
            StreamReader reader = new StreamReader(book, Encoding.Default);
            List<string> st = new List<string>();
            while (!reader.EndOfStream)
            {
                if (reader.ReadLine().Contains(str))
                {
                    st.Add(reader.ReadLine());

                }
            }
            reader.Close();
            Console.WriteLine(st);
        }
           
   }

    
    class Book 
    {
        
        public void FindNext(string str)
        {
            Console.WriteLine("Поиск строки : " + str);
        }
    }
    /*Задание 2 

        Используя Visual Studio, создайте проект по шаблону Console Application. 
    Требуется: Создать статический класс FindAndReplaceManager с методом void FindNext(string str) 
    для поиска по книге из примера урока 005_Book. При вызове этого метода, 
    производится последовательный поиск строки в книге. */
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("what phrase you want to find?");
        string str = Console.ReadLine();
        FindAndReplaceManager.FindNext(str);
        Console.ReadKey();

        }
    }
}
