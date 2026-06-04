using System.Text;

public class Solution
{
    int Cross_Count = 0;
    public List<string> ToLetter(char a)
    {
        switch (a)
        {
            case '2':
                return new List<string> { "a", "b", "c" };
            case '3':
                return new List<string> { "d", "e", "f" };
            case '4':
                return new List<string> { "g", "h", "i" };
            case '5':
                return new List<string> { "j", "k", "l" };
            case '6':
                return new List<string> { "m", "n", "o" };
            case '7':
                return new List<string> { "p", "q", "r", "s" };
            case '8':
                return new List<string> { "t", "u", "v" };
            case '9':
                return new List<string> { "w", "x", "y", "z" };
            default:
                return new List<string> { };
        }
    }
    public string CrossJoin(string s, char c)
    {
        StringBuilder sb = new StringBuilder();
        if (Cross_Count > 0)
        {
            for (int i = 0; i < s.Length; i += Cross_Count)
                foreach (string x in ToLetter(c))
                {
                    sb.Append(s.Substring(i, Cross_Count));
                    sb.Append(x);
                }
            Cross_Count++;
        }
        else
        {
            Cross_Count++;
            return String.Join("", ToLetter(c));
        }
        return sb.ToString();
    }
    public IList<string> LetterCombinations(string digits)
    {
        StringBuilder sb = new StringBuilder();
        string result = "";
        List<string> ans = new List<string>();
        foreach (char c in digits)
        {
            result = CrossJoin(result, c);
        }
        for (int i = 0; i < result.Length; i += digits.Length)
        {
            ans.Add(result.Substring(i, digits.Length));
        }
        return ans;
    }


static void Main() {
        var a = new Solution();
        Console.WriteLine(a.LetterCombinations("234"));
    }
}