using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Лабораторная_работа_4._1
{
    internal class Program
    {
        public static Random random = new Random();
        public static List<Monsters> dog = new List<Monsters>();
        public static List<Monsters> hedgehog = new List<Monsters>();

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            for (int i = 0; i < 20; i++)
            {
                Monsters dog1 = new Dog();
                int X = random.Next(75);
                int weight = random.Next(100);
                dog1.BeBorn(X, 1, weight);
                if (dog1.weigh >= 55) Console.ForegroundColor = ConsoleColor.Magenta;
                else Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(dog1.X, dog1.Y);
                dog1.Move();
                Console.ForegroundColor = ConsoleColor.Black;
                dog.Add(dog1);
                Thread.Sleep(0);
            }

            for (int i = 0; i < 20; i++)
            {
                Monsters hed = new Hedgehog();
                int X = random.Next(75);
                int weight = random.Next(100);
                hed.BeBorn(X, 1, weight);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(hed.X, hed.Y);
                hed.Move();
                Console.ForegroundColor = ConsoleColor.Black;
                hedgehog.Add(hed);
                Thread.Sleep(0);
            }

            while (true)
            {
                foreach (var d in dog)
                {
                    Console.SetCursorPosition(d.X, d.Y);
                    if (random.Next(2) == 0)
                    {
                        d.Y += 1;
                        Console.SetCursorPosition(d.X, d.Y + 10);
                        Console.Write(" ");

                        if (d.Y > 20)
                        {
                            d.Y = 1;
                        }

                    }
                    if (d.weigh >= 55) Console.ForegroundColor = ConsoleColor.Magenta;
                    else Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(d.X, d.Y);
                    d.Move();
                    Console.ForegroundColor = ConsoleColor.Black;
                    if (d.Y > 10)
                    {
                        Console.SetCursorPosition(d.X, d.Y - 10);
                        Console.Write(" ");
                    }

                    Thread.Sleep(0);
                }
                foreach (var h in hedgehog)
                {
                    Console.SetCursorPosition(h.X, h.Y);
                    if (random.Next(2) == 0)
                    {
                        h.Y += 1;
                        Console.SetCursorPosition(h.X, h.Y + 10);
                        Console.Write(" ");

                        if (h.Y > 20)
                        {
                            h.Y = 1;
                        }

                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.SetCursorPosition(h.X, h.Y);
                    h.Move();
                    Console.ForegroundColor = ConsoleColor.Black;
                    if (h.Y > 10)
                    {
                        Console.SetCursorPosition(h.X, h.Y - 10);
                        Console.Write(" ");
                    }

                    Thread.Sleep(0);
                }
            }
        }
    }
}
