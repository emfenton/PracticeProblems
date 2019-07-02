using System;

namespace largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] myArray = new int[] {1, 3, 5, 7, 9, 2, 6, 22, 4, 7};
            int largestNumber = int.MinValue;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > largestNumber)
                {
                    largestNumber = myArray[i];
                }
            }
            Console.WriteLine(largestNumber);
        }
    }
}
