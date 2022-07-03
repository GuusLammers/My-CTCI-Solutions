using My_CTCI_Solutions.Ch1ArraysStrings;
using My_CTCI_Solutions.Ch2LinkedLists;

namespace My_CTCI_Solutions
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Node head = new Node(4);
            head.AppendToTail(6);
            head.AppendToTail(3);
            head.AppendToTail(5);
            head.AppendToTail(6);
            head.AppendToTail(1);
            head.AppendToTail(3);
            head.AppendToTail(7);
            head.AppendToTail(4);
            head.AppendToTail(5);
            head.AppendToTail(9);

            Ch2LinkedLists.Problem1.RemoveDuplicates(ref head);

            Node pointer = head;
            while(pointer.GetNextNode() != null)
            {
                Console.WriteLine(pointer.GetValue());
                pointer = pointer.GetNextNode();
            }
        }
    }
}


