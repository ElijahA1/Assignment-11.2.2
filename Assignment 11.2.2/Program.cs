using Assignment_11._2._2;

namespace Assignment_11._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList linkedList = new();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);

            linkedList.DisplayAll();

            Console.WriteLine("\n\nReversed:\n");
            linkedList.Reverse();
            linkedList.DisplayAll();

            Console.ReadKey();

        }
    }
}
// REVERSE CODE REFLECTED IN THE SINGLE LINKED LIST CLASS

//public void Reverse()
//{
//    if (head == null || head.NextNode == null)
//        return;

//    Node prev = null;
//    Node temp = head;
//    Node next = null;

//    while (temp != null)
//    {
//        next = temp.NextNode;
//        temp.NextNode = prev;
//        prev = temp;
//        temp = next;
//    }

//    head = prev;
//}