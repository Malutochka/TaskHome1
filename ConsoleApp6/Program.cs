using System;

class HelloWorld {
    public static int Main(string[] args)
    {
        int a = 0;
        if (a == 0)
        {
            Console.WriteLine($"Добро пожаловать в демонстрирующую базовые примеры программирования на с#");
            Console.WriteLine($"Введите любое число");
            int b = Convert.ToInt32(Console.ReadLine());
            while (b != 0)
            {
                b = b * 0;
            }
        }
        else
        {
            Console.WriteLine("Аргумент не равен 0");
        }
        return 1;
    }
}
