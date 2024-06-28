using Lib.Al.Dp;

namespace Lib.Test.Al.Dp;

[TestClass]
public class GridTravellerTest
{
    [TestMethod]
    public void TravelTest()
    {
        var actual = GridTraveller.Travel(1, 1);
        Assert.AreEqual(1, actual);

        actual = GridTraveller.Travel(2, 3);
        Assert.AreEqual(3, actual);

        actual = GridTraveller.Travel(3, 2);
        Assert.AreEqual(3, actual);

        actual = GridTraveller.Travel(3, 3);
        Assert.AreEqual(6, actual);

        // actual = GridTraveller.Travel(18, 18);//slow.......
        // Assert.AreEqual(2333606220, actual);
    }

    [TestMethod]
    public void TravelWithMemoTest()
    {
        var actual = GridTraveller.TravelWithMemo(1, 1);
        Assert.AreEqual(1, actual);

        actual = GridTraveller.TravelWithMemo(2, 3);
        Assert.AreEqual(3, actual);

        actual = GridTraveller.TravelWithMemo(3, 2);
        Assert.AreEqual(3, actual);

        actual = GridTraveller.TravelWithMemo(3, 3);
        Assert.AreEqual(6, actual);

        actual = GridTraveller.TravelWithMemo(18, 18);
        Assert.AreEqual(2333606220, actual);
    }
}