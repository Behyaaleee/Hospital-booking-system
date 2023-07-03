using System;
using System.Collections.Generic;
using System.Text;

namespace yara_finalproj
{
    class Doctor :Staff
    {
        public Doctor() { }
      
        private double rate = 20;
        

        public override double CalculateSalary(double x)
        {
            salary = rate * x;
            return salary;
        }
        public override sealed double CalculateVacationDays(double x)
        {
            double m= x / 100;
                days= m* 10;
            return days;
        }
        
       
    }
}
