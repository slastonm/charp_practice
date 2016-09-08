using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            double pi =3.141592653;
            Console.WriteLine(pi);
            double eNumber = 2.7182818284590452;
            Console.WriteLine(eNumber);
            string a, b, c;
            a = "\n моя строка 1";
            b = "\t моя строка 2";
            c = "\a моя строка 3";


            int x, y, z;
            x = 10;
            y = 12;
            z = 3;

            x += y - x++ * z;
            Console.WriteLine(x);
            z = --x - y * 5;
            Console.WriteLine(z);
            y /= x + 5 % z;
            Console.WriteLine(y);
            z = x++ + y * 5;
            Console.WriteLine(z);
            x = y - x++ * z;
            Console.WriteLine(x);


            float m, v, j;
            m = 4;
            v = 5;
            j = 4;

            var res = (m + v + j)/33;
            Console.WriteLine(res);

            double radius = 10;
            var radiusMath = radius* Math.Pow(pi, 2);

            double height = 20;

            var volumeMatch = pi*Math.Pow(pi, 2)*radius;
            var areaMatch = 2*pi*radius*(radius + height);
              


            Console.WriteLine(radiusMath);
            Console.WriteLine(volumeMatch);
            Console.WriteLine(areaMatch);



            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
