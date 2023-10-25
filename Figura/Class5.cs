using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Piramidka : Krug
    {
        private int v;
        private int h;
        private int n;
        private float V_2;
        private float V;
        private float S_2;
        private float P_2;
        private float ex;
        public void Info()
        {
            Console.WriteLine("Введите основание вашей пирамиды: 1 - круг, 2 - n-угольная");
            v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту вашей пирамиды: ");
            h = Convert.ToInt32(Console.ReadLine());
            if (v == 1)
            {
                Console.WriteLine("Введите радиус: ");
                r = Convert.ToInt32(Console.ReadLine());
            }
            if (v == 2)
            {
                Console.WriteLine("Введите количество углов: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите длину стороны: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Proverka()
        {
            if ((n > 2 && h > 0 && a > 0) || (r > 0 && h > 0))
            {
                if (v == 1)
                {
                    Vich();
                    Plo();
                    Per();
                    Console.WriteLine($"Периметр пирамиды: {P_2}");
                    Console.WriteLine($"Площадь пирамиды: {S_2}");
                    Console.WriteLine($"Объем пирамиды равен: {V_2}");
                }
                else if (v == 2)
                {
                    Vich();
                    Plo();
                    Per();
                    Console.WriteLine($"Периметр пирамиды: {P}");
                    Console.WriteLine($"Площадь пирамиды: {S}");
                    Console.WriteLine($"Объем пирамиды равен: {V}");
                }
            }
            else
            {
                Console.WriteLine("Не существует");
            }
        }
        private void Vich()
        {
            V = (float)(n * h * Math.Pow(a, 2)) / (float)(12 * Math.Tan(Math.PI / n));
            V_2 = (float)(Math.PI * Math.Pow(r, 2) * h) / 3;
        }
        private float Ex()
        {
            ex = a / (float)(2 * Math.Tan(Math.PI / n));
            return ex;
        }
        public override void Plo()
        {
            S = (float)((a * Ex() * n) / 2) + (float)((a * n * Math.Sqrt(Math.Pow(h, 2) + Math.Pow(Ex(), 2))) / 2);
            S_2 = (float)Math.PI * r * (float)Math.Sqrt(Math.Pow(h, 2) + Math.Pow(r, 2)) + (float)Math.PI * (float)Math.Pow(r, 2);
        }
        public override void Per()
        {
            P = (a * n) + ((float)(Math.Sqrt(Math.Pow(h, 2) + Math.Pow(Ex(), 2))) * n);
            P_2 = (float)(Math.PI * 2 * r);
        }
    }
}