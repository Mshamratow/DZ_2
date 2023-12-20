using System;

namespace Тумаков___Лабораторная_работа__2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 2.1. Программа приветствует пользователя по имени.
            Console.WriteLine("{0, 88}", "УПРАЖНЕНИЕ 2.1. ПРОГРАММА ПРИВЕТСТВУЕТ ПОЛЬЗОВАТЕЛЯ ПО ИМЕНИ\n");

            string userName;

            Console.Write("Введите ваше имя: ");
            userName = Console.ReadLine();

            Console.WriteLine("Здравствуйте, " + userName);


            // Упражнение 2.2. Программа получает два числа и делит их.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 85}", "УПРАЖНЕНИЕ 2.2. ПРОГРАММА ПОЛУЧАЕТ ДВА ЧИСЛА И ДЕЛИТ ИХ\n");

            int firstNumber, secondNumber;
            double result;
            bool firstResult, secondResult;

            Console.Write("Введите первое целое число (делимое): ");
            firstResult = int.TryParse(Console.ReadLine(), out firstNumber);
            Console.Write("Введите второе целое число (делитель): ");
            secondResult = int.TryParse(Console.ReadLine(), out secondNumber);

            if (firstResult && secondResult)
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("Деление невозможно. На ноль делить нельзя!");
                }
                else
                {
                    result = (double)firstNumber / secondNumber;
                    Console.WriteLine($"Результатом деления {firstNumber} на {secondNumber} будет {result}");
                }
            }
            else
            {
                Console.WriteLine("Вводить нужно целые числа! Деление невозможно!");
            }


            // Домашнее задание 2.1. Программа получает букву и выводит следующую за ней букву в алфавитном порядке.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 110}", "ДОМАШНЕЕ ЗАДАНИЕ 2.1. ПРОГРАММА ПОЛУЧАЕТ БУКВУ И ВЫВОДИТ СЛЕДУЮЩУЮ ЗА НЕЙ БУКВУ В АЛФАВИТНОМ ПОРЯДКЕ\n");

            try
            {
                int index;
                char userLetter, nextLetter;

                Console.Write("Введите любую букву алфавита русского/английского языка: ");
                userLetter = char.Parse(Console.ReadLine().ToUpper());

                index = (int)userLetter + 1;

                if ((index < 65) || (index > 1072))
                {
                    throw new Exception("Вы ввели не букву из русского/английского алфавита!");
                }

                if ((index == ((int)'Z' + 1)) || (index == ((int)'Я' + 1)))
                {
                    Console.WriteLine($"Вы ввели букву {userLetter}, следующая за ней - A");
                }
                else
                {
                    nextLetter = Convert.ToChar(index);
                    Console.WriteLine($"Вы ввели букву {userLetter}, следующая за ней - {nextLetter}");
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не один символ! Необходимо ввести одну букву русского/английского алфавита!");
            }
            catch (Exception letterException)
            {
                Console.WriteLine(letterException.Message);
            }


            // Домашнее задание 2.2. Программа находит корни квадратного уравнения.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 91}", "ДОМАШНЕЕ ЗАДАНИЕ 2.2. ПРОГРАММА НАХОДИТ КОРНИ КВАДРАТНОГО УРАВНЕНИЯ\n");

            double coefficientA, coefficientB, coefficientC, discriminant, x1, x2, x;

            Console.Write("Введите коэффициент A: ");
            coefficientA = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент B: ");
            coefficientB = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент С: ");
            coefficientC = double.Parse(Console.ReadLine());

            discriminant = (coefficientB * coefficientB) - (4 * coefficientA * coefficientC);

            if (discriminant > 0)
            {
                x1 = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
                x2 = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
                Console.WriteLine("Первый корень: " + x1);
                Console.WriteLine("Второй корень: " + x2);
            }
            else if (discriminant == 0)
            {
                x = (-coefficientB) / (2 * coefficientA);
                Console.WriteLine("Единственный корень: " + x);
            }
            else
            {
                Console.WriteLine("Дискриминант меньше нуля. Корней нет.");
            }
        }
    }
}
