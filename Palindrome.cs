
namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable 
            string userinput = string.Empty;
            //Ask the user to input a string
            Console.WriteLine("Enter a string:");
            //Store the user input 
            userinput=Console.ReadLine();
            //convert , store, create an array 
            char[] temp = userinput.ToCharArray();
            //Reverse the string and store it in the variable 
            Array.Reverse(temp);
            //variable to compare
            string b = new string(temp);
            //Compare the input and the reverse
            if (userinput.Equals(b))
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }
    }
}
