using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQT_Lab7
{
    public class Program
    {
        public static void Main(string[] args)
        {

         
        }
        public double Q1(int days)
        {
            
            double charge = 0;

            if (days > 0)
            {

                if (days <= 5)
                {
                    if (days == 1)
                    {
                        charge = 15;
                    }
                    else
                    {
                        charge = days * 10;
                    }
                }
                if (days > 5)
                {
                    charge = 50 + ((days - 5) * 8);
                }
            }
            if (days <= 0)
            {
                charge = 0;
            }
            return charge;
        }
        public double Q2(double weight, double height)
        {
            double bmi = weight / (height * height);
            return bmi;
        }
    }
}
