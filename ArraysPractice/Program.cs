using System;

namespace ArraysPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[]{1, 2, 3, 4, 5, 6};
            int[] array2 = new int[]{1, 2, 3, 4, 5, 6};
            int n = 2;
            Problem.copyElements(array1, array2, n);
        }    
        public class Problem
        {
            public static int[] copyElements(int[] arrayOne, int[] arrayTwo, int n)
            {
                int[] array3 = new int[arrayOne.Length + arrayTwo.Length];

                for (int i = 0; i < n; i++)
                {
                    array3[i] = arrayOne[i];
                    Console.WriteLine(array3[i]);
                }

                for (int i = 0; i < arrayTwo.Length; i++)
                {
                    array3[i] = arrayTwo[i];
                    Console.WriteLine(array3[i]);
                }
                return array3;
            }
                            
        }


    }
}
//write a method that copies n elements from the front of one integer array to the front of another.
//the two arrays and the number n are all arguments to the method.