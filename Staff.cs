using System;
using System.Collections.Generic;
using System.Text;

namespace yara_finalproj
{
    abstract class Staff
    {
        protected double salary;
 
        protected double days;
    
        public Staff() { }
        public abstract  double CalculateSalary(double x);
        public abstract double CalculateVacationDays(double x);
        
    }
}
