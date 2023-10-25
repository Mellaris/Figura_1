using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Krug : Prumoygolnik
    {
        protected int r;
        private double pi;
        public void Info()
        {
            Console.WriteLine("Введите радиус круга: ");
            Console.Write("r = ");
            r = Convert.ToInt32(Console.ReadLine());
            Per();
            Plo();
        }
        public override void Per()
        {
            pi = 3.14;
            P = 2 * pi * r;
            Console.WriteLine($"Периметр равен {P}");
        }
        public override void Plo()
        {
            pi = 3.14;
            S = pi * r * r;
            Console.WriteLine($"Площадь круга равна {S}");
        }
    }
}