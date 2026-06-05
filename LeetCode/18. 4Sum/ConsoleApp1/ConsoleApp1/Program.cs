public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        if (nums == null || nums.Length < 4)
            return new List<IList<int>>();
        int len = nums.Length;
        long sum = 0;
        IList<IList<int>> result = new List<IList<int>>();
        nums.Sort();

        for (int x = 0; x < len - 3; x++)
        {
            if (x > 0 && nums[x] == nums[x - 1])
                continue;
            for (int y = x + 1; y < len - 2; y++)
            {
                if (y > x + 1 && nums[y] == nums[y - 1])
                    continue;
                int i = y + 1;
                int j = len - 1;

                while (i < j)
                {
                    /*if (i-1>x&&nums[i] == nums[i - 1])
                    {
                        i++;
                        continue; 
                    }
                    if (j+1<len-1&&nums[j] == nums[j + 1])
                    {
                        j--;
                        continue;
                    }*/
                    sum = (long)nums[x] + nums[y] + nums[i] + nums[j];
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[x], nums[y], nums[i], nums[j] });
                        i++;
                        while (nums[i] == nums[i - 1] && i < j)
                            i++;

                    }
                    else if (sum > target)
                    {
                        j--;
                        while (nums[j + 1] == nums[j] && i < j)
                            j--;
                    }
                    else if (sum < target)
                    {
                        i++;
                        while (nums[i] == nums[i - 1] && i < j)
                            i++;
                    }

                }
            }
        }
        return result;
    }
static void Main() {
        var a = new Solution();
        Console.WriteLine(a.FourSum([1, 0, -1, 0, -2, 2],0));
    }
}