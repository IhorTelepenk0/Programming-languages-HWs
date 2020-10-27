using System;
using System.Collections.Generic;
using System.Threading;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tuple<double, double, int, double, double> results = ByList();
            Tuple<double, double, int, double, double> results = WithoutCollections();
            Console.WriteLine($"min = {results.Item1}, max = {results.Item2}, the count = {results.Item3}, the sum = {results.Item4}, the average = {results.Item5} ");

        }

        static Tuple<double,double,int,double,double> ByList()
        {
            List<double> theNumbers = new List<double>();

            double el = 0;
            string strel;
            double min, max, aver, sum = 0;
            int count = 0;

            Console.WriteLine("enter the element: ");
            strel = Console.ReadLine();

            while (strel != "")
            {
                el = Convert.ToDouble(strel);
                theNumbers.Add(el);
                count++;
                Console.WriteLine("enter the element: ");
                strel = Console.ReadLine();
                
            }

            
            min = theNumbers[0];
            max = theNumbers[0];
            for(int i=0;i<count;i++)
            {
                if (theNumbers[i] > max)
                    max = theNumbers[i];
                if (theNumbers[i] < min)
                    min = theNumbers[i];
                sum += theNumbers[i];
            }

            aver = sum / count;

            return new Tuple<double, double, int, double, double>(min, max, count, sum, aver);

        }

        static Tuple<double, double, int, double, double> WithoutCollections()
        {
            
            double el = 0;
            string strel;
            double min, max, aver, sum = 0;
            int count = 0;

            Console.WriteLine("enter the element: ");
            strel = Console.ReadLine();
            min = Convert.ToDouble(strel);
            max = Convert.ToDouble(strel);

            while (strel != "")
            {
                el = Convert.ToDouble(strel);
                if (max < el)
                    max = el;
                if (min > el)
                    min = el;
                sum += el;
                count++;
                Console.WriteLine("enter the element: ");
                strel = Console.ReadLine();

            }


            aver = sum / count;

            return new Tuple<double, double, int, double, double>(min, max, count, sum, aver);

        }

    }
}
