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
}
