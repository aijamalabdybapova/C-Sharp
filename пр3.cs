using System;

namespace piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать!");
            Console.WriteLine("Для смены октавы нажимайте F1,F2,F3");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            int[] first = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int[] second = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] third = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
            int[] Octave;
            Octave = first;
   
            static void sounds(ConsoleKeyInfo key, int[] Octave)
            {
                if (key.Key == ConsoleKey.A)
                {
                    Console.Beep(Octave[0], 300);
                }
                else if (key.Key == ConsoleKey.W)
                {
                    Console.Beep(Octave[1], 300);
                }
                else if (key.Key == ConsoleKey.S)
                {
                    Console.Beep(Octave[2], 400);
                }
                else if (key.Key == ConsoleKey.E)
                {
                    Console.Beep(Octave[3], 200);
                }
                else if (key.Key == ConsoleKey.D)
                {
                    Console.Beep(Octave[4], 100);
                }
                else if (key.Key == ConsoleKey.F)
                {
                    Console.Beep(Octave[5], 500);
                }
                else if (key.Key == ConsoleKey.T)
                {
                    Console.Beep(Octave[6], 200);
                }
                else if (key.Key == ConsoleKey.G)
                {
                    Console.Beep(Octave[7], 300);
                }
                else if (key.Key == ConsoleKey.Y)
                {
                    Console.Beep(Octave[8], 100);
                }
                else if (key.Key == ConsoleKey.H)
                {
                    Console.Beep(Octave[9], 200);
                }
                else if (key.Key == ConsoleKey.U)
                {
                    Console.Beep(Octave[10], 100);
                }
                else if (key.Key == ConsoleKey.J)
                {
                    Console.Beep(Octave[11], 300);
                }
            }
            static void ChangeOctave(ref ConsoleKeyInfo keyInfo, ref int[] Octave)
            {
                int[] first = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                int[] second = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                int[] third = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };

                if (keyInfo.Key == ConsoleKey.F1)
                {
                    Octave = first;
                }
                else if (keyInfo.Key == ConsoleKey.F2)
                {
                    Octave = second;
                }
                else if (keyInfo.Key == ConsoleKey.F3)
                {
                    Octave = third;
                }
            }
        }
    }
}

