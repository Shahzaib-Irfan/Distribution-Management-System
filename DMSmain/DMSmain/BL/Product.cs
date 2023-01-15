using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.BL
{
    public class Product
    {
        private string name;
        private double price;
        private string id;
        private string category;
        private bool isPerishable;
        private int stock;

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Id { get => id; set => id = value; }
        public string Category { get => category; set => category = value; }
        public bool IsPerishable { get => isPerishable; set => isPerishable = value; }
        public int Stock { get => stock; set => stock = value; }

        public Product(string name, double price, int stock, string id, string category, bool isPerishable)
        {
            Name = name;
            Price = price;
            Id = id;
            Category = category;
            IsPerishable = isPerishable;
            this.stock = stock;
        }
        public Product(string id) {
            this.Id = id;

        }
        public static bool operator ==(Product product1, Product product2)
        {
            if (object.ReferenceEquals(product1, null) || object.ReferenceEquals(product2, null))
                return false;
            return product1.name == product2.name && product1.price == product2.price && product1.stock == product2.stock && product1.id == product2.id && product1.category == product2.category && product1.isPerishable == product2.isPerishable;
        }
        public static bool operator !=(Product product1, Product product2)
        {
            if (object.ReferenceEquals(product1, null) && object.ReferenceEquals(product2, null))
                return true;
            return false;
        }
    }
}
