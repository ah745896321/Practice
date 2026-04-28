public class Solution
{
    int i1 = 0, i2 = 0;
    int Min(int[] nums1, int[] nums2)
    {
        if (i1 < nums1.Length && i2 < nums2.Length)
        {
            return nums1[i1] < nums2[i2] ? nums1[i1++] : nums2[i2++];
        }
        else if (i1 < nums1.Length)
            return nums1[i1++];
        else if (i2 < nums2.Length)
            return nums2[i2++];
        else
            return -1;
    }
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double result = 0;
        int len = nums1.Length + nums2.Length;
        int half = len / 2;
        if (len % 2 == 1)
        {
            for (int i = 0; i < half; i++)
                Min(nums1, nums2);
            return Min(nums1, nums2);
        }
        else
        {
            for (int i = 0; i < half - 1; i++)
                Min(nums1, nums2);
            return (double)(Min(nums1, nums2) + Min(nums1, nums2)) / 2;
        }
    }
}
public class ConsoleApp4
{

    static int Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.FindMedianSortedArrays([1, 3], [2]));
        return 0;
    }
}