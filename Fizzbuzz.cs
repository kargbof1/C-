class Program
{
    static void Main(string[] args)
    {

        for (int i = 0; i <= 100; i++) //Create a list of the 100 numbers 
        {
            string results = "";
            //Divisible by 3 
            if (i % 3 == 0) results = "Fizz";
            //Divisible by 5
            if (i % 5 == 0) results = results + "Buzz";
            //Divisible by 3 and 5
            if (results.Length == 0) results = i.ToString();
            Console.WriteLine(results);

        }

    }
}
