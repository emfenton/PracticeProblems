using System;

namespace Statistician
{
    class Program
    {
        static void Main(string[] args)
        {
            Statistician stats1 = new Statistician();
            Statistician stats2 = new Statistician();
            stats1.NextNumber(1);
            stats1.NextNumber(2);
            stats1.NextNumber(3);
            stats2.NextNumber(4);
            stats2.NextNumber(5);
            stats2.NextNumber(6);
            var s3 = Statistician.AddStatisticians(stats1, stats2);
            Console.WriteLine("s3 length is " + s3.GetLength());
            Console.WriteLine("s3 numbersum is " + s3.NumberSum());
            Console.WriteLine("s3 mean is " + s3.GetMean());
            Console.WriteLine("s3 smallest is " + s3.GetSmallest());
            Console.WriteLine("s3 largest is " + s3.GetLargest());
        }
        public class Statistician
        {
            int number = 0, length = 0, lastNumber = 0, numberSum = 0, smallestNumber = 0, largestNumber = 0;
            double mean = 0; 
            public void NextNumber(int x)
            {
                number = x;
                if (length == 0)
                {
                    smallestNumber = number;
                    largestNumber = number;
                }
                length = length + 1;
                lastNumber = number;
                numberSum = numberSum + number;       
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }
            public int GetLength()
            {
                return length;
            }
            public int LastNumber()
            {
                return lastNumber;
            }
            public int NumberSum()
            {
                return numberSum;
            }
            public double GetMean()
            {
                mean = (double)numberSum/(double)length;
                return mean;
            }
            public int GetSmallest()
            {
                return smallestNumber;
            }
            public int GetLargest()
            {
                return largestNumber;
            }

            public static Statistician AddStatisticians(Statistician s1, Statistician s2)
            {
                Statistician s3 = new Statistician();
                int number = s2.number;
                s3.length = s1.length + s2.length;
                s3.lastNumber = s2.lastNumber;
                s3.numberSum = s1.numberSum + s2.numberSum;
                
                if (s1.smallestNumber < s2.smallestNumber)
                {
                    s3.smallestNumber = s1.smallestNumber;
                }
                else
                {
                s3.smallestNumber = s2.smallestNumber;
                }
                if (s1.largestNumber > s2.largestNumber)
                {
                    s3.largestNumber = s1.largestNumber;
                }
                else
                {
                s3.largestNumber = s2.largestNumber;
                }
                return s3;
            }
        }

    }
}
