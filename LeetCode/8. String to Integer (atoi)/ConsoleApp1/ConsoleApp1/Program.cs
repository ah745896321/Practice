public class Solution
{
    public int MyAtoi(string s)
    {
        bool negative = false;
        int i = 0;
        int result = 0;
        int len = s.Length;
        while (i < len && s[i] == ' ')
        {
            i++;
        }
        if (i < len && s[i] == '-')
        {
            negative = true;
            i++;
        }
        else if (i < len && s[i] == '+')
        {
            negative = false;
            i++;
        }
        while (i < len && s[i] >='0'&& s[i] <= '9')
        {
            if (negative && (-result < int.MinValue / 10 || -result == int.MinValue / 10 && s[i] > '8'))
                return int.MinValue;
            if (!negative && ( result > int.MaxValue / 10 || result == int.MaxValue / 10 && s[i] > '7'))
                return int.MaxValue;
            result *= 10;
            result += s[i] - '0';
            i++;
        }
        if (negative) result *= -1;
        return result;
    }

static void Main() {
        var a = new Solution();
        Console.WriteLine(a.MyAtoi("2147483648"));
    }
}