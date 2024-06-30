namespace Lib.Al.Dp;

public class FindConstruct
{
    public static bool CanConstructBuildUp(string target, string[] wordbank, string construct)
    {
        if (target == construct) return true;
        if (target.Length < construct.Length) return false;

        for (int i = 0; i < wordbank.Length; i++)
        {
            var result = $"{construct}{wordbank[i]}";
            if (target.StartsWith(result))
            {
                if (CanConstructBuildUp(target, wordbank, result))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool CanConstruct(string target, string[] wordbank)
    {
        if (target == string.Empty) return true;

        for (int i = 0; i < wordbank.Length; i++)
        {
            if (target.StartsWith(wordbank[i]))
            {
                var remaining = target.Substring(wordbank[i].Length);
                if (CanConstruct(remaining, wordbank))
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool CanConstructWithMemo(string target, string[] wordbank, Dictionary<string, bool> memo)
    {
        if (memo.ContainsKey(target)) return memo[target];
        if (target == string.Empty) return true;

        for (int i = 0; i < wordbank.Length; i++)
        {
            if (target.StartsWith(wordbank[i]))
            {
                var remaining = target.Substring(wordbank[i].Length);
                if (CanConstructWithMemo(remaining, wordbank, memo))
                {
                    memo.Add(target, true);
                    return true;
                }
            }
        }

        memo.Add(target, false);
        return false;
    }

    public static int CountConstruct(string target, string[] wordbank, int count)
    {
        if (target == string.Empty) return count++;

        for (int i = 0; i < wordbank.Length; i++)
        {
            if (target.StartsWith(wordbank[i]))
            {
                var remaining = target.Substring(wordbank[i].Length);
                return CountConstruct(remaining, wordbank, count);
            }
        }

        return count;
    }
}