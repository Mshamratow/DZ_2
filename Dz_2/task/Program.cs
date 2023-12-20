using System;
using System.Threading;

namespace Решение_задач
{
    class Program
    {
        struct Person
        {
            public string name;
            public byte age;
            public string city;
            public int PIN;
            public void dataPrint()
            {
                Console.WriteLine($"Пользователь {name}, {age} лет из города {city} имеет ПИН-код {PIN}");
            }
        }
        struct Student
        {
            public string name;
            public string surname;
            public int id;
            public DateTime birthday;
            public alcoholismCategory alcoholismCategory;
            public int volumeAlcoholConsumed;
        }
        enum alcoholismCategory
        {
            a,
            b,
            c,
            d
        }
        static void Main(string[] args)
        {
            // Задание №1. Программа выводит на экран все типы данных, их максимальные и минимальные значения.
            Console.WriteLine("{0, 108}", "ЗАДАНИЕ №1. ПРОГРАММА ВЫВОДИТ НА ЭКРАН ВСЕ ТИПЫ ДАННЫХ, ИХ МАКСИМАЛЬНЫЕ И МИНИМАЛЬНЫЕ ЗНАЧЕНИЯ\n");

            Console.WriteLine($"byte - максимальное значение: {byte.MaxValue} - минимальное значение: {byte.MinValue} \n" +
                              $"sbyte - максимальное значение: {sbyte.MaxValue} - минимальное значение: {sbyte.MinValue} \n" +
                              $"short - максимальное значение: {short.MaxValue} - минимальное значение: {short.MinValue} \n" +
                              $"ushort - максимальное значение: {ushort.MaxValue} - минимальное значение: {ushort.MinValue} \n" +
                              $"int - максимальное значение: {int.MaxValue} - минимальное значение: {int.MinValue} \n" +
                              $"uint - максимальное значение: {uint.MaxValue} - минимальное значение: {uint.MinValue} \n" +
                              $"long - максимальное значение: {long.MaxValue} - минимальное значение: {long.MinValue} \n" +
                              $"ulong - максимальное значение: {ulong.MaxValue} - минимальное значение: {ulong.MinValue} \n" +
                              $"float - максимальное значение: {float.MaxValue} - минимальное значение: {float.MinValue} \n" +
                              $"double - максимальное значение: {double.MaxValue} - минимальное значение: {double.MinValue} \n" +
                              $"decimal - максимальное значение: {decimal.MaxValue} - минимальное значение: {decimal.MinValue} \n" +
                              $"char - максимальное значение: нет - минимальное значение: нет \n" +
                               "bool - максимальное значение: нет - минимальное значение: нет \n" +
                               "string - максимальное значение: нет - минимальное значение: нет \n" +
                               "object - максимальное значение: нет - минимальное значение: нет");


            // Задание №2. Программа получает от пользователя данные, сохраняет их и выводит на экран.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 101}", "ЗАДАНИЕ №2. ПРОГРАММА ПОЛУЧАЕТ ОТ ПОЛЬЗОВАТЕЛЯ ДАННЫЕ, СОХРАНЯЕТ ИХ И ВЫВОДИТ НА ЭКРАН\n");

            try
            {
                Person newPerson = new Person();

                Console.Write("Введите ваше имя: ");
                newPerson.name = Console.ReadLine();
                Console.Write("Введите ваш возраст (целое число): ");
                newPerson.age = byte.Parse(Console.ReadLine());
                Console.Write("Из какого вы города: ");
                newPerson.city = Console.ReadLine();
                Console.Write("Введите ваш PIN-код: ");
                newPerson.PIN = int.Parse(Console.ReadLine());

                newPerson.dataPrint();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("В поле с возрастом и ПИН-кодом необходимо вводить целые числа!");
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Возраст человека или ПИН-код не могут быть такими большими!");
            }


            // Задание №3. Программа получает строку и заменяет в ней строчные буквы на заглавные, а заглавные на строчные.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 115}", "ЗАДАНИЕ №3. ПРОГРАММА ПОЛУЧАЕТ СТОРКУ И ЗАМЕНЯЕТ В НЕЙ СТРОЧНЫЕ БУКВЫ НА ЗАГЛАВНЫЕ, А ЗАГЛАВНЫЕ НА СТРОЧНЫЕ\n");

            string userString;
            string resultString = "";

            Console.Write("Введите строку, состоящую из заглавных и строчных букв: ");
            userString = Console.ReadLine();

            for (int i = 0; i < userString.Length; i++)
            {
                if (char.IsUpper(userString[i]))
                {
                    resultString += userString[i].ToString().ToLower();
                }
                else
                {
                    resultString += userString[i].ToString().ToUpper();
                }
            }

            Console.WriteLine($"Вы ввели строку: {userString}. Получилась строка: {resultString}");


            // Задание №4. Программа получает строку, подстроку и находит количество вхождений.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,98}", "ЗАДАНИЕ №4. ПРОГРАММА ПОЛУЧАЕТ СТРОКУ, ПОДСТРОКУ И НАХОДИТ КОЛИЧЕСТВО ВХОЖДЕНИЙ\n");

            string subString, reducedString;
            int numberOccurrences = 0;
            int index;

            Console.Write("Введите строку: ");
            userString = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            subString = Console.ReadLine();

            if (userString.Length >= subString.Length)
            {
                reducedString = userString;

                do
                {
                    index = reducedString.IndexOf(subString);
                    if (index != -1)
                    {
                        reducedString = reducedString.Substring(index + 1);
                        numberOccurrences++;
                    }
                }
                while (index != -1);

                Console.WriteLine($"В строке {userString} подстрока {subString} встречается {numberOccurrences} раз");
            }
            else
            {
                Console.WriteLine("Подстрока больше чем строка. Такое невозможно!");
            }


            // Задание №5. Программа определяет сколько бутылок виски беспошлинной торговли нужно будет купить, чтобы экономия по сравнению с обычной средней ценой фактически покрыла расходы на отпуск.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,109}", "ЗАДАНИЕ №5. ПРОГРАММА ОПРЕДЕЛЯЕТ СКОЛЬКО БУТЫЛОК ВИСКИ НУЖНО КУПИТЬ, ЧТОБЫ ПОКРЫТЬ ЦЕНУ НА ОТПУСК\n");

            try
            {
                double normPrice, salePrice, holidayPrice, benefit, numberBottles;

                Console.Write("Введите стандартную цену бутылки виски в рублях: ");
                normPrice = double.Parse(Console.ReadLine());
                Console.Write("Введите скидку в DutyFree (без знака процентов): ");
                salePrice = double.Parse(Console.ReadLine());
                Console.Write("Введите стоимость отпуска в рублях: ");
                holidayPrice = double.Parse(Console.ReadLine());

                benefit = normPrice * (salePrice / 100);
                numberBottles = Math.Floor(holidayPrice / benefit);

                Console.WriteLine($"Вам необходимо купить {numberBottles} бутылок виски");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Вы ввели не числа. Необходимо вводить числа!");
            }


            // Задание №6. Программа воспроизводит разговор Гарри Поттера и дневника Тома Реддла.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,98}", "ЗАДАНИЕ №6. ПРОГРАММА ВОСПРОИЗВОДИТ РАЗГОВОР ГАРРИ ПОТТЕРА И ДНЕВНИКА ТОМА РЕДДЛА\n");

            string userName;

            Console.Write("Поздоровайтесь: ");
            Console.ReadLine();

            Console.Write("Как вас зовут: ");
            userName = Console.ReadLine();
            Console.WriteLine($"Привет, {userName}");

            Console.Write("Спросите, известно ли что-то о тайной комнате: ");
            Console.ReadLine();
            Console.WriteLine("Да");

            Console.Write("Спросите, может ли рассказать: ");
            Console.ReadLine();
            Console.WriteLine("Нет");

            Thread.Sleep(5000);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Но могу показать");
            Console.ResetColor();


            // Задание №7. Программа вычисляет контрольную цифру штрихкода (EAN13).
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,91}", "ЗАДАНИЕ №7. ПРОГРАММА ВЫЧИСЛЯЕТ КОНТРОЛЬНУЮ ЦИФРУ ШТРИХКОДА (EAN13)\n");

