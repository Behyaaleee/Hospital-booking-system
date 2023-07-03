using System;
using System.Collections.Generic;
using System.Text;

namespace yara_finalproj
{
    class PartTimeDoc:Doctor 
    {

        public PartTimeDoc(double x, string y)
        {
           WorkingHours = x;
          Email = y;

        }


        Surgery[] x = new Surgery[10];
        public override double CalculateSalary()
        {
            foreach(Surgery m in x)
            {
                salary += m.price;

            }
            return salary;
        }
            
    }
}
