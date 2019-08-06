using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0304A2Widerstand
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, l, d, k;
            char m;

            Console.Write("Bitte erfassen sie den Durchmesser in mm : ");
            d = double.Parse(Console.ReadLine());
            Console.Write("Bitte erfassen sie die Länge in m        : ");
            l = double.Parse(Console.ReadLine());

            Console.WriteLine("Bitte erfassen sie das Material");
            Console.WriteLine("+-----------+");
            Console.WriteLine("!(S)ilber   !");
            Console.WriteLine("!(K)upfer   !");
            Console.WriteLine("!(A)luminium!");
            Console.WriteLine("!(M)essing  !");
            Console.WriteLine("+-----------+");

            m = char.ToLower(Console.ReadKey().KeyChar);
            
            if (m != 's' && m != 'k' && m != 'a' && m != 'm')
                Console.WriteLine("Nur Eingabe von s, k, a oder m erlaubt!");
            else
            {
                switch (m)
                {
                    case 's':
                        k = 60.6;
                        break;

                    case 'k':
                        k = 56.8;
                        break;

                    case 'a':
                        k = 36.0;
                        break;
                        
                    default:
                        k = 13.3;
                        break;
                }

                R = l / (k * ((Math.PI * Math.Pow(d, 2)) / 4));

                Console.WriteLine("Der Widerstand beträgt {0:F4} Ohm", R);

            }

        }
    }
}
