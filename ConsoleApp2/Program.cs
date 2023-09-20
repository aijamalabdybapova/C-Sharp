using System.Numerics;
string value;
Console.WriteLine("Добро пожаловать в калькулятор!");
do
{ 
    Console.Write("Введите 1 число:");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("1.Сложить числа ");
    Console.WriteLine("2.Вычесть первое из второго ");
    Console.WriteLine("3.Перемножить два числа ");
    Console.WriteLine("4.Разделить первое на второе ");
    Console.WriteLine("5.Возвести в степень N первое число ");
    Console.WriteLine("6.Найти квадратный корень из числа ");
    Console.WriteLine("7.Найти 1 процент от числа ");
    Console.WriteLine("8.Найти факториал из числа ");
    Console.WriteLine("9.Выйти из программы");
    Console.Write("Выберите операцию: ");
    int operation = Convert.ToInt32(Console.ReadLine());
    switch (operation)
    {
        case 1:
            Console.Write("Введите 2 число:");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);
            break;
        case 2:
            Console.Write("Введите 2 число:");
            double num2a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 - num2a);
            break;
        case 3:
            Console.Write("Введите 2 число:");
            double num2b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 * num2b);
            break;
        case 4:
            Console.Write("Введите 2 число:");
            double num2c = Convert.ToDouble(Console.ReadLine());
            if (num2c == 0)
                Console.WriteLine("Невозможна операция");
            else
                Console.WriteLine(num1 / num2c);
            break;
        case 5:
            Console.WriteLine("В какую степень возвести? : ");
            double stepen = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(num1 , stepen));
            break;
        case 6:
            Console.WriteLine(Math.Sqrt(num1));
            break;
        case 7:
            Console.WriteLine(num1/100);
            break; 
        case 8:
            int factorial = 1;
            for (int i = 2; i<= num1; i++)
                factorial *= i;
            Console.WriteLine(factorial);
            break; 
        case 9:
            Console.WriteLine("Вы вышли из программы");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Ошибка.Попробуйте снова");
            break;
    }
    Console.ReadLine();
    Console.Write("Вы хотите продолжить?(да/нет): ");
    value = Console.ReadLine();
}
while (value == "да" || value == "Да" || value == "ДА" );

