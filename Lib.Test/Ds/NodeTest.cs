using Lib.Ds;

namespace Lib.Test;

[TestClass]
public class NodeTest
{
    private Node<int> _target = new Node<int>(1);

    [TestMethod]
    public void TestMethod1()
    {
        _target = new Node<int>(1);
        Assert.AreEqual(_target.ToString(), "1");
    }
}