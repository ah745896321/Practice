using System.Text;
public class Solution
{
    public bool IsMatch(string s, string p)
    {
        Boolean[,] dp = new Boolean[s.Length+1,p.Length+1];
        dp[0,0] = true;
        for (int j = 2; j < p.Length+1; j++)
            if (p[j-1] == '*')
                dp[0,j] = dp[0,j - 2];
        //dp[0,j] = p[j - 1] == '*'&& dp[0,j - 2];
        for (int i = 1; i < s.Length + 1; i++)
            for (int j = 1; j < p.Length + 1; j++)
                if (p[j - 1] == s[i - 1] || p[j - 1] == '.')
                    dp[i,j] = dp[i - 1,j - 1];
                else if (p[j - 1] == '*')
                    dp[i,j] = dp[i,j - 2] || (s[i - 1] == p[j - 2] || p[j - 2] == '.') && dp[i - 1,j];
        return dp[s.Length,p.Length];
                    
    }

    static void Main() {
        var a = new Solution();
        Console.WriteLine(a.IsMatch("ab", ".*"));
    }
}
i代表文字長度
j代表patten長度
dp[i,j]紀錄是否Match
dp[0,j]->文字長度為0  Match可能 只有 * 0次時 或Patten長度也為0 故if (p[j-1] == '*') 則dp[0,j] = dp[0,j - 2];
如果 *前的字元相符
則兩者同時-1 結果相同
舉例
s=ab
p=a.
match=true
s=a
p=a
match=true
所以if (p[j - 1] == s[i - 1] || p[j - 1] == '.')  則dp[i,j] = dp[i - 1,j - 1];

*時 有兩種可能
這組* Match 0次
-> dp[i,j-2] (Match 0次 去掉不影響判斷結果，故結果應相等)

這組* Match 至少1次
則 字串減少一個 不影響結果 (Match 1次 -> Match 0次 符合*規則)
所以 dp[i-1,j] 答案與dp[i,j]相同
#Match一次 前提為 *前字元相符
即s[i - 1] == p[j - 2] || p[j - 2] == '.'