using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMSmain.BL;

namespace DMSmain.DL
{
    public class ShopDL
    {
        public static List<Shop> shops = new List<Shop>();

        public static void AddShops(Shop shop)
        {
            shops.Add(shop);
        }

        public Shop GetShop(Shop shop)
        {
            foreach (Shop shopIteration in shops)
            {
                if(shop == shopIteration) 
                    return shopIteration;
            }
            return null;
        }

        public static List<Shop> deleteProduct(Shop shop)
        {
            for (int i = 0; i < shops.Count; i++)
            {
                if (shops[i] == shop)
                {
                    shops.RemoveAt(i);
                }
            }
            return shops;
        }

        public static List<Shop> updateShop(Shop shopOriginal, Shop updated)
        {
            for (int i = 0; i < shops.Count; i++)
            {
                if (shops[i] == shopOriginal)
                {
                    shops[i] = updated;
                }
            }
            return shops;
        }

        public static void writeInFile()
        {
            string path = "shops.csv";
            StreamWriter file = new StreamWriter(path, true);
            foreach (Shop i in shops)
            {
                file.WriteLine(i.ShopName + "," + i.ShopAddress + "," + i.ShopArea + "," + i.ShopContact + "," + i.ShopKeeper.ShopkeeperName + "," + i.ShopKeeper.ShopkeeperEmail + "," + i.Directions.Latitude1 + "," + i.Directions.Longitude1);
            }
            file.WriteLine();
            file.Flush();
            file.Close();

        }
        public static void LoadFromFile()
        {
            shops.Clear();
            string path = "shops.csv";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string item = "";
                while ((item = file.ReadLine()) != "" || (item = file.ReadLine()) != null)
                {
                    string[] record = item.Split(',');
                    string shopName = record[0];
                    string shopAddress = (record[1]);
                    string shopArea = (record[2]);
                    string shopContact = record[3];
                    string shopKeeperName = record[4];
                    string shopKeeperEmail = record[5];
                    float shopLatitude = float.Parse(record[6]);
                    float shopLongitude = float.Parse(record[6]);
                    Shop shop = new Shop(shopName, shopAddress, shopArea, shopContact, new ShopKeeper(shopKeeperName, shopKeeperEmail), new Directions(shopLongitude, shopLatitude));
                    AddShops(shop);
                }
                file.Close();
            }
        }
    }
}
