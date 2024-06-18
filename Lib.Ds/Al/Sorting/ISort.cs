namespace Lib.Al.Sorting;

public interface ISort<T>
{
    void Sort(IComparable<T>[] a);
}