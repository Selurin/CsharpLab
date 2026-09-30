using System;
class Program
{
    static void Main(string[] args)
    {
        string? choice = "";
        while (choice != "0")
        {
            Console.WriteLine("\nКакую задачу решить?");
            Console.WriteLine("1.1 - Дробная часть числа");
            Console.WriteLine("1.3 - Превратить букву в число");
            Console.WriteLine("1.5 - Двузначное ли число");
            Console.WriteLine("1.7 - Входит ли число в диапазон");
            Console.WriteLine("1.9 - Равны ли все 3 числа");
            Console.WriteLine("2.1 - Модуль числа");
            Console.WriteLine("2.3 - Делится ли на 3, на 5 или на 15 (при делении на 15 = false)");
            Console.WriteLine("2.5 - Тройной максимум");
            Console.WriteLine("2.7 - Двойная сумма");
            Console.WriteLine("2.9 - Вывод дней недели");
            Console.WriteLine("3.1 - Числа подряд");
            Console.WriteLine("3.3 - Четные числа");
            Console.WriteLine("3.5 - Длина числа");
            Console.WriteLine("3.7 - Квадрат");
            Console.WriteLine("3.9 - Правый треугольник");
            Console.WriteLine("4.1 - Поиск первого значения");
            Console.WriteLine("4.3 - Поиск максимального");
            //Console.WriteLine("");
            Console.WriteLine("0 - Выход");
            Console.Write("Введите номер задачи через точку или без: ");

            choice = Console.ReadLine();

            if (choice == "1.1" || choice == "11")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (double.TryParse(userWrite, out double parseUserWrite))
                {
                    double result = TaskSolver.fraction(parseUserWrite);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "1.3" || choice == "13")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (char.TryParse(userWrite, out char parseUserWrite))
                {
                    int result = TaskSolver.charToNum(parseUserWrite);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "1.5" || choice == "15")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (int.TryParse(userWrite, out int parseUserWrite))
                {
                    bool result = TaskSolver.is2Digits(parseUserWrite);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "1.7" || choice == "17")
            {
                Console.Write("Введите a: ");
                string? a = Console.ReadLine();

                Console.Write("Введите b: ");
                string? b = Console.ReadLine();

                Console.Write("Введите num: ");
                string? num = Console.ReadLine();

                if (int.TryParse(a, out int parseA) && int.TryParse(b, out int parseB) && int.TryParse(num, out int parseNum))
                {
                    bool result = TaskSolver.isInRange(parseA, parseB, parseNum);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "1.9" || choice == "19")
            {
                Console.Write("Введите a: ");
                string? a = Console.ReadLine();

                Console.Write("Введите b: ");
                string? b = Console.ReadLine();

                Console.Write("Введите c: ");
                string? c = Console.ReadLine();

                if (int.TryParse(a, out int parseA) && int.TryParse(b, out int parseB) && int.TryParse(c, out int parseC))
                {
                    bool result = TaskSolver.isInRange(parseA, parseB, parseC);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "2.1" || choice == "21")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (int.TryParse(userWrite, out int parseUserWrite))
                {
                    int result = TaskSolver.abs(parseUserWrite);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "2.3" || choice == "23")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (int.TryParse(userWrite, out int parseUserWrite))
                {
                    bool result = TaskSolver.is35(parseUserWrite);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "2.5" || choice == "25")
            {
                Console.Write("Введите x: ");
                string? x = Console.ReadLine();

                Console.Write("Введите y: ");
                string? y = Console.ReadLine();

                Console.Write("Введите z: ");
                string? z = Console.ReadLine();

                if (int.TryParse(x, out int parseX) && int.TryParse(y, out int parseY) && int.TryParse(z, out int parseZ))
                {
                    int result = TaskSolver.max3(parseX, parseY, parseZ);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "2.7" || choice == "27")
            {
                Console.Write("Введите x: ");
                string? x = Console.ReadLine();

                Console.Write("Введите y: ");
                string? y = Console.ReadLine();

                if (int.TryParse(x, out int parseX) && int.TryParse(y, out int parseY))
                {
                    int result = TaskSolver.sum2(parseX, parseY);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "2.9" || choice == "29")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (int.TryParse(userWrite, out int parseUserWrite))
                {
                    string result = TaskSolver.day(parseUserWrite);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "3.1" || choice == "31")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (int.TryParse(userWrite, out int parseUserWrite))
                {
                    string result = TaskSolver.listNums(parseUserWrite);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "3.3" || choice == "33")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (int.TryParse(userWrite, out int parseUserWrite))
                {
                    string result = TaskSolver.pow(parseUserWrite);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "3.5" || choice == "35")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (int.TryParse(userWrite, out int parseUserWrite))
                {
                    int result = TaskSolver.numLen(parseUserWrite);
                    Console.WriteLine($"Результат: {result}");
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "3.7" || choice == "37")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (int.TryParse(userWrite, out int parseUserWrite))
                {
                    Console.WriteLine("Результат:");
                    TaskSolver.square(parseUserWrite);
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "3.9" || choice == "39")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                if (int.TryParse(userWrite, out int parseUserWrite))
                {
                    Console.WriteLine("Результат:");
                    TaskSolver.rightTriangle(parseUserWrite);
                }

                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "4.1" || choice == "41")
            {
                Console.Write("Введите массив чисел через пробел: ");
                string? line = Console.ReadLine();

                Console.Write("Введите число для поиска: ");
                string? numStr = Console.ReadLine();

                // проверяем, что второе число точно введено
                if (line != null && numStr != null && int.TryParse(numStr, out int searchValue))
                {
                    try
                    {
                        // .Split(' ') разбивает строку по пробелам
                        // Select(int.Parse) превращает каждую часть в число
                        // .ToArray() собирает всё в массив
                        int[] arr = line.Split(' ').Select(int.Parse).ToArray();

                        int result = TaskSolver.findFirst(arr, searchValue);

                        Console.WriteLine($"Индекс первого вхождения: {result}");
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка! Вводите только целые числа через пробел.");
                    }
                }
                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choice == "4.3" || choice == "43")
            {
                Console.Write("Введите числа через пробел: ");
                string? line = Console.ReadLine();

                try
                {
                    int[] arr = line!.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

                    int result = TaskSolver.maxAbs(arr);
                    Console.WriteLine($"Результат: {result}");
                }
                catch
                {
                    Console.WriteLine("Ошибка! Введите корректные числа через пробел.");
                }
            }


            else if (choice == "0")
            {
                Console.WriteLine("До свидания!");
            }
            else
            {
                Console.WriteLine("Такой задачи пока нет");
            }

        }
    }
}
