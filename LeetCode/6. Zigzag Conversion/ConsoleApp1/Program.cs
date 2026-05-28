
public class Solution
{
    public string Convert(string s, int numRows)
    {
        int size = s.Length;
        int x = size;
        string result = "";
        for (int i = 0; i < size + numRows; i = i + numRows*2-2)
            if (i < size)
                result += s[i];
        for (int j = 1; j < numRows - 1; j++)
        {
            for (int i = j; i < size + numRows; i = i + numRows * 2 - 2)
            {
                if (i < size)
                    result += s[i];
                if (2 * numRows - 2-2*i%(2*numRows-2)+i < size)
                    result += s[2 * numRows - 2 - 2 * i % (2 * numRows - 2) + i];
            }
        }
        for (int i = numRows - 1; i < size + numRows; i = i + numRows * 2 - 2)
            if (i < size)
                result += s[i];
        return result;
    }

static void Main() {
        var a = new Solution();
        Console.WriteLine(a.Convert("PAYPALISHIRING",3));
    }
}