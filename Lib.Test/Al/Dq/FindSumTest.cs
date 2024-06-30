using Lib.Al.Dp;

namespace Lib.Test.Al.Dp;

[TestClass]
public class FindSumTest
{
    [TestMethod]
    public void CanSumTest()
    {
        Assert.IsTrue(FindSum.CanSum(7, [2, 3]));
        Assert.IsTrue(FindSum.CanSum(7, [5, 3, 4, 7]));
        Assert.IsFalse(FindSum.CanSum(7, [2, 4]));
        Assert.IsTrue(FindSum.CanSum(8, [2, 3, 5]));
        //Assert.IsFalse(CanSum.FindSum(300, [7, 14]));//slow....
    }

    [TestMethod]
    public void HowSumTest()
    {
        Assert.IsNotNull(FindSum.HowSum(7, [2, 3]));
        Assert.IsNotNull(FindSum.HowSum(7, [5, 3, 4, 7]));
        Assert.IsNull(FindSum.HowSum(7, [2, 4]));
        Assert.IsNotNull(FindSum.HowSum(8, [2, 3, 5]));
        //Assert.IsNull(FindSum.HowSum(300, [7, 14]));//slow....
    }

    [TestMethod]
    public void HowSumWithMemoTest()
    {
        Assert.IsNotNull(FindSum.HowSumWithMemo(7, [2, 3], new Dictionary<int, int[]>()));
        Assert.IsNotNull(FindSum.HowSumWithMemo(7, [5, 3, 4, 7], new Dictionary<int, int[]>()));
        Assert.IsNull(FindSum.HowSumWithMemo(7, [2, 4], new Dictionary<int, int[]>()));
        Assert.IsNotNull(FindSum.HowSumWithMemo(8, [2, 3, 5], new Dictionary<int, int[]>()));
        //Assert.IsNull(FindSum.HowSumWithMemo(300, [7, 14], new Dictionary<int, int[]>()));//slow....
    }

    [TestMethod]
    public void BestSumTest()
    {
        Assert.AreEqual("7", FindSum.Print(FindSum.BestSum(7, [5, 3, 4, 7])));
        Assert.AreEqual("5,3", FindSum.Print(FindSum.BestSum(8, [2, 3, 5])));
        Assert.AreEqual("4,4", FindSum.Print(FindSum.BestSum(8, [1, 4, 5])));
        //Assert.AreEqual("25,25,25,25", FindSum.Print(FindSum.BestSum(100, [1, 2, 5, 25])));//slow
    }

    [TestMethod]
    public void BestSumWithMemoTest()
    {
        Assert.AreEqual("7", FindSum.Print(FindSum.BestSumWithMemo(7, [5, 3, 4, 7], new Dictionary<int, int[]>())));
         Assert.AreEqual("5,3", FindSum.Print(FindSum.BestSumWithMemo(8, [2, 3, 5], new Dictionary<int, int[]>())));
        Assert.AreEqual("4,4", FindSum.Print(FindSum.BestSumWithMemo(8, [1, 4, 5], new Dictionary<int, int[]>())));
        Assert.AreEqual("25,25,25,25", FindSum.Print(FindSum.BestSumWithMemo(100, [1, 2, 5, 25],new Dictionary<int, int[]>())));
    }
}