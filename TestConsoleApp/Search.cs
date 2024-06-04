using System.ComponentModel;

public class Search
{
    public static int LinearSearch(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                return i;
            }
        }
        return -1;
    }

    public static int BinarySearch(int[] numbers, int target)
    {
        int first = 0;
        int last = numbers.Length - 1;
        int middle;
        while (first <= last)
        {
            middle = (first + last) / 2;
            if (target == numbers[middle])
            {
                return middle;
            }
            if (target < numbers[middle])
            {
                last = middle - 1;
            }
            else
            {
                first = middle + 1;
            }
        }
        return -1;
    }

    public static bool RecursiveBinarySearch(int[] numbers, int target, int first, int last)
    {
        if (first > last)
        {
            return false;
        }
        int middle = (first + last) / 2;
        if (target == numbers[middle])
        {
            return true;
        }
        if (target < numbers[middle])
        {
            return RecursiveBinarySearch(numbers, target, first, middle - 1);
        }
        else
        {
            return RecursiveBinarySearch(numbers, target, middle + 1, last);
        }
    }
}