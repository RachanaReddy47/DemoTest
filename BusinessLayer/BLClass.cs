using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLClass
    {
        public int Divide(string Numerator,string Denominator)
        {
            int r = 0, r1 = 0;
            bool n = int.TryParse(Numerator, out r);
            bool n1 = int.TryParse(Denominator, out r1);
            if (n && n1)
            {
                if (r1 != 0)
                    return r/r1;
                else
                    throw new DivideByZeroException("Cannot Divide By Zero");
            }
            else
                throw new FormatException("only numbers");

        }

        public int Age(DateTime Dob)
        {
            int age = (int)((DateTime.Now).Subtract(Dob).TotalDays / 365);
            if (age >= 18 && age <= 60)
                return age;
            else
                throw new CustomException("Age should be between 18 and 60");
        }
    }

    public class CustomException:Exception
    {
        public CustomException(string str):base(str)
        {

        }
    }
}
