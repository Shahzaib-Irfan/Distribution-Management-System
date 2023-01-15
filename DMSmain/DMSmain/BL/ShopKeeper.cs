using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.BL
{
    public class ShopKeeper
    {
        private string shopkeeperName;
        private string shopkeeperEmail;

        public string ShopkeeperName { get => shopkeeperName; set => shopkeeperName = value; }
        public string ShopkeeperEmail { get => shopkeeperEmail; set => shopkeeperEmail = value; }

        public ShopKeeper(string shopkeeperName, string shopkeeperEmail)
        {
            ShopkeeperName = shopkeeperName;
            ShopkeeperEmail = shopkeeperEmail;
        }

        public static bool operator ==(ShopKeeper shopKeeper1, ShopKeeper shopKeeper2)
        {
            if (object.ReferenceEquals(shopKeeper1, null) || object.ReferenceEquals(shopKeeper2, null))
                return false;
            return shopKeeper1.shopkeeperName == shopKeeper2.shopkeeperName && shopKeeper1.shopkeeperEmail == shopKeeper2.shopkeeperEmail;
        }

        public static bool operator !=(ShopKeeper shopKeeper1, ShopKeeper shopKeeper2)
        {
            if (object.ReferenceEquals(shopKeeper1, null) && object.ReferenceEquals(shopKeeper2, null))
                return true;
            return false;
        }
    }
}
