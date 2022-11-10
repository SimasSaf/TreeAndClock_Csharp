using GenericTree;

namespace TestGenericTree.UnitTest;

//Node ordering looks like this:
//              1
//             / \
//           2     3
//          /     /|\
//         4     5 6 7
//              /  /\
//             8  9  10
//                    \
//         
public class BranchTest
{
    Branch node1 = new Branch();
    Branch node2 = new Branch();
    Branch node3 = new Branch();
    Branch node4 = new Branch();
    Branch node5 = new Branch();
    Branch node6 = new Branch();
    Branch node7 = new Branch();
    Branch node8 = new Branch();
    Branch node9 = new Branch();
    Branch node10 = new Branch();
    Branch node11 = new Branch();
    
    [SetUp]
    public void Setup()
    {
        node1.AddBranch(node2);
        node1.AddBranch(node3);

        node2.AddBranch(node4);

        node3.AddBranch(node5);
        node3.AddBranch(node6);
        node3.AddBranch(node7);

        node5.AddBranch(node8);

        node6.AddBranch(node9);
        node6.AddBranch(node10);

        node9.AddBranch(node11);
    }
    //I did not set up a deletion method, but it would also traverse the tree
    //and delete elements from the bottom to the top

    [Test]
    public void depthFromNode1AsPresentedInAssignment()
    {
        Assert.AreEqual(5, node1.GetDepth());
    }

    //Some more exceptional cases:
    [Test]
    public void depthFromNode2()
    {
        Assert.AreEqual(2, node2.GetDepth());
    }

    [Test]
    public void depthFromNode3()
    {
        Assert.AreEqual(4, node3.GetDepth());
    }

    [Test]
    public void depthFromNode4()
    {
        Assert.AreEqual(1, node4.GetDepth());
    }

    [Test]
    public void depthFromNode6()
    {
        Assert.AreEqual(3, node6.GetDepth());
    }
}