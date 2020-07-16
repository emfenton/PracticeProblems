using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Date todaysDate = new Date(11, 30, 2020);
            todaysDate.incrementDate();
            Console.WriteLine(todaysDate.getNumberDate());
        }

        public class Date
        {
            public int month;
            public int day;
            public int year;

            public Date(int month, int day, int year)
            {
                this.month = month;
                this.day = day;
                this.year = year;
            }

            public void incrementDate()
            {
                if (month == 1 && day == 31)
                {
                    month = 2;
                    day = 1;
                }
                else if (month == 2 && day == 28)
                {
                    month = 3;
                    day = 1;
                }
                else if (month == 3 && day == 31)
                {
                    month = 4;
                    day = 1;
                }    
                else if (month == 4 && day == 30)
                {
                    month = 5;
                    day = 1;
                }    
                else if (month == 5 && day == 30)
                {
                    month = 6;
                    day = 1;
                }
                else if (month == 6 && day == 30)
                {
                    month = 7;
                    day = 1;
                }
                else if (month == 7 && day == 31)
                {
                    month = 8;
                    day = 1;
                }
                else if (month == 8 && day == 30)
                {
                    month = 9;
                    day = 1;
                }
                else if (month == 9 && day ==30)
                {
                    month = 10;
                    day = 1;
                }
                else if (month == 10 && day == 31)
                {
                    month = 11;
                    day = 1;
                }
                else if (month == 11 && day == 30)
                {
                    month = 12;
                    day = 1;
                }               
                else if (month == 12 && day == 31)
                {
                    month = 1;
                    day = 1;
                    year = 2021;
                }
                else
                {
                    day = day + 1; 
                }
            }
            public string getNumberDate()
            {
                string numberFormat;
                return numberFormat = month.ToString() + "/" + day.ToString() + "/" + year.ToString(); 
            }
            public string getWordDate()
            {
                string newMonth = "";
                if (month == 1)
                {
                    newMonth = "January ";   
                }
                if (month == 2)
                {
                    newMonth = "February ";
                }
                if (month == 3)
                {
                    newMonth = "March ";
                }
                if (month == 4)
                {
                    newMonth = "April ";
                }
                if (month == 5)
                {
                    newMonth = "May ";
                }
                if (month == 6)
                {
                    newMonth = "June ";
                }
                if (month == 7)
                {
                    newMonth = "July ";
                }
                if (month == 8)
                {
                    newMonth = "August ";
                }
                if (month == 9)
                {
                    newMonth = "September ";
                }
                if (month == 10)
                {
                    newMonth = "October ";
                }
                if (month == 11)
                {
                    newMonth = "November ";
                }
                if (month == 12)
                {
                    newMonth = "December ";
                }
                return newMonth + day.ToString() + ", " + year.ToString();
            }
        }
    }
}

//write a method to increment the date to the next day

//display date in number format Ex. 2/15/2020

//display date in word format Ex. November 10, 1992