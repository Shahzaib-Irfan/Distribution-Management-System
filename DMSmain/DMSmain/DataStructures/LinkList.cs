using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMSmain.DataStructures
{
    public class LinkListNode<T>
    {
        T data;
        LinkListNode<T> next;
        LinkListNode<T> previous;
        public LinkListNode(T data)
        {
            this.data = data;
            this.next = null;
            this.previous = null;
        }

        public LinkListNode<T> Next { get => next; set => next = value; }
        public LinkListNode<T> Previous { get => previous; set => previous = value; }
        public T Data { get => data; set => data = value; }
    }
    public class LinkList<T>
    {
        private LinkListNode<T> head;
        public LinkListNode<T> Tail { get => tail; set => tail = value; }
        public LinkListNode<T> Head { get => head; set => head = value; }
        public int Count { get => count; set => count = value; }

        private LinkListNode<T> tail;
        private int count;

        public LinkList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public LinkList(T data)
        {
            head = new LinkListNode<T>(data);
            tail = Head;
            count++;
        }
        public void InsertAtHead(T data)
        {
            LinkListNode<T> node = new LinkListNode<T>(data);
            if(head == null)
            {
                head = node;
                Tail = node;
                count++;
            }
            else {
                head.Previous = node;
                node.Next = Head;
                Head = node;
                count++;
            }
        }
        public void Insert(T data)
        {
            LinkListNode<T> node = new LinkListNode<T>(data);
            if(Head == null)
            {
                InsertAtHead(data);
            }
            else{
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
                this.count++;
            }
        }
        public void InsertAfter(T previousData , T data)
        {
            LinkListNode<T> node = Search(previousData);
            if (node == null) throw new Exception("Key for insertion after does not Exist");
            else if (node == Tail) Insert(data);
            else if (node == Head) InsertAtHead(data);
            else
            {
                LinkListNode<T> inserter = new LinkListNode<T>(data);
                inserter.Next = node.Next;
                inserter.Previous = node;
                node.Next = inserter;

                if (inserter.Next != null) inserter.Next.Previous = inserter;

            }
            count++;
        }
        public LinkListNode<T> Search(T data)
        {
            LinkListNode<T> present = Head;
            while(present != null)
            {
                if(present.Data == null && data == null || present.Data != null && present.Data.Equals(data))
                {
                    return present;
                }
                present = present.Next;
            }
            return null;
        }
        public LinkListNode<T> GetAtPosition(int position)
        {
            if (position < 0 || position >= this.count)
                throw new ArgumentOutOfRangeException("Node can not be searched at positions invalide.");
        
            LinkListNode<T> curent = Head;
            for(int i = 0; i < position; i++)
            {
                curent = curent.Next;
            }
            return curent;
        }
        public void RemoveAtHead()
        {
            if(head == null)
            {
                throw new InvalidOperationException("Null pointer was attempted to be accessed");
            }
            head = head.Next;
            if(head == null)
            {
                tail = null;
                count = 0;
                return;
            }
            head.Previous = null;
            count--;
            
        }
        public void RemoveAtTail()
        {
            if(tail == null)
            {
                throw new InvalidOperationException("Null pointer was attempted to be accessed");
            }
            tail = tail.Previous;
            tail.Next = null;
            this.count--;
        }
        public void Remove(T data)
        {
            LinkListNode<T> present = Search(data);
            if (tail == head)
            {
                MessageBox.Show("In Head");
                RemoveAtHead();
                return;
            }
            else if (present == tail)
            {
                MessageBox.Show("In Tail");
                RemoveAtTail();return;
            }
            else if(present == head)
            {
                MessageBox.Show("In Head");
                RemoveAtHead(); return;
            }
            if (present == null) return;
            MessageBox.Show("Else");
            present.Next.Previous = present.Previous;
            present.Previous.Next = present.Next;
            //tail = tail.Previous;
            //tail.Next = null;
            this.count--;
        }
        public void Clear()
        {
            this.head = null;
            this.count = 0;
        }
    }
}
