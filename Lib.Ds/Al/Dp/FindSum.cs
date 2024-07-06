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

    public static int[] HowSumWithMemo(int sum, int[] numbers, Dictionary<int, int[]> memo)
    {
        if (memo.ContainsKey(sum)) return memo[sum];
        if (sum == 0) return Array.Empty<int>();
        if (sum < 0) return null;
        for (int i = 0; i < numbers.Length; i++)
        {
            var remainder = sum - numbers[i];
            var result = HowSumWithMemo(remainder, numbers, memo);
            if (result != null)
            {
                memo.Add(remainder, result.Append(numbers[i]).ToArray());
                return memo[remainder];
            }
        }

        memo.Add(sum, null);
        return null;
    }

    public static int[] BestSum(int sum, int[] numbers)
    {
        if (sum == 0) return Array.Empty<int>();
        if (sum < 0) return null;

        int[]? shortestCombination = null;

        for (int i = 0; i < numbers.Length; i++)
        {
            var remainder = sum - numbers[i];
            var result = BestSum(remainder, numbers);
            if (result != null)
            {
                var combination = result.Append(numbers[i]).ToArray();
                if (shortestCombination == null || combination.Length < shortestCombination.Length)
                {
                    shortestCombination = combination;
                }
            }
        }

        return shortestCombination;
    }

    public static int[] BestSumWithMemo(int sum, int[] numbers, Dictionary<int, int[]> memo)
    {
        if(memo.ContainsKey(sum)) return memo[sum];
        if (sum == 0) return Array.Empty<int>();
        if (sum < 0) return null;

        int[]? shortestCombination = null;

        for (int i = 0; i < numbers.Length; i++)
        {
            var remainder = sum - numbers[i];
            var result = BestSumWithMemo(remainder, numbers, memo);
            if (result != null)
            {
                var combination = result.Append(numbers[i]).ToArray();
                if (shortestCombination == null || combination.Length < shortestCombination.Length)
                {
                    shortestCombination = combination;
                }
            }
        }

        memo[sum] = shortestCombination;
        return shortestCombination;
    }
}