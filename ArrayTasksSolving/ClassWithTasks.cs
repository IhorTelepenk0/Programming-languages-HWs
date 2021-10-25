using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ArrayTasksSolving
{
    class ClassWithTasks
    {

        public static float[] Diagonal1(float[,] matrix, int n)
        {
            float[] res = new float[n];
            int resInd = -1;
            for (int i = 0;i < n; i++)
            {
                    resInd++;
                    res[resInd] = matrix[i,i];
                
            }
        
            return res;
        }

        // works actually the same as Diagonal1 (I am not sure what is the actual difference btw these taks)
        public static float[] Diagonal2(float[,] matrix, int m, int n) 
        {
            float[] res = new float[m];
            int resInd = -1;
            for(int i=0;i<m;i++)
            {
                resInd++;
                res[resInd] = matrix[i, resInd];
            }

            return res;
        }

        

        public static float[,] Triangularize(float[,] matrix, int m, bool ifAbove)
        {
            float[,] res = new float[m, m];

            for(int i=0;i<m;i++)
            {
                for(int j=0;j<m;j++)
                {
                    res[i,j] = matrix[i,j];
                }
            }

            for(int j=0;j<m;j++)
            {
                for(int i=m-1;i>j;i--)
                {   
                    if(ifAbove == false)
                    res[i, j] = 0;

                    if (ifAbove == true)
                        res[j, i] = 0;
                }
            }

            return res;
        }

       /* public enum RowsOrColumns
        {
            rows = 0,
            columns = 1
        }*/

        //task 12
        public static float[] Flatten(float[,] matrix, int m, int n) 
        {
            float[] res = new float[m * n];
            int resInd = -1;

            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    resInd++;
                    res[resInd] = matrix[i,j];
                }
            }

            return res;
        }
    }
}
