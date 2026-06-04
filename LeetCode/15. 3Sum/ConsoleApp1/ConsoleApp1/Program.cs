using System.Text;
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        if (nums==null||nums.Length<3)
            return new List<IList<int>>();
        int len = nums.Length;
        int sum = 0;
        IList<IList<int>> result = new List<IList<int>>();
        nums.Sort();
        
        for (int x = 0; x < len-2; x++)
        {
            if (x>0&&nums[x] == nums[x - 1])
                continue;
            int i = x + 1;
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
                sum = nums[x] + nums[i] + nums[j];
                if (sum == 0)
                {
                    result.Add(new List<int> { nums[x], nums[i], nums[j] });
                    i++;
                    while (nums[i] == nums[i - 1] && i < j)
                        i++;

                }
                else if (sum > 0)
                { 
                    j--;
                    while (i < j&&nums[j + 1] == nums[j] )
                        j--;
                }
                else if (sum < 0)
                {
                    i++;
                    while (i < j && nums[i] == nums[i - 1])
                        i++;
                }
                
            }
        }
        return result;
    }




static void Main() {
        var a = new Solution();
        Console.WriteLine(a.ThreeSum([-1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4]));
    }
}