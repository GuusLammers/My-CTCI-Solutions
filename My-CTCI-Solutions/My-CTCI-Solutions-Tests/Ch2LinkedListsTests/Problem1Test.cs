using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch2LinkedLists;

namespace My_CTCI_Solutions_Tests.Ch2LinkedListsTests
{
    [TestClass]
    public class Problem1Test
    {
        public static bool Equal(Node head1, Node head2)
        {
            Node currentNode1 = head1;
            Node currentNode2 = head2;
            while(currentNode1.GetNextNode() != null || currentNode2.GetNextNode() != null)
            {
                if(!currentNode1.GetValue().Equals(currentNode2.GetValue()))
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

        [TestMethod]
        public void RemoveDuplicatesTest1()
        {
            // arrange
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

            Node headExpected = new Node(4);
            headExpected.AppendToTail(6);
            headExpected.AppendToTail(3);
            headExpected.AppendToTail(5);
            headExpected.AppendToTail(1);
            headExpected.AppendToTail(7);
            headExpected.AppendToTail(9);

            // act
            Problem1.RemoveDuplicates(ref head);

            // assert
            Assert.AreEqual(true, Equal(head, headExpected));
        }

        [TestMethod]
        public void RemoveDuplicatesTest2()
        {
            // arrange
            Node head = new Node(4);
            head.AppendToTail(6);
            head.AppendToTail(6);
            head.AppendToTail(6);
            head.AppendToTail(6);
            head.AppendToTail(6);
            head.AppendToTail(6);
            head.AppendToTail(6);
            head.AppendToTail(6);
            head.AppendToTail(6);
            head.AppendToTail(12);

            Node headExpected = new Node(4);
            headExpected.AppendToTail(6);
            headExpected.AppendToTail(12);

            // act
            Problem1.RemoveDuplicates(ref head);

            // assert
            Assert.AreEqual(true, Equal(head, headExpected));
        }
    }
}

