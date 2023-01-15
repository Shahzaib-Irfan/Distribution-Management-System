using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DMSmain.DataStructures
{
    public class Node<T>
    {
        T data;
        Node<T> parent;
        Node<T> leftChild;
        Node<T> rightChild;
        public Node() { }
        public Node(T data) {
            this.data = data;
        }

        public T Data { get => data; set => data = value; }
        public Node<T> Parent { get => parent; set => parent = value; }
        internal Node<T> LeftChild { get => leftChild; set => leftChild = value; }
        internal Node<T> RightChild { get => rightChild; set => rightChild = value; }
    }
    public class BST<T>  where T:class  // a constraint on the BST is necessary for 
                                        // comparing data in Insert
    {
        /// <summary>
        /// A BST where a constraint on it being a class is applied. Additionally , 
        /// you need to overload the == operator for the class you want to implement
        /// my BST for.
        /// </summary>
        Node<T> root = null;
        List<Node<T>> sorted = new List<Node<T>>();

        public List<Node<T>> Sorted { get => sorted; set => sorted = value; }
        public Node<T> Root { get => root; set => root = value; }

        private bool ComparingGreaterZero(T object1 , T object2)
        {
            IComparable comparable = (IComparable)object1;
            //IComparable comparable2 = (IComparable)object2;

            return comparable.CompareTo(object2) > 0;
        }
        public void Insert(Node<T> root , T entryData){
            Node<T> InsertDataNode = new Node<T>(entryData);

            if (root == null)
            {
                root = InsertDataNode;
                root.Parent = null;
            }
            else
            {
               Node<T> lastNode = SearchTree(this.root , entryData);
               if (!(this.ComparingGreaterZero(entryData , lastNode.Data))) // less data case
               {
                    lastNode.LeftChild = InsertDataNode;
               }
               else                // greater case
               {
                    lastNode.RightChild = InsertDataNode;
               }

               InsertDataNode.Parent = lastNode;
            }
        }

        public Node<T> SearchTree(Node<T> root , T element)
        {
            if(root == null || Object.Equals((object) element , (object)root.Data))
            {
                return root;
            }

            else if(ComparingGreaterZero(element , root.Data))
            {
                if (root.RightChild == null) return root;

                return SearchTree(root.RightChild, element);
            }
            else
            {
                if(root.LeftChild == null) return root;

                return SearchTree(root.LeftChild, element);
            }
        }
        public bool DeleteTree(T element)
        {
            Node<T> find = SearchTree(this.root , element);
            if (find.Data != element) return false;     //  guard clause for leaf is not element
            
            if(find.LeftChild == null) Transplant(find,find.RightChild);
            else if (find.RightChild == null) Transplant(find, find.LeftChild);

            else
            {
                Node<T> y = TreeMinimum(find.RightChild);
                if(y.Parent != find)
                {
                    Transplant(y, y.RightChild);
                    y.RightChild = find.RightChild;
                    y.RightChild.Parent = y;
                }

                Transplant(find, y);
                y.LeftChild = find.LeftChild;
                y.LeftChild.Parent = y;
            }

            return true;

        }
        private void Transplant(Node<T> original , Node<T> replacement)
        {
            if(original.Parent == null)
            {
                this.root = replacement;
            }
            else if(original == original.Parent.LeftChild)
            {
                original.Parent.LeftChild = replacement;
            }
            else if (original == original.Parent.RightChild)
            {
                original.Parent.RightChild = replacement;
            }

            if(replacement != null)
            {
                replacement.Parent = original.Parent;
            }
        }
        private Node<T> TreeMinimum(Node<T> root)
        {
            while (root.LeftChild != null)
            {
                root = root.LeftChild;
            }
            return root;
        }
        private Node<T> TreeMaximum(Node<T> root)
        {
            while (root.RightChild != null)
            {
                root = root.RightChild;
            }
            return root;
        }

        /// <summary>
        /// Produces a sorted output for the Binary Search Tree. After Execution, use 
        /// the Sorted attribute for accessing the output. Special Sorting criteria 
        /// can be managed by using LINQ method (details in stack overflow thread)
        /// </summary>
        /// <returns>Nothing , void function</returns>
        /// <param name="root"></param>
        public void TraverseInOrder(Node<T> root)
        {
            //Node<T> f = this.root;
            if(root != null)
            {
                TraverseInOrder(root.LeftChild);
                this.sorted.Add(root);
                TraverseInOrder(root.RightChild);
            }
        }
    }
}
