namespace StackUsingLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC2 Ability to peak and pop from the Stack till it is empty56->30->70
            //LIFO

            LinkListStack linkListStack = new LinkListStack();
            linkListStack.Push(70);
            linkListStack.Push(30);
            linkListStack.Push(56);
            linkListStack.Peek();
            linkListStack.Pop();
            linkListStack.Display();

        }
    }
}
