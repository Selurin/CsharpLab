using System;
class Program
{
    static void Main(string[] args)
    {
        string? choise = "";
        while (choise != "0")
        {
            Console.WriteLine("\nКакую задачу решить?");
            Console.WriteLine("1.1 - Дробная часть числа");
            Console.WriteLine("0 - Выход");
            Console.Write("Введите номер задачи: ");

            choise = Console.ReadLine();

            if (choise == "1.1")
            {
                Console.Write("Введите x: ");
                string? userWrite = Console.ReadLine();
                bool isSuccess = double.TryParse(userWrite, out double parseUserWrite);
                if (isSuccess)
                {
                    double result = TaskSolver.fraction(parseUserWrite); //Вызываем метод из другого файла.класса
                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("Неверное значение!");
                }
            }

            else if (choise =="0")
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
