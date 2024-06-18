namespace Lib.Test;

using Lib.Ds;

[TestClass]
public class LinkedListTest
{
    private LinkedList<int> _target = new LinkedList<int>();

    [TestMethod]
    public void TestEmpty()
    {
        _target = new LinkedList<int>();
        Assert.IsTrue(_target.IsEmpty());

        _target.Header = new Node<int>();
        Assert.IsFalse(_target.IsEmpty());
    }

    [TestMethod]
    public void TestSize()
    {
        _target = new LinkedList<int>();
        Assert.AreEqual(_target.Size(), 0);

        _target.Add(1);
        Assert.AreEqual(_target.Size(), 1);

        _target.Add(2);
        Assert.AreEqual(_target.Size(), 2);
    }

    [TestMethod]
    public void TestToString()
    {
        _target = new LinkedList<int>(1);
        _target.Add(2);
        _target.Add(3);
        Assert.AreEqual(_target.ToString(), "3->2->1");
    }

    [TestMethod]
    public void TestSearch()
    {
        _target = new LinkedList<int>(1);
        _target.Add(2);
        _target.Add(3);

        Assert.IsNotNull(_target.Search(1));
        Assert.IsNotNull(_target.Search(2));
        Assert.IsNotNull(_target.Search(3));
        Assert.IsNull(_target.Search(4));
    }

    [TestMethod]
    public void TestInsert()
    {
        _target = new LinkedList<int>(1);
        _target.Add(2);
        _target.Add(3);

        _target.Insert(4, 0);
        Assert.AreEqual(_target.ToString(), "4->3->2->1");

        _target.Insert(5, 2);
        Assert.AreEqual(_target.ToString(), "4->3->5->2->1");

        _target.Insert(6, 4);
        Assert.AreEqual(_target.ToString(), "4->3->5->2->6->1");

        _target.Insert(7, 6);
        Assert.AreEqual(_target.ToString(), "4->3->5->2->6->1->7");
    }


    [TestMethod]
    public void TestRemove()
    {
        _target = new LinkedList<int>(1);
        _target.Add(2);
        _target.Add(3);
        _target.Add(3);
        _target.Add(4);
        _target.Add(5);

        Node<int> node = _target.Remove(5);
        Assert.AreEqual(node.Data, 5);
        Assert.AreEqual(_target.ToString(), "4->3->3->2->1");

        node = _target.Remove(3);
        Assert.AreEqual(node.Data, 3);
        Assert.AreEqual(_target.ToString(), "4->3->2->1");

        node = _target.Remove(1);
        Assert.AreEqual(node.Data, 1);
        Assert.AreEqual(_target.ToString(), "4->3->2");
    }
}