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


            string translateWorld = Console.ReadLine();

            switch (translateWorld)
            {
                case "bad": Console.WriteLine("bad2");
                    break;
                
                case "good":
                    Console.WriteLine("good2");
                    break;
                default:
                    Console.WriteLine("i do not know");
                    break;

            }


            string operand1, operand2, operationFunction;
            Console.WriteLine("enter operand1");
            operand1 = Console.ReadLine();
            int operandOne = Int32.Parse(operand1);

            Console.WriteLine("enter operand2");
            operand2 = Console.ReadLine();
            int operandTwo = Int32.Parse(operand2);

            Console.WriteLine("enter operation");
            operationFunction = Console.ReadLine();


            switch (operationFunction)
            {
                case "+" : Console.WriteLine(operandOne + operandTwo);
                    break;
                case "-":
                    Console.WriteLine(operandOne - operandTwo);
                    break;
                case "*":
                    Console.WriteLine(operandOne * operandTwo);
                    break;
                case "/":
                    if (operandTwo > 0)
                    {
                        Console.WriteLine(operandOne/operandTwo);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }





            Console.WriteLine("Введите число:");
            double x = Convert.ToDouble(Console.ReadLine());

            if ((x >= 0) && (x <= 14))
            {
                Console.WriteLine("Число входит в промежуток [0 - 14]");
            }
            else if ((x >= 15) && (x <= 35))
            {
                Console.WriteLine("Число входит в промежуток [15 - 35]");
            }
            else if ((x >= 36) && (x <= 50))
            {
                Console.WriteLine("Число входит в промежуток [36 - 50]");
            }
            else if ((x >= 50) && (x <= 100))
            {
                Console.WriteLine("Число входит в промежуток [50 - 100]");
            }
            else
            {
                Console.WriteLine("Число не входит ни в один из существующих промежутков.");
            }

            Console.ReadKey();
        }
    }
}
