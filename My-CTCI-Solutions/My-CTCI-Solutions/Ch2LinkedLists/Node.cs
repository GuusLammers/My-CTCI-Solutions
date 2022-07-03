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
    }
}

