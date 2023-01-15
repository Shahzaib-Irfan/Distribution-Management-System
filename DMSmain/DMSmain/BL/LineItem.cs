using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.BL
{
    public class LineItem
    {
        private int quantity;
        //private int totalAmountPayabale;
        private Product p;
        private ShopKeeper shopKeeper;

        public int Quantity { get => quantity; set => quantity = value; }
        public ShopKeeper ShopKeeper { get => shopKeeper; set => shopKeeper = value; }

        //public int TotalAmountPayabale { get => totalAmountPayabale; set => totalAmountPayabale = value; }

        public LineItem(int quantity , Product p, ShopKeeper shopKeeper)
        {
            Quantity = quantity;
            this.p = p;
            this.shopKeeper = shopKeeper;
        }
        public LineItem(int quantity, Product p)
        {
            Quantity = quantity;
            this.p = p;
            p.Stock = p.Stock - quantity;
        }
        public double getPayableAmount()
        {
            return p.Price * quantity;
        }
    }
}
