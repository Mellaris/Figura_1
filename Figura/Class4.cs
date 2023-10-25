using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura
{
    internal class Treygolnik : Prumoygolnik
    {
        private int c;
        public void Info()
        {
            Console.WriteLine("Введите стороны треугольник: ");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a + b > c && c + b > a && c + a > b)
            {
                if (a * a == b * b + c * c || c * c == a * a + b * b || b * b == a * a + c * c)
                {
                    Console.WriteLine("Ваш треугольник прямоугольный");
                }
                if ( a == b && c == b && a == c )
                {
                    Console.WriteLine("Ваш треугольник р/с");
                }
                else if ( a == b || c == b || c == a )
                {
                    Console.WriteLine("Ваш треугольник р/б");
                }
                Per();
                Plo(); 
            }
            else { Console.WriteLine("Такого треугольника не существует"); } 
        }
        public override void Per()
        {
            P = a + b + c;
            Console.WriteLine($"Периметр вашего треугольника: {P}");
        }
        public override void Plo()
        {
            S = P * (P - a) * (P - b) * (P - c);
            S = Math.Sqrt(S);
            Console.WriteLine($"Площадь вашего треугольника: {S}");
        }
    }
}