namespace Lib.Al.Dp;

public class Fibonacci
{
    public static int GetFib(int n)
    {
        if (n <= 2) return 1;
        return GetFib(n - 1) + GetFib(n - 2);
    }

    private static Dictionary<int, int> _memo = new Dictionary<int, int>();
    public static int GetFibWithMemo(int n)
    {
        if(_memo.ContainsKey(n)) return _memo[n];
        if (n <= 2) return 1;
        _memo.Add(n,GetFib(n - 1) + GetFib(n - 2));
        return _memo[n];
    }
}