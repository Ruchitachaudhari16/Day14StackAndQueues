namespace StackUsingLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC1 Ability to create a Stack of 56->30->70
            //LIFO
            //56 will be on the top of the stack
            LinkListStack linkListStack = new LinkListStack ();
            linkListStack.Push(70);
            linkListStack.Push(30);
            linkListStack.Push(56);
            linkListStack.Display();
        }
    }
    }
