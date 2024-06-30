using Lib.Al.Dp;
namespace Lib.Test.Al.Dp;

[TestClass]
public class FindConstructTest
{
    [TestMethod]
    public void CanConstructBuildUpTest()
    {
        Assert.IsTrue(FindConstruct.CanConstructBuildUp("", ["cat", "dog", "mouse"], ""));

        Assert.IsTrue(FindConstruct.CanConstructBuildUp("abcdef",
        ["ab", "abc", "cd", "def", "abcd"], ""));

        Assert.IsFalse(FindConstruct.CanConstructBuildUp("skateboard",
        ["bo", "rd", "ate", "t", "ska", "sk", "boar"], ""));

        Assert.IsTrue(FindConstruct.CanConstructBuildUp("enterapotentpot",
        ["a", "p", "ent", "enter", "ot", "o", "t"], ""));

        Assert.IsFalse(FindConstruct.CanConstructBuildUp(
        "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
        ["e", "ee", "eee", "eeee", "eeeee", "eeeeee"], ""));
    }

    [TestMethod]
    public void CanConstructTest()
    {
        Assert.IsTrue(FindConstruct.CanConstruct("", ["cat", "dog", "mouse"]));

        Assert.IsTrue(FindConstruct.CanConstruct("abcdef",
        ["ab", "abc", "cd", "def", "abcd"]));

        Assert.IsFalse(FindConstruct.CanConstruct("skateboard",
        ["bo", "rd", "ate", "t", "ska", "sk", "boar"]));

        Assert.IsTrue(FindConstruct.CanConstruct("enterapotentpot",
        ["a", "p", "ent", "enter", "ot", "o", "t"]));

        // Assert.IsFalse(FindConstruct.CanConstruct(
        // "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
        // ["e", "ee", "eee", "eeee", "eeeee", "eeeeee"]));//slow
    }

    [TestMethod]
    public void CanConstructWithMemoTest()
    {
        Assert.IsTrue(FindConstruct.CanConstructWithMemo("", ["cat", "dog", "mouse"], new Dictionary<string, bool>()));

        Assert.IsTrue(FindConstruct.CanConstructWithMemo("abcdef",
        ["ab", "abc", "cd", "def", "abcd"], new Dictionary<string, bool>()));

        Assert.IsFalse(FindConstruct.CanConstructWithMemo("skateboard",
        ["bo", "rd", "ate", "t", "ska", "sk", "boar"], new Dictionary<string, bool>()));

        Assert.IsTrue(FindConstruct.CanConstructWithMemo("enterapotentpot",
        ["a", "p", "ent", "enter", "ot", "o", "t"], new Dictionary<string, bool>()));

        Assert.IsFalse(FindConstruct.CanConstructWithMemo(
        "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
        ["e", "ee", "eee", "eeee", "eeeee", "eeeeee"], new Dictionary<string, bool>()));
    }
}