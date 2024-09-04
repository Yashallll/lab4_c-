using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4._1
{
    public class Helpme
    {
        public static Random random = new Random();
        public static void Position(char sym, int x, int y, ConsoleColor color)
        {
            if (x <= 75 && y <= 26)
            {
                try
                {
                    Console.SetCursorPosition(x, y);
                    var defaultColor = Console.BackgroundColor;
                    Console.ForegroundColor = color;
                    Console.Write(sym);
                    Console.ForegroundColor = defaultColor;
                    Console.SetCursorPosition(0, 0);
                }
                catch (Exception e)
                {
                }
            }
            else if (x >= 76 || y >= 26)
            {
                Position(sym, x - random.Next(1, 75), y - random.Next(1, 25), color);
            }
            else if (x <= 0 || y <= 0)
            {
                Position(sym, x  + random.Next(1, 75), y  + random.Next(1, 25), color);
            }
        }
    }
}
