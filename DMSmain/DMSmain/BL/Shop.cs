using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.BL
{
    public class Shop
    {
        private string shopName;
        private string shopAddress;
        private string shopCity = "LAHORE";
        private string shopArea;
        private string shopContact;
        private ShopKeeper shopKeeper;
        private Directions directions;

        public string ShopName { get => shopName; set => shopName = value; }
        public string ShopAddress { get => shopAddress; set => shopAddress = value; }
        public string ShopCity { get => shopCity; set => shopCity = value; }
        public string ShopArea { get => shopArea; set => shopArea = value; }
        public string ShopContact { get => shopContact; set => shopContact = value; }
        public ShopKeeper ShopKeeper { get => shopKeeper; set => shopKeeper = value; }
        public Directions Directions { get => directions; set => directions = value; }

        public Shop(string shopName, string shopAddress, string shopArea, string shopContact, ShopKeeper shopKeeper, Directions directions)
        {
            this.shopName = shopName;
            this.shopAddress = shopAddress;
            this.shopArea = shopArea;
            this.shopContact = shopContact;
            this.shopKeeper = shopKeeper;
            this.directions = directions;
        }
        public static bool operator ==(Shop shop1, Shop shop2)
        {
            if (Object.ReferenceEquals(shop1, null)) return false;
            else
            {
                return (shop1.shopContact == shop2.shopContact) && (shop1.ShopName == shop2.ShopName) &&
                    (shop1.shopAddress == shop2.shopAddress) && (shop1.shopCity == shop2.shopCity) && 
                    (shop1.shopArea == shop2.shopArea) && (shop1.shopKeeper == shop2.shopKeeper) && (shop1.Directions == shop2.Directions);
            }
        }
        public static bool operator !=(Shop shop1, Shop shop2)
        {
            if(Object.ReferenceEquals(shop1, null)) return true;

            return !((shop1.shopContact == shop2.shopContact) && (shop1.ShopName == shop2.ShopName) &&
                    (shop1.shopAddress == shop2.shopAddress) && (shop1.shopCity == shop2.shopCity) &&
                    (shop1.shopArea == shop2.shopArea) && (shop1.shopKeeper == shop2.shopKeeper) && (shop1.Directions == shop2.Directions));
        }
    }
}
