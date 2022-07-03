using Microsoft.VisualStudio.TestTools.UnitTesting;
using My_CTCI_Solutions.Ch2LinkedLists;

namespace My_CTCI_Solutions_Tests.Ch2LinkedListsTests
{
    [TestClass]
    public class Problem2Test
    {
        [TestMethod]
        public void RemoveRemoveKthToLastElementTest1()
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
            headExpected.AppendToTail(6);
            headExpected.AppendToTail(1);
            headExpected.AppendToTail(3);
            headExpected.AppendToTail(4);
            headExpected.AppendToTail(5);
            headExpected.AppendToTail(9);

            int k = 4;

            // act
            Problem2.RemoveKthToLastElement(ref head, k);

            // assert
            Assert.AreEqual(true, Node.Equal(head, headExpected));
        }
    }
}

