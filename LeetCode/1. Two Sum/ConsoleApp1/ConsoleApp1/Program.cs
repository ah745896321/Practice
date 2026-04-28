public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length; i++)
        {
            int index = nums.IndexOf(target - nums[i]);
            if (index >= 0 && index != i)
            {
                return [i, index];

            }
        }
        return [0, 0];
    }
}
public class ConsoleApp1
{
    public static int Main()
    {
        Solution solution = new Solution();
        Console.Write(solution.TwoSum([2, 7, 11, 15],9));
        return 0;
    }
}