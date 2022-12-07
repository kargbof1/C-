public class ReverseString{ 

    static void Main ()
    {
        var input = "getting good at coding requires a lot of practice";
        Console.WriteLine(ReverseWords(input));
    }
static public string ReverseWords(string InString)
{
    StringBuilder sbReturnString = new StringBuilder();
    string[] strWords = InString.Split(" ");
    for (int i = strWords.Length - 1; i >= 0; i--)
    {
        if (i < strWords.Length - 1)
        {
            sbReturnString.Append(" ");
        }
        sbReturnString.Append(strWords[i]);
    }
    return sbReturnString.ToString();
}
};
