using System;

namespace pasha
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -1, 1 ,2 ,3};
            Sort(array);
            foreach (int ch in array)
                Console.WriteLine(ch + " ");
            Console.ReadLine();

            static void Sort(int[] array)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp = array[i];
                    array[i] = array[array.Length - i - 1];
                    array[array.Length - i - 1] = temp;
                }
            }
        }
    }
}
