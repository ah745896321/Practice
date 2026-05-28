using System.Text;

public class Solution
{
    public int Reverse(int x)
    {
        int result = 0;
        string s = x.ToString();
        StringBuilder sb = new StringBuilder();
        bool negative=s.StartsWith('-');
        if(negative)
            sb.Append("-");
        foreach (var item in s.Replace("-", "").Reverse())
        {
            sb.Append(item);
        }
        if (Int32.TryParse(sb.ToString(), out result))
            return result;
        else
            return 0;
    }

    static void Main() {
        var a = new Solution();
        Console.WriteLine(a.Reverse(-120));
    }
}