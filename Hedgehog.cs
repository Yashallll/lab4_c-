using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_работа_4._1
{
    public class Hedgehog : Monsters
    {
        public ConsoleColor mcolor = ConsoleColor.Gray;
        public char mface = '*';
        public ConsoleColor Mcolor
        {
            get => mcolor;
            set => mcolor = value;
        }
        public char Mface
        {
            get => mface;
            set => mface = value;
        }

        public override void BeBorn(int x, int y, int weight)
        {
            (X, Y, weigh) = (x, y, weight);
        }

        public override void Move()
        {
            Console.Write(Mface);
        }
    }
}
