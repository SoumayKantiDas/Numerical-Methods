using System;

namespace Muller_Method
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Enter the value of X0 and X1 and X2");
            double x = Convert.ToDouble(Console.ReadLine());
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double accuracy = 0.000000000;            
            double x3;
            double d1;
            double d2;
            double a;
            double b;
            double c;
            double h1;
            double h2;           
            double Iteration = 1000000000;
           
            double i = 0;               
                while (true)
                {

                    i = i + 1;
                    if(i== Iteration)
                    {
                        Console.WriteLine("The root can't be found by ");
                        return;
                    }

                h1 = x1 - x;
                h2 = x2 - x1;
                d1 = (Function(x1) - Function(x)) / h1;
                d2 = (Function(x2) - Function(x1)) / h2;
                a = (d2 - d1) / (h2 + h1);
                b = a * h2 + d2;
                c = Function(x2);
                x3 = x2 + ((-2 * c) /( b+ (b / Math.Abs(b)) * (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) );
                double Ea = (Math.Abs((x3-x2)/x3)*100);
                    Console.WriteLine("Value of X3: {0}", x3);
                    Console.WriteLine("Error Percentage: {0}", Ea);
                    if (Ea <= accuracy)
                    {
                        Console.WriteLine("Root is: {0}", x3);
                        break;
                    }

                    else
                    {
                    x = x1;
                    x1 = x2;
                    x2 = x3;
                     
                    }

                }
    

        }
        static double Function(double x)
        {
            return x * x * x - x - 1;
        }

    }
}
