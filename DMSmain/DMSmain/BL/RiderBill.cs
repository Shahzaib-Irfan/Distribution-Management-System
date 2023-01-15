using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.BL
{
    public class RiderBill
    {
        public int BillFuel;

        public static bool operator ==(RiderBill r1 , RiderBill r2)
        {
            return r1.BillFuel == r2.BillFuel;
        }
        public static bool operator !=(RiderBill r1, RiderBill r2)
        {
            return r1.BillFuel != r2.BillFuel;
        }
    }
}
