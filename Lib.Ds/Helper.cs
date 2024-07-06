namespace Lib;

public class Helper
{
    public static string Print<T>(T[] a)
    {
        return a == null ? null : string.Join(',', a);
    }
}
