namespace My_CTCI_Solutions.Ch2LinkedLists
{
    public class Node
    {
        Node? next = null;
        int value;

        public Node(int value)
        {
            this.value = value;
        }

        public void AppendToTail(int value)
        {
            Node newNode = new(value);
            Node currentNode = this;
            while(currentNode.next != null)
            {
                currentNode = currentNode.next;
            }

            currentNode.next = newNode;
        }

        public Node GetNextNode()
        {
            return next;
        }

        public void SetNextNode(Node node)
        {
            this.next = node;
        }

        public int GetValue()
        {
            return this.value;
        }

        public static bool Equal(Node head1, Node head2)
        {
            Node currentNode1 = head1;
            Node currentNode2 = head2;
            while (currentNode1.GetNextNode() != null || currentNode2.GetNextNode() != null)
            {
                if (!currentNode1.GetValue().Equals(currentNode2.GetValue()))
                {
                    return false;
                }

                currentNode1 = currentNode1.GetNextNode();
                currentNode2 = currentNode2.GetNextNode();
            }

            if (currentNode1.GetNextNode() == null && currentNode2.GetNextNode() != null)
            {
                return false;
            }
            if (currentNode1.GetNextNode() != null && currentNode2.GetNextNode() == null)
            {
                return false;
            }

            return true;
        }
    }
}

