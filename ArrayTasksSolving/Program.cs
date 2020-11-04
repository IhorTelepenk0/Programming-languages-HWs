using System;

namespace ArrayTasksSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,m;
            Console.WriteLine("enter the array sizes: ");
            m = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());

            float[,] TwoDimArray = new float[m,n];
            Console.WriteLine("enter the elements of the array: ");
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    TwoDimArray[i, j] = float.Parse(Console.ReadLine()); 
                }
            }

            //float[] diagonal;
            //diagonal = ClassWithTasks.Diagonal1(TwoDimArray, m); //task 8
            //diagonal = ClassWithTasks.Diagonal2(TwoDimArray, m, n); // task 9

            /*Console.WriteLine("the diagonal is: ");
            for(int i=0;i<m;i++)
            {
                Console.WriteLine(diagonal[i] + " "); 
            }*/ // for tasks 8 & 9


            /*bool enum_;
            Console.WriteLine("enter 'true' if you choose the elements above main diagonal or 'false' if under:");
            enum_ = Convert.ToBoolean(Console.ReadLine());
            
            float[,] newMatrix;
            newMatrix = ClassWithTasks.Triangularize(TwoDimArray, m, enum_);
            Console.WriteLine("the new matrix is: ");
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine(newMatrix[i,j]);
                }
            }*/ //for task 11

            float[] arrayFromMatr = new float[m * n];
        
            arrayFromMatr = ClassWithTasks.Flatten(TwoDimArray, m, n);
            Console.WriteLine("the one-dimensional array is: ");

            for(int i=0;i<m*n;i++)
            {
                Console.WriteLine(arrayFromMatr[i]);
            }
        }
    }
}
