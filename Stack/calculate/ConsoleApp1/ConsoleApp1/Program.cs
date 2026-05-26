using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String input = "2+3*5";
            String temp = "";
            Stack<int> val = new Stack<int>();
            Stack<char> sym = new Stack<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                    continue;
                if (char.IsDigit(input[i]))
                {
                    while (i < input.Length && char.IsDigit(input[i]))
                    {
                        temp += input[i];
                        i++;
                    }
                    i--;
                    val.Push(Int32.Parse(temp));
                    temp = "";
                }
                else if (input[i] == '(')
                    sym.Push(input[i]);//考慮多層括號，在右括號處理
                else if (input[i] == ')')
                {
                    while (sym.Peek() != '(')
                        val.Push(small_calculate(sym.Pop(), val.Pop(), val.Pop()));
                    sym.Pop();
                }
                //負數判斷
                else if (input[i] == '-')
                {
                    if (i == 0 || input[i - 1] == '(' || "+-*/".Contains(input[i - 1]))
                    {
                        val.Push(0); // 補一個 0
                    }

                    while (sym.Count > 0 && priorities(sym.Peek()) >= priorities(input[i]))
                        val.Push(small_calculate(sym.Pop(), val.Pop(), val.Pop()));

                    sym.Push(input[i]);
                }
                //
                else
                {
                    while (sym.Count > 0 && priorities(sym.Peek()) >= priorities(input[i]))
                        val.Push(small_calculate(sym.Pop(), val.Pop(), val.Pop()));
                    sym.Push(input[i]);
                }
            }
            while (sym.Count > 0)
            val.Push(small_calculate(sym.Pop(), val.Pop(), val.Pop()));
            
            Console.WriteLine(val.Pop());
            Console.ReadLine();
        }
        static int priorities(char c)
        {
            if (c == '+' || c == '-')
                return 1;
            if (c == '*' || c == '/')
                return 2;
            return 0;
        }
        static int small_calculate(char c, int a, int b)
        {
            switch (c)
            {
            case '*':
                return a* b;
            case '/':
                return a / b;
            case '+':
                return a + b;
            case '-':
                return a - b;
            }
            return 0;
        }
        
    }
}
