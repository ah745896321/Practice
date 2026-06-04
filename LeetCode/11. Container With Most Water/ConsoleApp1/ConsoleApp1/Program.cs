using System.Text;
public class Solution
{
    public int MaxArea(int[] height)
    {
        int len = height.Length;
        int left = 0;
        int right = len - 1;
        int temp = 0;
        int area = 0;
        int Max_area = Math.Min(height[left], height[right]) * (right - left);
        while (left < right)
        {
            if (height[left] > height[right])
            {
                right--;
                Max_area = Math.Max(Max_area, Math.Min(height[left], height[right]) * (right - left));
            }
            else
            {
                left++;
                Max_area = Math.Max(Max_area, Math.Min(height[left], height[right]) * (right - left));
            }
        }
        return Max_area;
    }


static void Main() {
        var a = new Solution();
        Console.WriteLine(a.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));
    }
}