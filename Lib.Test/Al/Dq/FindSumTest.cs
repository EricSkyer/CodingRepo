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
        Assert.IsNull(FindSum.HowSum(300, [7, 14]));//slow....
    }
}