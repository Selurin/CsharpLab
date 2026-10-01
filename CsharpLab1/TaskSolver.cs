using System;

public class TaskSolver
{
    public static double fraction(double x)
    {
        // Считаем обычное "грязное" значение по типу 3,999999 или 0,1203000003
        double dirtyResult = x - (int)x;
        string resultStr = x.ToString();

        //Сначала предполагаем, что знаков нет
        int precision = 0;

        // Разрезаем строку по запятой на две части: [целая часть, дробная часть]
        string[] parts = resultStr.Split(',');
        if (parts.Length > 1)
        {
            //Если частей больше одной (значит была запятая), берем длину хвоста
            precision = parts[1].Length;
        }

        if (precision > 15)
        {
            precision = 15;
        }

        // Округляем по кол-ву длины хвоста изначального числа и приводим к модулю (остаток всегда положительный)
        double cleanResult = Math.Abs(Math.Round(dirtyResult, precision));
        return cleanResult;
    }

    public static int charToNum(char x)
    {
        return x - '0';
    }

    public static bool is2Digits(int x)
    {
        string strX = x.ToString();
        if (strX.Length == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool isInRange(int a, int b, int num)
    {
        if ((a <= num && num <= b) || (b <= num && num <= a))
        {
            return true;
        }
        else
        {
            return false;
        }


    }

    public static bool isEqual(int a, int b, int c)
    {
        if (a == b && b == c && a == c)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public static int abs(int x)
    {
        return Math.Abs(x);
    }

    public static bool is35(int x)
    {
        if ((x % 3 == 0 || x % 5 == 0) && x % 15 != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int max3(int x, int y, int z)
    {

        // Предполагаем, что x — максимум
        int max = x;

        if (y > max)
            max = y;

        if (z > max)
            max = z;

        return max;
    }

    public static int sum2(int x, int y)
    {
        int sum = x + y;

        if (sum >= 10 && sum <= 19)
            return 20;

        return sum;
    }

    public static string day(int x)
    {
        switch (x)
        {
            case 1: return "понедельник";
            case 2: return "вторник";
            case 3: return "среда";
            case 4: return "четверг";
            case 5: return "пятница";
            case 6: return "суббота";
            case 7: return "воскресенье";
            default: return "это не день недели";
        }
    }

    public static String listNums(int x)
    {
        string s = "";
        for (int i = 0; i <= x; i++)
        {
            s = s + i + " ";
        }
        return s;
    }

    public static String chet(int x)
    {
        string s = "";
        for (int i = 0; i <= x; i += 2)
        {
            s = s + i + " ";
        }
        return s;
    }

    public static int numLen(long x)
    {
        // Особый случай: 0 состоит из одной цифры
        if (x == 0)
            return 1;

        int count = 0;

        while (x != 0)
        {
            // Отрезаем последнюю цифру
            x = x / 10;
            count++;
        }

        return count;
    }

    public static void square(int x)
    {
        // Внешний цикл — строки (высота)
        for (int i = 0; i < x; i++)
        {

            // Внутренний цикл — символы в строке (ширина)
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void rightTriangle(int x)
    {
        // Перебираем строки от 1 до x
        for (int i = 1; i <= x; i++)
        {
            //Выводим пробелы для выравнивания вправо
            for (int j = 0; j < x - i; j++)
            {
                Console.Write(" ");
            }

            // Выводим звёздочки (их количество равно номеру строки)
            for (int k = 0; k < i; k++)
            {
                Console.Write("*");
            }
            // Переход на новую строку
            Console.WriteLine();
        }
    }

    public static int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            // Нашли первое вхождение — сразу возвращаем индекс
            if (arr[i] == x)
                return i;
        }

        // Прошли весь массив, ничего не нашли
        return -1;
    }

    public static int maxAbs(int[] arr)
    {
        // Берём первый элемент как текущий максимум
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max))
                max = arr[i];
        }

        return max;
    }

    public static int[] add(int[] arr, int[] ins, int pos)
    {
        // Новый массив = длина arr + длина ins
        int[] result = new int[arr.Length + ins.Length];

        int index = 0; // текущая позиция в result

        // Копируем начало arr (от 0 до pos-1)
        for (int i = 0; i < pos; i++)
        {
            result[index] = arr[i];
            index++;
        }

        // Вставляем весь массив ins
        for (int i = 0; i < ins.Length; i++)
        {
            result[index] = ins[i];
            index++;
        }

        // Копируем хвост arr (от pos до конца)
        for (int i = pos; i < arr.Length; i++)
        {
            result[index] = arr[i];
            index++;
        }

        return result;
    }

    public static int[] reverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }

        return result;
    }

    public static int[] findAll(int[] arr, int x)
    {
        // Временный список для индексов
        List<int> indexes = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            // Добавляем индекс в список
            if (arr[i] == x)
                indexes.Add(i);
        }
        // Превращаем список в массив
        return indexes.ToArray();
    }
}
