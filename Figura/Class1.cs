using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Kvadrat
    {
        protected int a;
        protected double P;
        protected double S;
        public void Info()
        {
            Console.WriteLine("Введите сторону квадрта:");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Per();
            Plo();
        }
        public virtual void Per()
        {
            P = a * 4;
            Console.WriteLine($"Периметр равен {P}");
        }
        public virtual void Plo()
        {
            S = a * a;
            Console.WriteLine($"Площадь равна {S}");
        }
    }
}