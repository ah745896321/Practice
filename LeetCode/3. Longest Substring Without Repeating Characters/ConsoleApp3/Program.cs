public class Solution
{
    public static string LengthOfLongestSubstring(string s)
    {
        string result = "";
        string temp;
        if (s == null || s.Length == 0)
            return result;
        for (int i = 0; i < s.Length; i++)
        {
            temp = "";
            for (int i2 = i; i2 < s.Length; i2++)
            {
                if (temp.IndexOf(s[i2]) == -1)
                    temp += s[i2];
                else
                    break;
            }
            if (result.Length < temp.Length)
                result = temp;
        }


            return result;
    }
}
public class ConsoleApp3
{

    static int Main() 
    {
        Console.WriteLine(Solution.LengthOfLongestSubstring("pwwkew"));
        return 0;
    }
}