            Random randomNum = new Random();
            string barcode = "";
            int evenAmount = 0;
            int oddAmount = 0;
            int result;

            for (int i = 0; i <= 12; i++)
            {
                barcode += randomNum.Next(9);
            }

            for (int i = 1; i < barcode.Length; i += 2)
            {
                evenAmount += int.Parse(barcode[i].ToString());
            }
            for (int i = 0; i < barcode.Length; i += 2)
            {
                oddAmount += int.Parse(barcode[i].ToString());
            }
            evenAmount *= 3;
            result = (10 - ((evenAmount + oddAmount) % 10));

            Console.WriteLine($"Контрольная цифра штрихкода {barcode}: {result}");

            evenAmount = 0;
            oddAmount = 0;
            Console.Write("Введите 12 цифр штрих кода: ");
            barcode = Console.ReadLine();

            for (int i = 1; i < barcode.Length; i += 2)
            {
                evenAmount += int.Parse(barcode[i].ToString());
            }
            for (int i = 0; i < barcode.Length; i += 2)
            {
                oddAmount += int.Parse(barcode[i].ToString());
            }
            evenAmount *= 3;
            result = (10 - ((evenAmount + oddAmount) % 10));

            Console.WriteLine($"Контрольная цифра штрихкода {barcode}: {result}");


