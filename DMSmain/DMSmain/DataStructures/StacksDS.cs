using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMSmain.DataStructures
{
    public class StacksDS<T>
    {
        List<T> stack;
        int capacity;

        public StacksDS()
        {
            stack = new List<T>();
            this.capacity = 500;
        }
        public StacksDS(int capacity)
        {
            stack = new List<T>();
            this.capacity = capacity;
        }
        public int StackCount()
        {
            return stack.Count;
        }
        public void Push(T data)
        {
            if (this.StackCount() > capacity) throw new Exception("Stack Overflow");

            stack.Add(data);
            capacity++;
        }

        public T Pop()
        {
            if (this.StackCount() < 0) throw new Exception("Stack Underflow");

            int POP_INDEX = StackCount() - 1;
            capacity--;

            T removalObject = stack[POP_INDEX];
            stack.RemoveAt(POP_INDEX);

            return removalObject;
        }

        public T Peek()
        {
            int popIndex = this.StackCount() - 1;
            if (popIndex < 0) throw new Exception("Stack is Empty");

            return stack[popIndex];
        }
    }
}
