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

    public static int CountConstructOwn(string target, string[] wordbank, int count)
    {
        if (target == string.Empty) return ++count;

        int keep = count;

        for (int i = 0; i < wordbank.Length; i++)
        {
            if (target.StartsWith(wordbank[i]))
            {
                var remaining = target.Substring(wordbank[i].Length);
                keep = keep + CountConstructOwn(remaining, wordbank, count);
            }
        }

        return keep;
    }


    public static int CountConstruct(string target, string[] wordbank)
    {
        if (target == string.Empty) return 1;

        int total = 0;
        for (int i = 0; i < wordbank.Length; i++)
        {
            if (target.StartsWith(wordbank[i]))
            {
                var remaining = target.Substring(wordbank[i].Length);
                total = total + CountConstruct(remaining, wordbank);
            }
        }

        return total;
    }

    public static int CountConstructWithMemo(string target, string[] wordbank, Dictionary<string, int> memo)
    {
        if (memo.ContainsKey(target)) return memo[target];
        if (target == string.Empty) return 1;

        int total = 0;
        for (int i = 0; i < wordbank.Length; i++)
        {
            if (target.StartsWith(wordbank[i]))
            {
                var remaining = target.Substring(wordbank[i].Length);
                total = total + CountConstructWithMemo(remaining, wordbank, memo);
            }
        }

        memo.Add(target, total);
        return total;
    }

    //use List<List<string>> instead of int[,], easy to modify 2D array
    public static List<List<string>> AllConstruct(string target, string[] wordbank)
    {
        if (target == string.Empty) return new List<List<string>>() { new List<string>() };

        List<List<string>> all = new List<List<string>>();
        for (int i = 0; i < wordbank.Length; i++)
        {
            if (target.StartsWith(wordbank[i]))
            {
                string remaining = target.Substring(wordbank[i].Length);
                List<List<string>> ways = AllConstruct(remaining, wordbank);
                if (ways != null)
                {
                    for (int j = 0; j < ways.Count; j++)
                    {
                        ways[j].Insert(0, wordbank[i]);
                    }
                    all.AddRange(ways);
                }
            }
        }

        return all;
    }

    public static List<List<string>> AllConstructWithMemo(string target, string[] wordbank, Dictionary<string, List<List<string>>> memo)
    {
        if(memo.ContainsKey(target)) return memo[target];
        if (target == string.Empty) return new List<List<string>>() { new List<string>() };

        List<List<string>> all = new List<List<string>>();
        for (int i = 0; i < wordbank.Length; i++)
        {
            if (target.StartsWith(wordbank[i]))
            {
                string remaining = target.Substring(wordbank[i].Length);
                List<List<string>> ways = AllConstructWithMemo(remaining, wordbank, memo);
                if (ways != null)
                {
                    for (int j = 0; j < ways.Count; j++)
                    {
                        ways[j].Insert(0, wordbank[i]);
                    }
                    all.AddRange(ways);
                }
            }
        }
        
        memo.Add(target, all);
        return all;
    }
}