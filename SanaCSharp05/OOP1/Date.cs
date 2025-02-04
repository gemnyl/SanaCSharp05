﻿namespace OOP1
{
    public class Date
    {
        protected int minutes;
        public int Minutes
        {
            get { return minutes; }

            set
            {
                if (value >= 0 && value <= 60)
                    minutes = value;
                else throw new Exception("Error: Minutes must be between 0 and 60.");
            }
        }
        protected int hours;
        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value >= 0 && value <= 24)
                    hours = value;
                else throw new Exception("Error: Hours must be between 0 and 24.");
            }
        }
        protected int days;
        public int Days
        {
            get { return days; }
            set
            {
                if (value > 0 && value <= 31)
                    days = value;
                else throw new Exception("Error: Days must be between 1 and 31.");
            }
        }

        protected int months;
        public int Months
        {
            get { return months; }
            set
            {
                if (value >= 1 && value <= 12)
                    months = value;
                else throw new Exception("Error: Months must be between 1 and 12.");
            }
        }

        protected int year;
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= DateTime.Today.Year)
                    year = value;
                else throw new Exception("Error: Year must be equal to or greater than the current year.");
            }
        }

        public Date()
        {
            Minutes = DateTime.Now.Minute;
            Hours = DateTime.Now.Hour;
            Days = DateTime.Now.Day;
            Months = DateTime.Now.Month;
            Year = DateTime.Now.Year;
        }

        public Date(int hours)
        {
            Minutes = DateTime.Now.Minute;
            Hours = hours;
            Days = DateTime.Now.Day;
            Months = DateTime.Now.Month;
            Year = DateTime.Now.Year;
        }

        public Date(int hours, int months) : this(hours)
        {
            Months = months;
        }

        public Date(int hours, int months, int days) : this(hours, months)
        {
            Days = days;
        }

        public Date(int hours, int months, int days, int minutes) : this(hours, months, days)
        {
            Minutes = minutes;
        }

        public Date(int hours, int months, int days, int minutes, int year) : this(hours, months, days, minutes)
        {
            Year = year;
        }

        public Date(Date obj)
        {
            year = obj.year;
            months = obj.months;
            days = obj.days;
            hours = obj.hours;
            minutes = obj.minutes;
        }
    }
}
