using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Pianino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Переключение октав F4 и F5");
            while (true)
            {
                Oktava_choice();
            }
        }

        static void Oktava_choice()
        {
            
                ConsoleKeyInfo oct = Console.ReadKey();
                if (oct.Key == ConsoleKey.F4)
                {
                    Oktava_Four();
                }
                else if (oct.Key == ConsoleKey.F5)
                {
                    Oktava_Five();
                }
            
        }

        private static object Oktava_Four()
        {
            while (true) 
            { 

            int[] Four_Octave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
            
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Q)
                {
                    Console.Beep(Four_Octave[0], 600);
                }
                else if (key == ConsoleKey.W)
                {
                    Console.Beep(Four_Octave[2], 600);
                }
                else if (key == ConsoleKey.E)
                {
                    Console.Beep(Four_Octave[4], 600);
                }
                else if (key == ConsoleKey.R)
                {
                    Console.Beep(Four_Octave[5], 600);
                }
                else if (key == ConsoleKey.T)
                {
                    Console.Beep(Four_Octave[7], 600);
                }
                else if (key == ConsoleKey.Y)
                {
                    Console.Beep(Four_Octave[9], 600);
                }
                else if (key == ConsoleKey.U)
                {
                    Console.Beep(Four_Octave[11], 600);
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.Beep(Four_Octave[1], 600);
                }
                else if (key == ConsoleKey.D3)
                {
                    Console.Beep(Four_Octave[3], 600);
                }
                else if (key == ConsoleKey.D5)
                {
                    Console.Beep(Four_Octave[6], 600);
                }
                else if (key == ConsoleKey.D6)
                {
                    Console.Beep(Four_Octave[8], 600);
                }
                else if (key == ConsoleKey.D7)
                {
                    Console.Beep(Four_Octave[10], 600);
                }
                else if (key == ConsoleKey.F4 || key == ConsoleKey.F5)
                {
                    return Oktava_choice;
                }

            }
        }

        private static object Oktava_Five()
        {
            while (true) 
            { 
             int[] Five_Octave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 988 };
            
                ConsoleKey key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Q)
                {
                    Console.Beep(Five_Octave[0], 600);
                }
                else if (key == ConsoleKey.W)
                {
                    Console.Beep(Five_Octave[2], 600);
                }
                else if (key == ConsoleKey.E)
                {
                    Console.Beep(Five_Octave[4], 600);
                }
                else if (key == ConsoleKey.R)
                {
                    Console.Beep(Five_Octave[5], 600);
                }
                else if (key == ConsoleKey.T)
                {
                    Console.Beep(Five_Octave[7], 600);
                }
                else if (key == ConsoleKey.Y)
                {
                    Console.Beep(Five_Octave[9], 600);
                }
                else if (key == ConsoleKey.U)
                {
                    Console.Beep(Five_Octave[11], 600);
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.Beep(Five_Octave[1], 600);
                }
                else if (key == ConsoleKey.D3)
                {
                    Console.Beep(Five_Octave[3], 600);
                }
                else if (key == ConsoleKey.D5)
                {
                    Console.Beep(Five_Octave[6], 600);
                }
                else if (key == ConsoleKey.D6)
                {
                    Console.Beep(Five_Octave[8], 600);
                }
                else if (key == ConsoleKey.D7)
                {
                    Console.Beep(Five_Octave[10], 600);
                }
                else if (key == ConsoleKey.F4 || key == ConsoleKey.F5)
                {
                    return Oktava_choice;
                }
            }

        }
    }
}


