
public class Solution
{
    public string LongestPalindrome(string s)
    {
        int center = -1;
        int right = -1;
        string temp = "#";
        foreach (char a in s)
        {
            temp += a;
            temp += "#";
        }
        List<int> dp = new int[temp.Length].ToList();
        for (int i = 0; i < temp.Length; i++)
        {
            int r = 0;
            if (i <= right)
            {
                r = Math.Min(dp[center * 2 - i],right-i); //對稱回文至少有相同長度，不須重頭計算  長度最長為該節點至回文邊界 即right-i
                while (i+r<temp.Length&&i-r>=0&&temp[i - r] == temp[i + r]) //邊界檢查
                {
                    r++;
                }
                dp[i] = --r;    
            }
            else 
            {
                r = 0; //重頭計算
                while (i + r < temp.Length && i - r >= 0 && temp[i - r] == temp[i + r])
                {
                    r++;
                }
                dp[i] = --r;
            }
            if (i + dp[i] > right)//突破邊界
            {
                right = dp[i]+i;
                center = i;
            }
        }
        int max = dp.Max();
        int point = dp.IndexOf(max);
        return temp.Substring(point - max, 1 + 2 * max).Replace("#", "");

    }
    static void Main() {
        var a = new Solution();
        Console.WriteLine(a.LongestPalindrome("babad"));
    }
}