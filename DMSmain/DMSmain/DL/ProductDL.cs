using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using DMSmain.BL;
using DMSmain.DataStructures;

namespace DMSmain.DL
{
    public class ProductDL
    {

        public static LinkList<Product> linkedListProducts = new LinkList<Product>();

        public static HashTable<int, Product> hashTableProducts = new HashTable<int, Product>();
        public static int length = 0;
        public static void addProductstoLinkedList(Product product)
        {
            linkedListProducts.Insert(product);
        }

        //public static void addProductstoHashTable(Product product)
        //{
        //    int key = hashTableProducts.
        //    hashTableProducts.Add(key, product);
        //}

        public static LinkListNode<Product> getProductBYid(Product p)
        {
            LinkListNode<Product> present = linkedListProducts.Head;
            while (present != null)
            {
                if (Object.Equals(present.Data.Id , p.Id))
                {
                    return present;
                }
                present = present.Next;
            }
            return null;
        }

        public static void getDataFromApi()
        {
            length = 0;
            string url = "https://course-api.com/react-store-products";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            HttpWebResponse response= (HttpWebResponse)request.GetResponse();

            StreamReader data = new StreamReader(response.GetResponseStream());

            string responseData = data.ReadToEnd();

            string destrealizeData = Newtonsoft.Json.JsonConvert.DeserializeObject(responseData).ToString();
            JArray jsonArray = JArray.Parse(destrealizeData);
            Random rnd = new Random();
            for (int i = 0; i < jsonArray.Count; i++)
            {
                string id = (string)jsonArray[i]["id"];
                string name = (string)jsonArray[i]["name"];
                string category = (string)jsonArray[i]["category"];
                double price = (double)jsonArray[i]["price"];
                int stock = rnd.Next(10, 50);
                double number = rnd.Next(40, 60);
                number /= 50;
                bool perishible;
                number = Math.Floor(number);
                if(number == 1) {perishible= true;}
                else { perishible= false;}
                Product product = new Product(name, price, stock, id, category, perishible);
                addProductstoLinkedList(product);
                //addProductstoHashTable(product);
                length += 1;
            }
            writeInFile();
        }
        public static void writeInFile()
        {
            string path = "products.csv";
            StreamWriter file = new StreamWriter(path, false);
            LinkListNode<Product> node = linkedListProducts.Head;
            while(node != null)
            {
                file.WriteLine(node.Data.Name + "," + node.Data.Price + "," + node.Data.Stock + "," + node.Data.Id + "," + node.Data.Category + "," + node.Data.IsPerishable);
                node = node.Next;
            }
            file.WriteLine();
            file.Flush();
            file.Close();
            LoadFromFile();
        }
        public static void LoadFromFile()
        {
            length = 0;
            linkedListProducts.Clear();
            string path = "products.csv";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                string item = "";
                while ((item = file.ReadLine()) != "")
                {
                    string[] record = item.Split(',');
                    string name = record[0];
                    double price = double.Parse(record[1]);
                    int stock = int.Parse(record[2]);
                    string id = record[3];
                    string category = record[4];
                    //int perishibleSub = int.Parse(record[5]);
                    bool perishible = bool.Parse(record[5]);
                    Product product = new Product(name, price, stock, id, category, perishible);
                    addProductstoLinkedList(product);
                    //addProductstoHashTable(product);
                    length++;
                }
                file.Close();
            }
        }

        public static LinkList<Product> deleteProduct(Product product)
        {
            linkedListProducts.Remove(product);
            return linkedListProducts;
        }

        
        public static LinkList<Product> updateProduct(LinkListNode<Product> productOriginal, LinkListNode<Product> updated)
        {
            productOriginal = updated;
            return linkedListProducts;
        }
    }
}
