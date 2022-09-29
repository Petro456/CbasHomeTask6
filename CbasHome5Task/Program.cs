using System;

namespace CbasHome5Task
{

    static class Calculator
    {
        static public void Dodavanna(double operand1, double operand2)
        {
            double sum = operand1 + operand2;
            Console.WriteLine("Ваше значення: {0}", sum);
        }
        static public void Vidnimanna(double operand1, double operand2)
        {
            double sum = operand1 - operand2;
            Console.WriteLine("Ваше значення: {0}", sum);
        }
        static public void Mnozhenna(double operand1, double operand2)
        {
            double sum = operand1 * operand2;
            Console.WriteLine("Ваше значення: {0}", sum);
        }
        static public void Dilennaa(double operand1, double operand2)
        {
            double sum = operand1 / operand2;
            Console.WriteLine("Ваше значення: {0}", sum);
        }

    }


    /* Задание 6

        Используя Visual Studio, создайте проект по шаблону Console Application.
    Требуется: Создать статический класс Calculator, с методами для выполнения основных 
    арифметических операций. Написать программу, которая выводит на экран основные арифметические операции. */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброго дня. Ви можите виконати наступнi дiї:");
            Console.WriteLine("Вам потрiбно ввести два числа i знак арифметичної дiї");
            Console.WriteLine("Введiть перше число:");

            double operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть друге число:");
            double operand2 = Convert.ToInt32(Console.ReadLine());
            ERROR1:
            Console.WriteLine("Введiть арифметичний знак (+; -;*;/):");
            char znak = Convert.ToChar(Console.ReadLine());

            switch (znak)
            {
                case '+':
                    {
                        Calculator.Dodavanna(operand1, operand2);
                        break;
                    }
                case '-':
                    {
                        Calculator.Vidnimanna(operand1, operand2);
                        break;
                    }
                case '*':
                    {
                        Calculator.Mnozhenna(operand1, operand2);

                        break;
                    }
                case '/':
                    {
                        Calculator.Dilennaa(operand1, operand2);

                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ви ввели неравильний арифметичний знак. Спробуйте ще раз");
                        goto ERROR1;                        
                    }
            }



            Console.ReadKey();
        }

    }
}
