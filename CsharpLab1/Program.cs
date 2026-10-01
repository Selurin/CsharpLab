using System;

class Program
{
    static void Main()
    {
        string choice;
        do
        {
            PrintMenu();
            Console.Write("Введите номер задачи (например, 1.1 или 11) или 0 для выхода: ");
            choice = Console.ReadLine()?.Trim() ?? "";

            switch (choice)
            {
                case "0":
                    Console.WriteLine("До свидания!");
                    break;

                case "1.1":
                case "11":
                    if (TryReadDouble("Введите x: ", out double x11))
                        Console.WriteLine($"Результат: {TaskSolver.fraction(x11)}");
                    break;

                case "1.3":
                case "13":
                    Console.Write("Введите один символ: ");
                    string? input13 = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input13))
                        Console.WriteLine($"Результат: {TaskSolver.charToNum(input13[0])}");
                    else
                        Console.WriteLine("Неверное значение! Ввод не может быть пустым.");
                    break;

                case "1.5":
                case "15":
                    if (TryReadInt("Введите x: ", out int x15))
                        Console.WriteLine($"Результат: {TaskSolver.is2Digits(x15)}");
                    break;

                case "1.7":
                case "17":
                    if (TryReadInt("Введите a: ", out int a17) &&
                        TryReadInt("Введите b: ", out int b17) &&
                        TryReadInt("Введите num: ", out int num17))
                    {
                        Console.WriteLine($"Результат: {TaskSolver.isInRange(a17, b17, num17)}");
                    }
                    break;

                case "1.9":
                case "19":
                    if (TryReadInt("Введите a: ", out int a19) &&
                        TryReadInt("Введите b: ", out int b19) &&
                        TryReadInt("Введите c: ", out int c19))
                    {
                        Console.WriteLine($"Результат: {TaskSolver.isEqual(a19, b19, c19)}");
                    }
                    break;

                case "2.1":
                case "21":
                    if (TryReadInt("Введите x: ", out int x21))
                        Console.WriteLine($"Результат: {TaskSolver.abs(x21)}");
                    break;

                case "2.3":
                case "23":
                    if (TryReadInt("Введите x: ", out int x23))
                        Console.WriteLine($"Результат: {TaskSolver.is35(x23)}");
                    break;

                case "2.5":
                case "25":
                    if (TryReadInt("Введите x: ", out int x25) &&
                        TryReadInt("Введите y: ", out int y25) &&
                        TryReadInt("Введите z: ", out int z25))
                    {
                        Console.WriteLine($"Результат: {TaskSolver.max3(x25, y25, z25)}");
                    }
                    break;

                case "2.7":
                case "27":
                    if (TryReadInt("Введите x: ", out int x27) &&
                        TryReadInt("Введите y: ", out int y27))
                    {
                        Console.WriteLine($"Результат: {TaskSolver.sum2(x27, y27)}");
                    }
                    break;

                case "2.9":
                case "29":
                    if (TryReadInt("Введите номер дня (1-7): ", out int x29))
                        Console.WriteLine($"Результат: {TaskSolver.day(x29)}");
                    break;

                case "3.1":
                case "31":
                    if (TryReadInt("Введите x: ", out int x31))
                        Console.WriteLine($"Результат: {TaskSolver.listNums(x31)}");
                    break;

                case "3.3":
                case "33":
                    if (TryReadInt("Введите x: ", out int x33))
                        Console.WriteLine($"Результат: {TaskSolver.chet(x33)}");
                    break;

                case "3.5":
                case "35":
                    if (TryReadInt("Введите x: ", out int x35))
                        Console.WriteLine($"Результат: {TaskSolver.numLen(x35)}");
                    break;

                case "3.7":
                case "37":
                    if (TryReadInt("Введите сторону квадрата: ", out int x37))
                    {
                        Console.WriteLine("Результат:");
                        TaskSolver.square(x37);
                    }
                    break;

                case "3.9":
                case "39":
                    if (TryReadInt("Введите высоту треугольника: ", out int x39))
                    {
                        Console.WriteLine("Результат:");
                        TaskSolver.rightTriangle(x39);
                    }
                    break;

                case "4.1":
                case "41":
                    if (TryReadIntArray("Введите массив чисел через пробел: ", out int[] arr41) &&
                        TryReadInt("Введите число для поиска: ", out int search41))
                    {
                        Console.WriteLine($"Индекс первого вхождения: {TaskSolver.findFirst(arr41, search41)}");
                    }
                    break;

                case "4.3":
                case "43":
                    if (TryReadIntArray("Введите числа через пробел: ", out int[] arr43))
                        Console.WriteLine($"Результат: {TaskSolver.maxAbs(arr43)}");
                    break;

                case "4.5":
                case "45":
                    if (TryReadIntArray("Введите основной массив через пробел: ", out int[] arr45) &&
                        TryReadIntArray("Введите вставляемый массив через пробел: ", out int[] ins45) &&
                        TryReadInt("Введите позицию для вставки: ", out int pos45))
                    {
                        int[] result = TaskSolver.add(arr45, ins45, pos45);
                        Console.WriteLine("Результат: [" + string.Join(", ", result) + "]");
                    }
                    break;

                case "4.7":
                case "47":
                    if (TryReadIntArray("Введите массив через пробел: ", out int[] arr47))
                    {
                        int[] result = TaskSolver.reverseBack(arr47);
                        Console.WriteLine("Реверс: [" + string.Join(", ", result) + "]");
                    }
                    break;

                case "4.9":
                case "49":
                    if (TryReadIntArray("Введите массив через пробел: ", out int[] arr49) &&
                        TryReadInt("Введите искомое число: ", out int x49))
                    {
                        int[] result = TaskSolver.findAll(arr49, x49);
                        Console.WriteLine("Индексы: [" + string.Join(", ", result) + "]");
                    }
                    break;

                default:
                    if (choice != "0")
                    {
                        Console.WriteLine("Такой задачи пока нет. Попробуйте еще раз.");
                    }
                    break;
            }
        } while (choice != "0");
    }

    // Вспомогательные методы

    private static void PrintMenu()
    {
        Console.WriteLine("\n--- Меню задач ---");
        Console.WriteLine("1.1 - Дробная часть числа");
        Console.WriteLine("1.3 - Превратить символ цифры в число");
        Console.WriteLine("1.5 - Двузначное ли число");
        Console.WriteLine("1.7 - Входит ли число в диапазон");
        Console.WriteLine("1.9 - Равны ли все 3 числа");
        Console.WriteLine("2.1 - Модуль числа");
        Console.WriteLine("2.3 - Делится на 3 или 5 (но не на 15)");
        Console.WriteLine("2.5 - Тройной максимум");
        Console.WriteLine("2.7 - Двойная сумма (10-19 -> 20)");
        Console.WriteLine("2.9 - Вывод дня недели");
        Console.WriteLine("3.1 - Числа от 0 до N");
        Console.WriteLine("3.3 - Четные числа от 0 до N");
        Console.WriteLine("3.5 - Количество цифр в числе");
        Console.WriteLine("3.7 - Квадрат из '*'");
        Console.WriteLine("3.9 - Правый треугольник из '*'");
        Console.WriteLine("4.1 - Поиск первого вхождения");
        Console.WriteLine("4.3 - Элемент с макс. абсолютным значением");
        Console.WriteLine("4.5 - Вставка одного массива в другой");
        Console.WriteLine("4.7 - Реверс массива");
        Console.WriteLine("4.9 - Все вхождения элемента");
        Console.WriteLine("0 - Выход");
        Console.WriteLine("------------------");
    }

    private static bool TryReadInt(string prompt, out int value)
    {
        Console.Write(prompt);
        if (int.TryParse(Console.ReadLine(), out value))
        {
            return true;
        }
        Console.WriteLine("Неверное значение! Ожидалось целое число.");
        return false;
    }

    private static bool TryReadDouble(string prompt, out double value)
    {
        Console.Write(prompt);
        if (double.TryParse(Console.ReadLine(), out value))
        {
            return true;
        }
        Console.WriteLine("Неверное значение! Ожидалось дробное или целое число.");
        return false;
    }

    private static bool TryReadIntArray(string prompt, out int[] array)
    {
        Console.Write(prompt);
        string? line = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(line))
        {
            array = Array.Empty<int>();
            Console.WriteLine("Неверное значение! Ввод не может быть пустым.");
            return false;
        }

        try
        {
            // RemoveEmptyEntries безопасно обрабатывает случайные двойные пробелы
            array = line.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
            return true;
        }
        catch (FormatException)
        {
            array = Array.Empty<int>();
            Console.WriteLine("Ошибка формата! Вводите только целые числа, разделенные пробелами.");
            return false;
        }
    }
}