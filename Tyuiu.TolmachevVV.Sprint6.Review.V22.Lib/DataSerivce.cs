using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.TolmachevVV.Sprint6.Review.V22.Lib
{
    public class DataSerivce
    {
        public int CalculateMatrix(int[,] matrix, int n1, int n2, int R, int K, int L)
        {
            int count = 0;
            bool right = !(n1 >= 0 || n2 <= 0 || R < 0 || K < 0 || L <= 0 || K > L);
            if (!right)
            {
                return -1;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if ((i < K || i > L) && matrix[R, i] > 0)
                {
                    count++;
                }
            }
            return count;
        }
        public int[,] GetMatrix(int n1, int n2, int N, int M)
        {
            //bool right = !(n1 >= 0 || n2 <= 0 || N <= 0 || M <= 0);
            Random rng = new Random();
            int[,] matrix = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (j % 2 == 0)
                    {
                        matrix[i, j] = rng.Next(1, n2);
                    }
                    else
                    {
                        matrix[i, j] = rng.Next(n1, -1);
                    }
                }
            }
            return matrix;
        }
    }
}
