namespace Lib.Al.Dp;

public class GridTraveller
{
    public static long Travel(int m, int n)
    {
        if (m == 1 && n == 1) return 1;
        if (m == 0 || n == 0) return 0;
        return Travel(m - 1, n) + Travel(m, n - 1);
    }

    private static Dictionary<string, long> _memo = new Dictionary<string, long>();
    public static long TravelWithMemo(int m, int n)
    {
        var key = $"{m}.{n}";
        if (_memo.ContainsKey(key)) return _memo[key];

        if (m == 1 && n == 1) return 1;
        if (m == 0 || n == 0) return 0;
        _memo.Add(key, Travel(m - 1, n) + Travel(m, n - 1));
        return _memo[key];
    }
}