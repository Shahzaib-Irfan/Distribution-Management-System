using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.BL
{
    public class OrderedProduct : Product
    {
        private int quantity;
        private int totalAmountPayabale;
        private ShopKeeper shopKeeper;

        public int Quantity { get => quantity; set => quantity = value; }
        public int TotalAmountPayabale { get => totalAmountPayabale; set => totalAmountPayabale = value; }
        public ShopKeeper ShopKeeper { get => shopKeeper; set => shopKeeper = value; }

        public OrderedProduct(string name, string price, int id, string category, bool isPerishable, int quantity, int totalAmountPayabale) : base(name, price, id, category, isPerishable)
        {
            Quantity = quantity;
            TotalAmountPayabale = totalAmountPayabale;
        }
    }
}
