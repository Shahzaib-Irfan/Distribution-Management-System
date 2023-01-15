using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DMSmain.DataStructures
{
    public class QueueDS<T>
    {
        Queue datastruct;
        int capacity;

        public Queue Datastruct { get => datastruct; set => datastruct = value; }

        public QueueDS() {
            this.datastruct = new Queue();
            capacity = 500;
        }
        public QueueDS(int capacity)
        {
            this.capacity = capacity;
            this.datastruct = new Queue();
        }

        public bool Enqueue(T data) {

            if(datastruct.Count > this.capacity)    throw new Exception("Queue Overflow");
            
            datastruct.Enqueue(data);
            capacity++;
            return true;
        }
        public T Dequeue() {
            // type casting provides an explicit check as to
            // the type Object is converted into required class

            if(this.capacity < 0)   throw new Exception("Queue Underflow");
            this.capacity--;
            return (T) this.datastruct.Dequeue();   
        }

        public T Peek()
        {
            return (T) this.datastruct.Peek();
        }

        public bool IsContain(T data)
        {
            Object O = (Object)data;

            bool flag = this.datastruct.Contains(O);

            return flag;
        }

        public int CheckPopulation()
        {
            return this.datastruct.Count;
        }
        public void Clear() { 
            this.datastruct.Clear();
        }
    }
}
