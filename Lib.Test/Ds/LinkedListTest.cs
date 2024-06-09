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
}