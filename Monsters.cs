using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Лабораторная_работа_4._1
{
    public abstract class Monsters
    {
        public int x;
        public int y;
        public int weigh;
        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }

        public abstract void BeBorn(int x, int y, int weight);//передаем координаты и вес
        public abstract void Move();//перемещаем
    }
}
