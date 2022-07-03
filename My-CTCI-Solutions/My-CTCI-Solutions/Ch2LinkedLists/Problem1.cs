using System;
namespace My_CTCI_Solutions.Ch2LinkedLists
{
    public class Problem1
    {
        // Write code to remove duplicates from an unsorted linked list.

        public static void RemoveDuplicates(ref Node head)
        {
            Node currentNodePointer = head;

            while (currentNodePointer.GetNextNode() != null)
            {
                Node duplicateRemoverPointer = currentNodePointer;
                while(duplicateRemoverPointer.GetNextNode() != null)
                {
                    if(currentNodePointer.GetValue().Equals(duplicateRemoverPointer.GetNextNode().GetValue()))
                    {
                        duplicateRemoverPointer.SetNextNode(duplicateRemoverPointer.GetNextNode().GetNextNode());
                    }
                    else
                    {
                        duplicateRemoverPointer = duplicateRemoverPointer.GetNextNode();
                    }
                }

                currentNodePointer = currentNodePointer.GetNextNode();
            }

        }
    }
}