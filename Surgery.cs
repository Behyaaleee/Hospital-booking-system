using System;
using System.Collections.Generic;
using System.Text;

namespace yara_finalproj
{
    class Surgery
    {
        public DateTime Date;
        public string DoctorName;
        public int Room;
        public double price;
        public Surgery(DateTime D,string D_N,int R,double P)
        {
            Date = D;
            DoctorName = D_N;
            Room = R;
            price = P;
        }



    }
}
