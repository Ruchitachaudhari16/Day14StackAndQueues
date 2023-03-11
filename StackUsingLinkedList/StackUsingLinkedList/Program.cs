using QueueUsingLinkedList;

namespace StackUsingLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC3 Ability to create a Queue of 56->30->70
            //FIFO

            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();// this.top=this.top.next
            Console.ReadKey();

        }
    }
}
