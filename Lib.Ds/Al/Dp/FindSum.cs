namespace Lib.Al.Dp;

public class FindSum
{
    public static bool CanSum(int sum, int[] numbers)
    {
        if (sum == 0) return true;
        if (sum < 0) return false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (CanSum(sum - numbers[i], numbers))
            {
                return true;
            }
        }
        return false;
    }

    public static int[] HowSum(int sum, int[] numbers)
    {
        if (sum == 0) return Array.Empty<int>();
        if (sum < 0) return null;

        for (int i = 0; i < numbers.Length; i++)
        {
            var remainder = sum - numbers[i];
            var result = HowSum(remainder, numbers);
            if (result != null)
            {
                return result.Append(numbers[i]).ToArray();
            }
        }

        return null;
    }
}
