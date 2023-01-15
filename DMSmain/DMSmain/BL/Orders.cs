using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using DMSmain.DataStructures;

namespace DMSmain.BL
{
    public class Orders
    {
        private string orderID;
        private string orderDate;
        private string deliveryDate;
        private string area;
        private double bill;
        public string Status;
        private string address;
        private LinkList<LineItem> orderedItems = new LinkList<LineItem>();

        public Orders() { }
        public Orders(string orderID,string address,string area , string deliveryDate,string orderDate)
        {
            this.orderID= orderID;
            this.orderDate= orderDate;
            this.deliveryDate= deliveryDate;
            this.address= address;
            this.area = area;
        }
        public string OrderID { get => orderID; set => orderID = value; }
        public string OrderDate { get => orderDate; set => orderDate = value; }
        public string DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public LinkList<LineItem> OrderedItems { get => orderedItems; set => orderedItems = value; }
        public double Bill { get => bill; set => bill = value; }
        public string Address { get => address; set => address = value; }
        public string Area { get => area; set => area = value; }

        public void orderIDGenerator()
        {
            Random random = new Random(); // generating a random string 
            StringBuilder str = new StringBuilder();
            char ch;

            for (int i = 0; i < 7; i++)
            {
                double number = random.NextDouble();
                int check = Convert.ToInt32(Math.Floor(25 * number)); // getting a random string bw 0 and 25
                ch = Convert.ToChar(check + 65); // converting floor int value to character for appending in string
                                                 // builder
                str.Append(ch);
            }
            this.orderID = str.ToString(); 
        }
        public void calculateBill()
        {
            LinkListNode<LineItem> present = orderedItems.Head;
            while(present != null) {
                this.bill += present.Data.getPayableAmount();
                present = present.Next;
            }
        }
    }
}
