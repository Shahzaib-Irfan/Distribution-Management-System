using DMSmain.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DMSmain.DL;


namespace DMSmain.BL
{
    public class Rider : MUser
    {
        private BST<RiderBill> bills;
        //public OrdersDL odrs = new OrdersDL();
        //public QueueDS<Orders> odrs = new QueueDS<Orders>();
        public QueueWithLists<Orders> odrs = new QueueWithLists<Orders>();
        private QueueWithLists<Orders> ordersForDelivery= new QueueWithLists<Orders>();
        public string Area { get; set; }
        public BST<RiderBill> Bills { get => bills; set => bills = value; }
        public QueueWithLists<Orders> OrdersForDelivery { get => ordersForDelivery; set => ordersForDelivery = value; }

        public Rider() : base() { }
        public Rider(string name, string CNIC, string phoneNumber, string email,string Area,
            string username, string password, string role) : base(username, password, role)
        {
            this.name = name;
            this.email = email;
            this.CNIC = CNIC;
            this.phoneNumber = phoneNumber;
            this.Area = Area;
            this.bills = new BST<RiderBill>();
        }
        public string getCNIC()
        {
            return this.CNIC;
        }
        public string getName()
        {
            return this.name;
        }
        public string getPhoneNo()
        {
            return this.phoneNumber;
        }
        public string getEmail()
        {
            return this.email;
        }
        public static bool operator ==(Rider rider1, Rider rider2)
        {
            if (Object.ReferenceEquals(rider1, null)) return false;
            else
            {
                return (rider1.name == rider2.name) && (rider1.email == rider2.email) &&
                    (rider1.CNIC == rider2.CNIC) && (rider1.phoneNumber == rider2.phoneNumber) &&
                    (rider1.Username == rider2.Username) && (rider1.Password == rider2.Password) && (rider1.Role == rider2.Role);
            }
        }
        public static bool operator !=(Rider rider1, Rider rider2)
        {
            if (Object.ReferenceEquals(rider1, null)) return true;

            return !((rider1.name == rider2.name) && (rider1.email == rider2.email) &&
                    (rider1.CNIC == rider2.CNIC) && (rider1.phoneNumber == rider2.phoneNumber) &&
                    (rider1.Username == rider2.Username) && (rider1.Password == rider2.Password) && (rider1.Role == rider2.Role));
        }
    }
}
