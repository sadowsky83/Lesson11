using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        // Структура уравнение 0=kx+b
        static void Main(string[] args)
        {
            Equation equation = new Equation();
            Console.WriteLine("Введите коэффициент k");
            try
            {
                equation.K = (Convert.ToDouble(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(args);
            }
            Console.WriteLine("Введите коэффициент b");
            try
            {
                equation.B = (Convert.ToDouble(Console.ReadLine()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Main(args);
            }
            equation.Root();
        }

        struct Equation
        {
            double k;
            double b;
            public double K
            {
                set
                {
                    k = value;
                }
                get { return k; }
            }
            public double B
            {
                set
                {
                    b = value;
                }
                get { return b; }
            }

            public void Root()
            {
                double x = Math.Round((double)(0 - b) / k, 3);
                Console.WriteLine("Уравнение имеет решение x = {2}", k, b, x);
                Console.ReadKey();
            }
        }
    }
}
