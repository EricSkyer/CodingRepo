using System.Diagnostics;
using Lib.Al.Dp;

namespace Lib.Test.Al.Dp;

[TestClass]
public class NodeTest
{
    [TestMethod]
    public void TestGetFib()
    {
        var f = Fibonacci.GetFib(6);
        Assert.AreEqual(f, 8);

        f = Fibonacci.GetFib(7);
        Assert.AreEqual(f, 13);

        f = Fibonacci.GetFib(8);
        Assert.AreEqual(f, 21);
    }

        [TestMethod]
    public void TestGetFibLarge()
    {
        // var f = Fib.GetFib(50);//slow.....
        // Debug.WriteLine(f);
        // Debug.WriteLine("Done");
        //Assert.AreEqual(f, 8);
    }

            [TestMethod]
    public void TestGetMemoFib()
    {
        var f = Fibonacci.GetFibWithMemo(50);
        Debug.WriteLine(f);
        Debug.WriteLine("Done");
    }
}