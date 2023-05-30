namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 4, 5, 2, 6, 4, 3 };
            int[] numbers2 = { 7, 4, 2, 76, 45, 65 };

            Difference(numbers1, numbers2);
        }

        static void Difference(int[] arr1, int[] arr2)
        {
            foreach (int i in arr1)
            {
                int a = 0;

                foreach (int j in arr2)
                {
                    
                    if (i == j)
                    {
                        a++;
                    }
                    
                }
                if (a == 0)
                {
                    Console.WriteLine(i);
                }
            }
        } } }