using System.Collections;

public class ValidParentheses
{
    public bool Valid(String s)
    {
        Stack left = new Stack();
        foreach (char c in s.ToCharArray())
        {
            if (c == '(' || c == '{' || c == '[')
            {
                left.Push(c); // Get left
            }
            // Compare to right:
            else if (c == ')' && left.Count != 0 && (char)left.Peek() == '(')
            {
                left.Pop();
            }
            else if (c == '}' && left.Count != 0 && (char)left.Peek() == '{')
            {
                left.Pop();
            }
            else if (c == ']' && left.Count != 0 && (char)left.Peek() == '[')
            {
                left.Pop();
            }
            else
            {
                return false; // no match
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        ValidParentheses validParentheses = new ValidParentheses();
        string input = "()";
        Console.WriteLine(validParentheses.Valid("()")); // true
        Console.WriteLine(validParentheses.Valid("()[]{}")); // true
        Console.WriteLine(validParentheses.Valid("(]")); // false
        Console.WriteLine(validParentheses.Valid("([)]")); // false
        Console.WriteLine(validParentheses.Valid("{[]}")); // true
        Console.WriteLine();
    }
}
