using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.DataStructures
{
    public class QueueWithLists<T>
    {
        LinkList<T> dataStruct;
        int capacity;

        public LinkList<T> DataStruct { get => dataStruct; set => dataStruct = value; }

        public QueueWithLists()
        {
            dataStruct = new LinkList<T>();
            this.capacity = 500;
        }
        public QueueWithLists(int capacity)
        {
            this.capacity = capacity;
            dataStruct = new LinkList<T>();
        }

        public bool Enqueue(T data)
        {

            if (dataStruct.Count > this.capacity) throw new Exception("Queue Overflow");

            dataStruct.Insert(data);
            capacity++;
            return true;
        }
        public T Dequeue()
        {
            // type casting provides an explicit check as to
            // the type Object is converted into required class

            if (this.capacity < 0) throw new Exception("Queue Underflow");
            
            T retVal = (T)dataStruct.Head.Data;
            dataStruct.RemoveAtHead();
            this.capacity--;
            return (T)retVal;
        }
        public T Peek()
        {
            return this.dataStruct.Head.Data;
        }
        public int CheckPopulation()
        {
            return this.dataStruct.Count;
        }
        public bool isContain(T data)
        {
            return this.dataStruct.Search(data) != null;
        }
        public void Clear()
        {
            this.dataStruct.Head = null;
        }
    }
}
