using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMSmain.BL;

namespace DMSmain.DL
{
    public class CartDL
    {
        private List<Cart> cart = new List<Cart>();

        public List<Cart> Cart { get => cart; set => cart = value; }
    }
}
