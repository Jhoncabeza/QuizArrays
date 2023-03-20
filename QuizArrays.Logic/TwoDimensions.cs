using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizArrays.Logic
{
    public class TwoDimensions
    {
        private readonly int[,] _array;

        public int M { get; set; }
        public int N { get; set; }

        public TwoDimensions(int m, int n)
        {
            M = m;
            N = n;
            _array = new int[m, n];
        }

        public void Fill()
        {
            var random = new Random();
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    _array[i, j] = random.Next(1, 100);
                }
            }
        }

        public OneDimension ToOneDimension()
        {
            var myArrayOneDimension = new OneDimension(M * N);

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    myArrayOneDimension.Add(_array[i, j]);
                }
            }
            return myArrayOneDimension;
        }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += $"{_array[i, j]}\t";
                }
                output += "\n";
            }
            return output;
        }

    }
}
