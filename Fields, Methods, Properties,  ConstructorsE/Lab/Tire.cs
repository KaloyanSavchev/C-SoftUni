using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        private int year;
        private double presure;
        private int Year
        {
            get { return year; }
            set { year = value; }
        }
        private double Presure
        {
            get { return presure; }
            set { presure = value; }
        }
        public Tire(int year, double presure)
        {
            Year = year;
            Presure = presure;
        }
    }
}
