public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var low = 0;
        var high = numbers.Length - 1;
        while(low <= high)
        {
            var result = numbers[low] + numbers[high];
            if (result > target)
            {
                high--;
            }
            else if (result < target)
            {
                low++;
            }
            else
            {
                return new int[] { low+1, high+1 };
            }
        }
        throw new Exception("target not found");
    }
}