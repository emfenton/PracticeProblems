using System;
using System.Collections.Generic;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            Date todaysDate = new Date(6, 30, 2020);
            Console.WriteLine(todaysDate.getWordDate());
        }

        public class Date
        {
            public int month;
            public int day;
            public int year;
            public Dictionary<int, string> map = new Dictionary<int, string>();
                 
            public Date(int month, int day, int year)
            {
                this.month = month;
                this.day = day;
                this.year = year;
                map.Add(1, "January");
                 map.Add(2, "February");
                 map.Add(3, "March");
                 map.Add(4, "April");
                 map.Add(5, "May");
                 map.Add(6, "June");
                 map.Add(7, "July");
                 map.Add(8, "August");
                 map.Add(9, "September");
                 map.Add(10, "October");
                 map.Add(11, "November");
                 map.Add(12, "December");
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
                return map[month] + " " + day.ToString() + ", " + year.ToString();
            }
        }
    }
}

//write a method to increment the date to the next day

//display date in number format Ex. 2/15/2020

//display date in word format Ex. November 10, 1992