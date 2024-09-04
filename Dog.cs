using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Лабораторная_работа_4._1
{
    public class Dog : Monsters
    {
        public ConsoleColor color = ConsoleColor.Yellow;
        public char face = '@';

        public ConsoleColor Color
        {
            get => color;
            set => color = value;
        }
        public char Face
        {
            get => face;
            set => face = value;
        }

        public override void BeBorn(int x, int y, int weight)
        {
            (X, Y, weigh) = (x, y, weight);
        }

        public override void Move()
        {
            Console.Write(face);
        }
    }
}
