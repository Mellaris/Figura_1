using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Prumoygolnik : Kvadrat
    {
        protected int b;
        public void Info()
        {
            Console.WriteLine("Введите стороны прямоугольника:");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Per();
            Plo();
        }
        public override void Per()
        {
            P = (a + b) * 2;
            Console.WriteLine($"Периметр равен {P}");
        }
        public override void Plo()
        {
            S = a * b;
            Console.WriteLine($"Площадь равна {S}");
        }
    }
}