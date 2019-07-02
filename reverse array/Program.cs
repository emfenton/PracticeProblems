using System;

namespace reverse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = new int[] {1, 3, 5, 7, 9, 2, 6, 22, 4, 7};

            for ( int i = myArray.Length - 1; i >= myArray[0] - 1 ; i--)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
