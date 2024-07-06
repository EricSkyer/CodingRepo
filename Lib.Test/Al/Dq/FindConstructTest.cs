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

    [TestMethod]
    public void CountConstructTest()
    {
        Assert.AreEqual(1, FindConstruct.CountConstruct("", ["cat", "dog", "mouse"]));

        Assert.AreEqual(1, FindConstruct.CountConstruct("abcdef",
        ["ab", "abc", "cd", "def", "abcd"]));

        Assert.AreEqual(2, FindConstruct.CountConstruct("purple",
        ["purp", "p", "ur", "le", "purpl"]));

        Assert.AreEqual(0, FindConstruct.CountConstruct("skateboard",
        ["bo", "rd", "ate", "t", "ska", "sk", "boar"]));

        Assert.AreEqual(4, FindConstruct.CountConstruct("enterapotentpot",
        ["a", "p", "ent", "enter", "ot", "o", "t"]));

        // Assert.AreEqual(0, FindConstruct.CountConstruct(
        // "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
        // ["e", "ee", "eee", "eeee", "eeeee", "eeeeee"], 0));//slow
    }

    [TestMethod]
    public void CountConstructWithMemoTest()
    {
        Assert.AreEqual(1, FindConstruct.CountConstructWithMemo("", ["cat", "dog", "mouse"], new Dictionary<string, int>()));

        Assert.AreEqual(1, FindConstruct.CountConstructWithMemo("abcdef",
        ["ab", "abc", "cd", "def", "abcd"], new Dictionary<string, int>()));

        Assert.AreEqual(2, FindConstruct.CountConstructWithMemo("purple",
        ["purp", "p", "ur", "le", "purpl"], new Dictionary<string, int>()));

        Assert.AreEqual(0, FindConstruct.CountConstructWithMemo("skateboard",
        ["bo", "rd", "ate", "t", "ska", "sk", "boar"], new Dictionary<string, int>()));

        Assert.AreEqual(4, FindConstruct.CountConstructWithMemo("enterapotentpot",
        ["a", "p", "ent", "enter", "ot", "o", "t"], new Dictionary<string, int>()));

        Assert.AreEqual(0, FindConstruct.CountConstructWithMemo(
        "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef",
        ["e", "ee", "eee", "eeee", "eeeee", "eeeeee"], new Dictionary<string, int>()));
    }

    [TestMethod]
    public void AllConstructTest()
    {
        var result = FindConstruct.AllConstruct("hello", ["cat", "dog", "mouse"]);
        Assert.AreEqual(0, result.Count);

        result = FindConstruct.AllConstruct("", ["cat", "dog", "mouse"]);
        Assert.AreEqual(1, result.Count);

        result = FindConstruct.AllConstruct("purple", ["purp", "p", "ur", "le", "purpl"]);
        Assert.AreEqual(2, result.Count);

        result = FindConstruct.AllConstruct("abcdef", ["ab", "abc", "cd", "def", "abcd", "ef", "c"]);
        Assert.AreEqual(4, result.Count);

        result = FindConstruct.AllConstruct("skateboard", ["bo", "rd", "ate", "t", "ska", "sk", "boar"]);
        Assert.AreEqual(0, result.Count);

        result = FindConstruct.AllConstruct("enterapotentpot", ["a", "p", "ent", "enter", "ot", "o", "t"]);
        Assert.AreEqual(4, result.Count);

        result = FindConstruct.AllConstruct("eeeeeeeeeeeeeeeeeeeeeeeeeef", ["e", "ee", "eee", "eeee", "eeeee"]);
        Assert.AreEqual(0, result.Count);
    }

    [TestMethod]
    public void AllConstructWithMemoTest()
    {
        var result = FindConstruct.AllConstructWithMemo("hello", ["cat", "dog", "mouse"], new Dictionary<string, List<List<string>>>());
        Assert.AreEqual(0, result.Count);

        result = FindConstruct.AllConstructWithMemo("", ["cat", "dog", "mouse"], new Dictionary<string, List<List<string>>>());
        Assert.AreEqual(1, result.Count);

        result = FindConstruct.AllConstructWithMemo("purple", ["purp", "p", "ur", "le", "purpl"], new Dictionary<string, List<List<string>>>());
        Assert.AreEqual(2, result.Count);

        result = FindConstruct.AllConstructWithMemo("abcdef", ["ab", "abc", "cd", "def", "abcd", "ef", "c"], new Dictionary<string, List<List<string>>>());
        Assert.AreEqual(4, result.Count);

        result = FindConstruct.AllConstructWithMemo("skateboard", ["bo", "rd", "ate", "t", "ska", "sk", "boar"], new Dictionary<string, List<List<string>>>());
        Assert.AreEqual(0, result.Count);

        result = FindConstruct.AllConstructWithMemo("enterapotentpot", ["a", "p", "ent", "enter", "ot", "o", "t"], new Dictionary<string, List<List<string>>>());
        Assert.AreEqual(4, result.Count);

        result = FindConstruct.AllConstructWithMemo("eeeeeeeeeeeeeeeeeeeeeeeeeef", ["e", "ee", "eee", "eeee", "eeeee"], new Dictionary<string, List<List<string>>>());
        Assert.AreEqual(0, result.Count);
    }
}