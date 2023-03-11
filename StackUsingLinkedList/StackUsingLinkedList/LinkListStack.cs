using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingLinkedList
{
    internal class LinkListStack
    {
        public Node Top;
        //push :- Insert an element in a stack 
        public void Push(int data)
        {
            Node node = new Node(data);
            if (this.Top == null)
            {
                node.Next = null;
            }
            else
            {
                node.Next = this.Top;
                this.Top = node;
            }
            Console.WriteLine("{0} pushes to stack", data);
        }

        public void Display()
        {
            Node temp = this.Top;
            while (temp != null)
            {

                temp = temp.Next;
                Console.WriteLine(temp.Data + " ");
            }
        }
        //peek :- It returns the element at the given position 
        internal void Peek()
        {
            if (this.Top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.Top.Data);
        }
        //pop :- Delete an element from the stack 
        internal void Pop()
        {
            if (this.Top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.Top.Next);
            this.Top = this.Top.Next;
        }
        //IsEmpty :- It determines wheather the stack is full or not.
        internal void IsEmpty()
        {
            while (this.Top != null)
            {
                Peek();
                Pop();
            }
        }

    }
}
