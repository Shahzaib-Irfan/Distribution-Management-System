using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.BL
{
    public class Cart
    {
        private int totalOrders;
        private Orders ordered;
        private int cummulativeAmount;

        public int TotalOrders { get => totalOrders; set => totalOrders = value; }
        public int CummulativeAmount { get => cummulativeAmount; set => cummulativeAmount = value; }
        
        public Cart(int totalOrders, int cummulativeAmount)
        {
            this.totalOrders = totalOrders;
            this.cummulativeAmount = cummulativeAmount;
        }
    }
}
