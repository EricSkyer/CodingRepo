
namespace Lib.Al.Sorting;

public abstract class SortBase<T> : ISort<T>
{
    //sort a
    public abstract void Sort(IComparable<T>[] a);

    //swap i and j in a
    protected void Swap(IComparable<T>[] a, int i, int j)
    {
        var t = a[i];
        a[i] = a[j];
        a[j] = t;
    }

    // is v less then w
    protected bool Less(IComparable<T> v, IComparable<T> w)
    {
        return v.CompareTo((T?)w) < 0;
    }

    //print out a
    public void Print(IComparable<T>[] a)
    {
        System.Diagnostics.Debug.WriteLine(string.Join<IComparable<T>>(' ', a));
    }
}
