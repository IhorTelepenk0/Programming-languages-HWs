using System;
using System.Collections.Generic;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the length: ");
            n = Convert.ToInt32(Console.ReadLine());
            double aver=0, sum = 0;

            //sum = SumByArray(n);
            sum = SumByList(n);
            Console.WriteLine("The sum of the numbers is: ");
            Console.WriteLine(sum);
           
            aver = sum / n;
            Console.WriteLine("The average is: " + aver);
                      
        }

        static double SumByArray(int n)
        {
            double[] arr = new double[n];
            double sum = 0;
            Console.WriteLine(" enter the numbers: ");
            for (int i=0; i < n; i++)
            {
                arr[i] = Convert.ToDouble(Console.ReadLine());
                sum += arr[i];
            }

            return sum;
        }

        static double SumByList(int n)
        {
            List<double> theList = new List<double>();
            double sum = 0;

            Console.WriteLine(" enter the numbers: ");
            for (int i = 0; i < n; i++)
            {
                theList.Add(Convert.ToDouble(Console.ReadLine()));
                sum += theList[i];
            }

            return sum;
        }
    }
}
