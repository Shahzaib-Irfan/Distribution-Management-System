using DMSmain.BL;
using DMSmain.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.DataStructures
{
    //public class hashTable<T>
    //{

    //}
    //public class HashTableNode<T>
    //{
    //    public HashTableNode() { }
    //    public HashTableNode(T value) {
    //        this.value = value;
    //    }

    //    T value;

    //    public T Value { get => value; set => this.value = value; }
    //}

    public class HashTable<TKey, TValue>
    {
        int mod = 1;
        List<int> hashValues = new List<int>();
        private Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
        public HashTable() { }
        public HashTable(Dictionary<TKey, TValue> dictionary)
        {
            if(typeof(TValue) == typeof(Product))
            {
                mod = ProductDL.length;
            }
            else
            {
                mod = ShopDL.shops.Count;
            }
        }
        public int HashCode(string keyMaker)
        {
            int hash = 0;
            mod = 6997;
            byte[] asciiArray = Encoding.ASCII.GetBytes(keyMaker);
            for (int i = 0; i < asciiArray.Length; i++)
            {
                hash += asciiArray[i];
            }
            foreach (int h in hashValues)
            {
                if(h == hash)
                {
                    hash += 1;
                }
            }
            hashValues.Add(hash);
            return hash;
        }
        public void Add(TKey key, TValue value)
        {
            if (dictionary.ContainsKey(key))
            {
            }
            dictionary.Add(key, value);
        }

        public bool ContainsKey(TKey key)
        {
            return dictionary.ContainsKey(key);
        }

        public bool Remove(TKey key)
        {
            return dictionary.Remove(key);
        }

        public TValue getObject(TKey key)
        {
            return dictionary[key];
        }
        public bool TryGetValue(TKey key, out TValue value)
        {
            return dictionary.TryGetValue(key, out value);
        }
    }
}
