namespace QuizArrays.Logic
{
    public class OneDimension
    {
        private readonly int[] _array;
        private int _top;


        public bool isFull => _top == N;

        public bool isEmpty => _top == 0;

        public int N { get; }

        public OneDimension(int n)
        {
            N = n;
            _top = 0;
            _array = new int[n];
        }
        public override string ToString()
        {
            var output = string.Empty;


            for (int i = 0; i < N; i++)
            {

                output += $"{_array[i]}\t";
            }
            return output;
        }

        public void Add(int number)
        {
            if (isFull)
            {
                throw new Exception("The array is full.");
            }

            _array[_top] = number;
            _top++;
        }

    }
}