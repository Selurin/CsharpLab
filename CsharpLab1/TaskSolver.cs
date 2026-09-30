using System;

public class TaskSolver
{
    public static double fraction(double x)
    {
            double dirtyResult = x - (int)x; //считаем обычное "грязное" значение по типу 3,999999 или 0,1203000003
            string resultStr = x.ToString();

            int precision = 0; //сначала предполагаем, что знаков нет

            string[] parts = resultStr.Split(','); //разрезаем строку по запятой на две части: [целая часть, дробная часть]
        if (parts.Length > 1)
            {
                precision = parts[1].Length; //Если частей больше одной(значит была запятая), берем длину хвоста
            }

        if (precision > 15)
            {
                precision = 15;
            }

            double cleanResult = Math.Abs(Math.Round(dirtyResult, precision)); //округляем по кол-ву длины хвоста изначального числа и приводим к модулю (остаток всегда положительный)
            return cleanResult; 
    }

    public static int charToNum(char x)
    {
        return x - '0';
    }

    public static bool is2Digits(int x)
    {
        string strX = x.ToString();
        if (strX.Length==2)
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
            { return false;
        }


    }

    public static bool isEqual(int a, int b, int c)
    {
        if (a == b && b == c && a == c)
        {  
            return true; 
        }

        else { 
            return false; 
        }
    }

    public static int abs(int x)
    {
        return Math.Abs(x);
    }

    public static bool is35(int x)
    {
        if ((x%3==0 || x%5==0) && x%15!=0)
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

        int max = x;          // предполагаем, что x — максимум

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

    public static String pow(int x)
    {
        string s = "";
        for (int i = 0; i <= x; i+=2)
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
            x = x / 10;   // отрезаем последнюю цифру
            count++;        
        }

        return count;
    }

    public static void square(int x)
    {
        for (int i = 0; i < x; i++)        // внешний цикл — строки (высота)
        {
            for (int j = 0; j < x; j++)    // внутренний цикл — символы в строке (ширина)
            {
                Console.Write("*");         
            }
            Console.WriteLine();            
        }
    }

    public static void rightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)           // перебираем строки от 1 до x
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

            Console.WriteLine();               // переход на новую строку
        }
    }

    public static int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                return i;       // нашли первое вхождение — сразу возвращаем индекс
        }

        return -1;              // прошли весь массив, ничего не нашли
    }

    public static int maxAbs(int[] arr)
    {
        int max = arr[0]; // берём первый элемент как текущий максимум

        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max))
                max = arr[i];
        }

        return max;
    }
}
