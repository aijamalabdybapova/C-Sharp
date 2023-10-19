using System;

namespace Zametka
{
    internal class Program
    {
        static DateTime Time = DateTime.Now;
        static int LeftRight = 0;
        static int Punkty = 2;
        static void Main(string[] args)
        {
            Zametka a = new Zametka()
            {
                Day = 18,
                name = "Сделать дз",
                opisanie = "Описание: Сделать практические по ИТ и БД",
                CreationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 18),
            };
            Zametka.zametki.Add(a);

            Zametka b = new Zametka()
            {
                Day = 18,
                name = "Погулять",
                opisanie = "Описание: Встретиться с друзьями и погулять 2 часа",
                CreationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 18),
            };
            Zametka.zametki.Add(b);

            Zametka c = new Zametka()
            {
                Day =18,
                name = "Тренировка",
                opisanie = "Описание: Приехать в МПТ на нежку на треню",
                CreationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 18),
            };
            Zametka.zametki.Add(c);

            Zametka d = new Zametka()
            {
                Day = 19,
                name = "Утренняя тренировка ",
                opisanie = "Описание: Встать в 6:00 и пойти на улицу на тренировку ",
                CreationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 19),
            };
            Zametka.zametki.Add(d);

            Zametka e = new Zametka()
            {
                Day = 19,
                name = "Курсы",
                opisanie = "Описание: Включить ноут и подключиться к онлайн парам на сайте Python.com",
                CreationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 19),
            };
            Zametka.zametki.Add(e);

            Zametka f = new Zametka()
            {
                Day = 19,
                name = "Встреча с подругой",
                opisanie = "Описание: Встретиться с подругой и поехать в кинотеатр",
                CreationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 19),
            };
            Zametka.zametki.Add(f);

            Zametka g = new Zametka()
            {
                Day = 20,
                name = "Учеба",
                opisanie = "Описание: Поехать в МПТ и отсидеть пары",
                CreationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 20),
            };
            Zametka.zametki.Add(g);

            Zametka h = new Zametka()
            {
                Day = 20,
                name = "Ужин",
                opisanie = "Описание: Приехать домой и приготовить что нибудь вкусненькое на ужин",
                CreationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 20),

            };
            Zametka.zametki.Add(h);

            Zametka i = new Zametka()
            {
                Day = 20,
                name = "Домашка",
                opisanie = "Описание: написать код на шарпе ",
                CreationTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 20),
            };
            Zametka.zametki.Add(i);

            while (true)
            {
                Den();
                Clavisha();
                Strelka();
            }
        }


        private static void Den()
        {
            int Nomer = 0;
            Console.SetCursorPosition(4, 1);
            Console.WriteLine($"Заметки на дату: {Time.AddDays(LeftRight).Day}.{Time.AddDays(LeftRight).Month}.{Time.AddDays(LeftRight).Year}");
            foreach (var element in Zametka.zametki)
            {
                if (element.Day == Time.AddDays(LeftRight).Day)
                {
                    Nomer++;
                    Console.SetCursorPosition(4,Nomer + 1);
                    element.Number = Nomer;
                    Console.Write($"{element.Number}.{element.name}\n");
                }
            }

        }
        private static void Clavisha()
        {
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    LeftRight--;
                    break;
                case ConsoleKey.RightArrow:
                    LeftRight++;

                    break;
                case ConsoleKey.UpArrow:
                    if (Punkty < 3)
                    {
                        Punkty = 2;
                    }
                    else
                    {
                        Punkty--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Punkty > 3)
                    {
                        Punkty = 4;
                    }
                    else
                    {
                        Punkty++;
                    }
                    break;
                case ConsoleKey.Enter:
                    Pometochkka();
                    Console.ReadKey();
                    break;
                case ConsoleKey.Escape:
                    System.Environment.Exit(0);
                    break;
            }
        }

        private static void Pometochkka()
        {
            int Nomer = 0;
            Console.Clear();
            foreach (var element in Zametka.zametki)
            {
                if (element.Day == Time.AddDays(LeftRight).Day)
                {
                    Nomer++;
                    element.Number = Nomer;
                    if (Nomer == Punkty - 1)
                    {
                        Console.Write($"  {element.name}\n");
                        Console.Write($"  {element.opisanie}\n");
                        Console.WriteLine($"  Дата: {element.CreationTime}");
                    }
                }
            }
        }

        private static void Strelka()
        {
            Console.Clear();
            Console.SetCursorPosition(0, Punkty);
            Console.Write("-->");
        }
    }
}