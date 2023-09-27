int a;
Console.WriteLine("Добро пожаловать!");
do
{
    Console.WriteLine("Выберите программу: ");
    Console.WriteLine("1.Игра \"Угадай число\"\r\n2.Таблица умножения\r\n3.Вывод делителей числа\r\n4.Выйти из программы");
    a = Convert.ToInt32(Console.ReadLine());
    if (a == 1)
    {
        Random rand = new Random();
        int i = rand.Next(101);
        Console.WriteLine("Компьютер загадал число от 0 до 100. Попробуйте отгодать его ");
        int k;
        do
        {
            Console.WriteLine("Введите число:");
            k = Convert.ToInt32(Console.ReadLine());
            if (k < i) Console.WriteLine("Число больше написанного");
            if (k > i) Console.WriteLine("Число меньше написанного");
        } while (k != i);
        if (k == i) Console.WriteLine("Поздравляем! Вы отгадали!");
    }
    if (a == 2)
    {
        int tablisa;
        int[,] tabl = new int[10, 10];
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write((i * j).ToString() + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Таблица умножения");
    }
    if (a == 3)
    {
        Console.Write("Введите число: ");
        int b = int.Parse(Console.ReadLine());
        for (int c = 1; c <= b; c++)
        {
            if (b % c == 0) Console.Write("{0} ", c);
            
        }
    }
     if (a ==4)
    {
        break;
    }
    if (a <= 5)
    {
        Console.WriteLine("Ошибка! Выберите программу из списка");
    }
} while (a != 4);