            // Задание №8. Программа создает структуру студента и подсчитывает общий объем алкоголя и кто сколько процентов выпил.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0,119}", "ЗАДАНИЕ №8. ПРОГРАММА СОЗДАЕТ СТРУКТУРУ СТУДЕНТА И ПОДСЧИТЫВАЕТ ОБЩИЙ ОБЪЕМ АЛКОГОЛЯ И КТО СКОЛЬКО ПРОЦЕНТОВ ВЫПИЛ\n");

            double overallVolume, percentVasya, percentPeter, percentVania, percentKonstantin, percentSasha;

            Student Vasya = new Student();
            Vasya.name = "Вася";
            Vasya.surname = "Петров";
            Vasya.id = 1234;
            DateTime VasyaBirthday = new DateTime(2001, 10, 3);
            Vasya.birthday = VasyaBirthday;
            alcoholismCategory alcoholismCategoryVasya = alcoholismCategory.a;
            Vasya.alcoholismCategory = alcoholismCategoryVasya;
            Vasya.volumeAlcoholConsumed = 10;

            Student Peter = new Student();
            Peter.name = "Петя";
            Peter.surname = "Иванов";
            Peter.id = 4587;
            DateTime PeterBirthday = new DateTime(2002, 09, 14);
            Peter.birthday = PeterBirthday;
            alcoholismCategory alcoholismCategoryPeter = alcoholismCategory.b;
            Peter.alcoholismCategory = alcoholismCategoryPeter;
            Peter.volumeAlcoholConsumed = 8;

            Student Vania = new Student();
            Vania.name = "Ваня";
            Vania.surname = "Константинов";
            Vania.id = 7820;
            DateTime VaniaBirthday = new DateTime(2000, 12, 27);
            Vania.birthday = VaniaBirthday;
            alcoholismCategory alcoholismCategoryVania = alcoholismCategory.c;
            Vania.alcoholismCategory = alcoholismCategoryVania;
            Vania.volumeAlcoholConsumed = 3;

            Student Konstantin = new Student();
            Konstantin.name = "Костя";
            Konstantin.surname = "Александров";
            Konstantin.id = 0024;
            DateTime KonstantinBirthday = new DateTime(2003, 02, 01);
            Konstantin.birthday = KonstantinBirthday;
            alcoholismCategory alcoholismCategoryKonstantin = alcoholismCategory.d;
            Konstantin.alcoholismCategory = alcoholismCategoryKonstantin;
            Konstantin.volumeAlcoholConsumed = 0;

            Student Sasha = new Student();
            Sasha.name = "Саша";
            Sasha.surname = "Данилов";
            Sasha.id = 9985;
            DateTime SashaBirthday = new DateTime(2005, 06, 24);
            Sasha.birthday = SashaBirthday;
            alcoholismCategory alcoholismCategorySasha = alcoholismCategory.a;
            Sasha.alcoholismCategory = alcoholismCategorySasha;
            Sasha.volumeAlcoholConsumed = 11;

            overallVolume = Peter.volumeAlcoholConsumed + Vasya.volumeAlcoholConsumed + Vania.volumeAlcoholConsumed + Konstantin.volumeAlcoholConsumed + Sasha.volumeAlcoholConsumed;

            percentVasya = (Vasya.volumeAlcoholConsumed / overallVolume) * 100;
            percentVania = (Vania.volumeAlcoholConsumed / overallVolume) * 100;
            percentPeter = (Peter.volumeAlcoholConsumed / overallVolume) * 100;
            percentKonstantin = (Konstantin.volumeAlcoholConsumed / overallVolume) * 100;
            percentSasha = (Sasha.volumeAlcoholConsumed / overallVolume) * 100;

            Console.WriteLine($"Всего студенты выпили: {overallVolume} литра. Вася - {percentVasya}%, Ваня - {percentVania}%, Петя - {percentPeter}%, Костя - {percentKonstantin}%, Саша - {percentSasha}%");
        }
    }
}
