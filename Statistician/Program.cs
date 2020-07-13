using System;

namespace Statistician
{
    class Program
    {
        static void Main(string[] args)
        {
            Statistician s = new Statistician();
            s.nextNumber(-1.1);
            s.nextNumber(-2.4);
            s.nextNumber(-10);
            Console.WriteLine(s.findLargest());
        }
        public class Statistician
        {
            public double number;
            public double length;
            public double numbersSum;
            public double lastNumber;
            public double smallestNumber;
            public double largestNumber;
            public double mean;
            public Statistician()
            {
                number = 0;
                length = 0;
                numbersSum = 0;
                lastNumber = 0;
                smallestNumber = 0;
                largestNumber = 0;
                mean = 0;
            }
            public void nextNumber(double x)
            {         
                number = x;       
                if (length == 0)
                {
                    smallestNumber = x;
                    largestNumber = x;
                }
                numbersSum = numbersSum + number;
                lastNumber = number;
                length = length + 1;
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }
            public double findSum()
            {
                return numbersSum;
            }
            public double findSmallest()
            {
                return smallestNumber;
            }
            public double findLargest()
            {
                return largestNumber;
            }
            public double provideLength()
            {                
                return length;                 
            }
            public double findMean()
            {
                mean = numbersSum/length;
                return mean;
            }            
        }
    }
}
