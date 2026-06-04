public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        {
            int len = nums.Length;
            int sum = 0;
            int close = nums[0] + nums[1] + nums[2];
            nums.Sort();

            for (int x = 0; x < len - 2; x++)
            {
                int i = x + 1;
                int j = len - 1;

                while (i < j)
                {
                    sum = nums[x] + nums[i] + nums[j];
                    if (sum == target)
                    {
                        return target;
                    }
                    else if (sum > target)
                    {
                        close = Math.Abs(sum - target) < Math.Abs(close - target) ? sum : close;
                        j--;
                    }
                    else if (sum < target)
                    {
                        close = Math.Abs(sum - target) < Math.Abs(close - target) ? sum : close;
                        i++;
                    }
                }
            }
            return close;
        }
    }
static void Main() {
        var a = new Solution();
        Console.WriteLine(a.ThreeSumClosest([-1, 2, 1, -4],1));
    }
}