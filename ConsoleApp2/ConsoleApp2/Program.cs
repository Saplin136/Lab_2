using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
            static void Task1()
            {
                double[] A_array = new double[] { 0.5, 0.75, 1, 1.25 };
                double[] X_array = new double[] { 1, 7, 0.25 };
                for (int i = 0; i < A_array.Length; i++)
                {
                    Console.Write("a" + i + ":  ");
                    for (int j = 0; j < X_array.Length; j++)
                    {
                        Console.Write("y(x" + j + ") = " + ((Math.Sqrt(X_array[j]) + (A_array[i] * Math.Exp(-Math.Pow(X_array[j], 2)))) / (A_array[i] * Math.Pow(X_array[j], 2))) + "  ");
                    }
                    Console.WriteLine("");
                }
            }

            static void Task2()
            {
                double S = 0;
                int i;
                double[] X_array = new double[] { 0.25, -0.33, 0.49, 0.5 };
                double a;
                for (int j = 0; j < X_array.Length; j++)
                {
                    i = 1;
                    a = (2 * X_array[j]);
                    while (Math.Abs(a) >= 0.000001)
                    {
                        a = Math.Round(a, 6);
                        if (i % 2 == 0)
                        {
                            S += -a;
                        }
                        else
                        {
                            S += a;
                        }
                        i++;
                        a = (Math.Pow(2, i) * Math.Pow(X_array[j], i)) / i;
                        
                        //Console.WriteLine(i + "     " + X_array[j] + "     " + Math.Pow(2, i) + "    " + a + "     " + S);
                    }
                    Console.WriteLine("x = " + X_array[j] + '\n' + "S(x) = " + S);
                    S = 0;
                    Console.WriteLine("y(x) = " + Math.Log(1 + 2 * X_array[j]) + '\n');
                }
            }
        }
    }
}
