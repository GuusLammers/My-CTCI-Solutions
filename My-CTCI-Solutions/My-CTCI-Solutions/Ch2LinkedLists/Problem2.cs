using System;
namespace My_CTCI_Solutions.Ch2LinkedLists
{
    public class Problem2
    {
        public static void RemoveKthToLastElement(ref Node head, int k)
        {
            // assume first element is element 0
            Node leadPointer = head;
            Node followPointer = head;

            // move lead pointer by k elements
            for(int i = 1; i < k; i++)
            {
                if(leadPointer.GetNextNode() == null)
                {
                    throw new ArgumentException("k is larger then length of linked list");
                }

                leadPointer = leadPointer.GetNextNode();
            }

            // move lead pointer and follow pointer until lead pointer reaches end of linked list
            while(leadPointer.GetNextNode() != null)
            {
                leadPointer = leadPointer.GetNextNode();

                if(leadPointer.GetNextNode() != null)
                {
                    followPointer = followPointer.GetNextNode();
                }
            }

            // remove kth element from end of the linked list
            followPointer.SetNextNode(followPointer.GetNextNode().GetNextNode());
        }
    }
}

