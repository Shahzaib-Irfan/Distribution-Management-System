using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMSmain.BL;
using DMSmain.DataStructures;

namespace DMSmain.DL
{
    public class OrdersDL
    {
        public static QueueWithLists<Orders> queueDS = new QueueWithLists<Orders>();

        public static void AddOrderToQueue(Orders order)
        {
            queueDS.Enqueue(order);
        }

        public static Orders RemoveOrder()
        {
            return queueDS.Dequeue();
        }
        public static void writeInFile()
        {
            string path = "orders.csv";
            StreamWriter file = new StreamWriter(path, true);
            try
            {
                LinkListNode<Orders> head = queueDS.DataStruct.Head;
                while(head != null)
                {
                    file.WriteLine(head.Data.OrderID +","+ head.Data.Address + "," +head.Data.Area + "," +head.Data.DeliveryDate + "," +head.Data.OrderDate);
                    head = head.Next;
                }
                file.Close();
            }
            catch(Exception ex)
            {
                file.Close();
            }
        }
        public static void LoadFromFile()
        {
            queueDS.Clear();
            string path = "orders.csv";
            StreamReader file = new StreamReader(path,true);
            try {
                if (File.Exists(path))
                {
                    string item = "";
                    while((item = file.ReadLine())!= null)
                    {
                        string[] record = item.Split(',');
                        string orderID = record[0];
                        string address = record[1];
                        string area = record[2];
                        string deliveryDate = record[3];
                        string orderDate = record[4];
                        Orders odr = new Orders(orderID, address,area, deliveryDate, orderDate);
                    }
                    file.Close();
                }
            }
            catch(Exception ex) { file.Close();}
        }
    }
}
