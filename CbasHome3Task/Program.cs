using System;

namespace CbasHome3Task

{
    /*Задание 4 

        Используя Visual Studio, создайте проект по шаблону Console Application. 
    Требуется: создать расширяющий метод для целочисленного массива, который сортирует 
    элементы массива по возрастанию.  */
    static class SortMassuv
    {
        static Random random = new Random();
        static public void greatMassuv(this int[] vs)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = random.Next(0, 50);
            }
        }
        static  public void ShowMassuv(this int[] vs)
        {
            for (int i = 0; i < vs.Length; i++)
            {
                Console.Write("*"+ vs[i]);
            }
        }

      static  public void SortMassuv1(this int[] vs)
      {
            for (int i = 0; i < vs.Length; i++)
            {
                for (int j = i + 1; j < vs.Length; j++)
                {
                    if (vs[i] > vs[j])
                    {
                        int value = vs[i];
                        vs[i] = vs[j];
                        vs[j] = value;
                    }
                }
            }
      }        
        
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] massuv = new int[10];

            massuv.greatMassuv();
            massuv.SortMassuv1();
            massuv.ShowMassuv();

           
            Console.ReadKey();
        }
    }
}
