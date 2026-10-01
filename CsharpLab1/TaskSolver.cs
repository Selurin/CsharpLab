using System;

public class TaskSolver
{
    public double fraction(double x)
    {
        double dirtyResult = x - (int)x;
        string resultStr = x.ToString();

        int precision = 0;

        string[] parts = resultStr.Split(',');
        if (parts.Length > 1)
        {
            precision = parts[1].Length;
        }

        if (precision > 15)
        {
            precision = 15;
        }

        double cleanResult = Math.Abs(Math.Round(dirtyResult, precision));
        return cleanResult;
    }

    public int charToNum(char x)
    {
        return x - '0';
    }

    public bool is2Digits(int x)
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

    public bool isInRange(int a, int b, int num)
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

    public bool isEqual(int a, int b, int c)
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

    public int abs(int x)
    {
        return Math.Abs(x);
    }

    public bool is35(int x)
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

    public int max3(int x, int y, int z)
    {

        int max = x;

        if (y > max)
        {
            max = y;
        }

        if (z > max)
        {
            max = z;
        }

        return max;
    }

    public int sum2(int x, int y)
    {
        int sum = x + y;

        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }

        return sum;
    }

    public string day(int x)
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

    public String listNums(int x)
    {
        string s = "";
        for (int i = 0; i <= x; i++)
        {
            s = s + i + " ";
        }
        return s;
    }

    public String chet(int x)
    {
        string s = "";
        for (int i = 0; i <= x; i += 2)
        {
            s = s + i + " ";
        }
        return s;
    }

    public int numLen(long x)
    {
        if (x == 0)
        {
            return 1;
        }

        int count = 0;

        while (x != 0)
        {
            x = x / 10;
            count++;
        }

        return count;
    }

    public void square(int x)
    {
        for (int i = 0; i < x; i++)
        {

            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void rightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 0; j < x - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                return i;
        }

        return -1;
    }

    public int maxAbs(int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > Math.Abs(max))
                max = arr[i];
        }

        return max;
    }

    public int[] add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];

        int index = 0;

        for (int i = 0; i < pos; i++)
        {
            result[index] = arr[i];
            index++;
        }

        for (int i = 0; i < ins.Length; i++)
        {
            result[index] = ins[i];
            index++;
        }

        for (int i = pos; i < arr.Length; i++)
        {
            result[index] = arr[i];
            index++;
        }

        return result;
    }

    public int[] reverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }

        return result;
    }

    public int[] findAll(int[] arr, int x)
    {
        List<int> indexes = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                indexes.Add(i);
        }
        return indexes.ToArray();
    }
}
